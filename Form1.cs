using System.Runtime.InteropServices;
using HDF.PInvoke;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Antropofagico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            slblStatus.Text = "STATUS: Pronto para uso";
            toolStripProgressBar1.Visible = true;
            comboBox1.Items.Add("Conversor HDF");
            comboBox1.Items.Add("Conversor DPT");
            comboBox1.Items.Add("Conversor PCA");
            comboBox1.SelectedIndex = 2;

        }


        public int Conta_Arquivo = -1;
        public double valor = 0;
        public int counting = -1;
        public int conta_posicao = -1;
        public int contarepeticao = 0;
        public string[,] Matriz = new string[0, 0];

        Object selectedItemlst;
        private List<string> arquivos = new();
        public Object selectedItem;
        public string PastaPadrao;

        private List<string> ArquivosQueVaoSerLidos = new();
        private List<double> Lista_PCA = new();
        public int n = 1;
        public string referencia = null;
        public string PastadosConvertidos = "\\Rom_Convertidas\\";


        //COISAS PRA ARRUMAR

        //PASTA DOS CONVERTIDOS ESCOLHIDA PELO USUARIO ; VALOR FIXO EM 2048, TORNA-LO FlEXIVEL ; NOVO ARQUIVO CSV COM TODOS OS ARQUIVOS EM CADA COLUNA ; 
        

        private void Ativa_ProgressBar()
        {

            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
        }
        private void Desliga_ProgressBar()
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
        }
        private void Reset_Das_Variaveis()
        {
            Lista_PCA = new();
            contarepeticao = 0;
            ArquivosQueVaoSerLidos = new();
            Conta_Arquivo = -1;
        }
        private void Reset_Final()
        {
            arquivos = new();
            Conta_Arquivo = -1;
            valor = 0;
            counting = -1;
            conta_posicao = -1;
            contarepeticao = 0;
            Matriz = new string[0, 0];
            ArquivosQueVaoSerLidos = new();
            Lista_PCA = new();
            referencia = null;
        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lstArquivos.Items.Clear();
            arquivos.Clear();
            OpenFileDialog ofd = new();
            lstArquivos.Items.Clear();
            ofd.Multiselect = true;
            ofd.Filter = "Arquivos TXT |*.txt*";
            DialogResult ofdDialog = ofd.ShowDialog();

            foreach (string item in ofd.FileNames)
            {
                arquivos.Add(item);
            }

            PastaPadrao = Path.GetDirectoryName(ofd.FileName);

            foreach (string item in arquivos)
                lstArquivos.Items.Add(item);

            slblStatus.Text = "STATUS: Arquivo(s) Carregado(s)";


            if (ofdDialog == DialogResult.OK)
            {
                DialogResult SimouNao = MessageBox.Show("Todos os arquivos estão no formato compativel com a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (SimouNao == DialogResult.Yes)
                {
                    return;
                }
                else if (SimouNao == DialogResult.No)
                {
                    Form3 JanelaRenomear = new Form3(arquivos, lstArquivos);
                    JanelaRenomear.ShowDialog();
                }

            }




        }
        private void Calculo_PCA(string[,] Matriz)
        {
            for (int j = 0; j <= 2048 - 1; j++)
            {
                for (int i = 0; i <= contarepeticao - 1; i++)
                {
                    valor += (double.Parse(Matriz[j, i]) / contarepeticao);
                }

                Lista_PCA.Add(valor);
                valor = 0;
            }
            string dir = PastaPadrao + PastadosConvertidos;


            if (Directory.Exists(dir))
            {
                using (StreamWriter sw = new(dir + "Rom" + n.ToString() + ".csv"))
                {
                    foreach (var item in Lista_PCA)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(dir);

                using (StreamWriter sw = new(dir + "Rom" + n.ToString() + ".csv"))
                {
                    foreach (var item in Lista_PCA)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            n++;
        }
        private void LeituraDosArquivos(string arquivo, string[,] Matriz)
        {
            Conta_Arquivo += 1;
            counting = -1;

            using StreamReader leitor = new(arquivo);
            {
                while (!leitor.EndOfStream)
                {

                    string linha = leitor.ReadLine();
                    counting += 1;

                    string[] l = linha.Split(";");

                    for (int i = 0; i < 2; i++)
                    {
                        if (i > 0)
                        {
                            Matriz[counting, Conta_Arquivo] = l[i];
                        }
                    }
                }
            }
        }
        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (lstArquivos.Items.Count != 0)
            {
                selectedItem = comboBox1.SelectedItem;

                Task.Run(() =>
                {

                    if (selectedItem.ToString() == "Conversor PCA")
                    {
                        n = 1;

                        Invoke(() =>
                        {
                            Ativa_ProgressBar();
                            RemoveSelecionado.Enabled = false;
                            RemoveTodos.Enabled = false;
                            slblStatus.Text = "STATUS: Calculando...";
                        });

                        for (int y = 0; y <= arquivos.Count() - 1; y++)
                        {

                            string ArquivoSemExtensao = Path.GetFileNameWithoutExtension(arquivos[y]);
                            string[] refs = ArquivoSemExtensao.Split("-");

                            if (referencia == null)
                            {
                                referencia = refs[0];
                            }


                            if (arquivos[y].Contains(referencia))
                            {
                                contarepeticao++;
                                ArquivosQueVaoSerLidos.Add(arquivos[y]);

                            }
                            else
                            {
                                y--;

                                Matriz = new string[2048, contarepeticao];

                                foreach (string arquivos in ArquivosQueVaoSerLidos)
                                {
                                    LeituraDosArquivos(arquivos, Matriz);
                                }

                                Calculo_PCA(Matriz);
                                Reset_Das_Variaveis();

                                referencia = refs[0];
                            }

                            if (y == arquivos.Count() - 1)
                            {
                                Matriz = new string[2048, contarepeticao];

                                foreach (string arquivos in ArquivosQueVaoSerLidos)
                                {
                                    LeituraDosArquivos(arquivos, Matriz);
                                }

                                Calculo_PCA(Matriz);
                                Reset_Das_Variaveis();
                            }
                        }

                        System.Diagnostics.Process.Start("explorer.exe", PastaPadrao + PastadosConvertidos);
                        Reset_Final();
                        Invoke(() =>
                        {
                            lstArquivos.Items.Clear();
                            RemoveSelecionado.Enabled = true;
                            RemoveTodos.Enabled = true;
                            Desliga_ProgressBar();
                            slblStatus.Text = "STATUS: Pronto para uso";
                        });

                        MessageBox.Show("Aplicação realizada com sucesso");
                    }
                });
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            selectedItemlst = lstArquivos.SelectedItem;

            if (selectedItemlst is not null)
            {

                lstArquivos.Items.Remove(selectedItemlst);
                arquivos.Remove(selectedItemlst.ToString());

            }
        }
        private void RemoveTodos_Click(object sender, EventArgs e)
        {
            lstArquivos.Items.Clear();
            arquivos.Clear();
        }
        private void renomearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 JanelaRenomear = new Form3(arquivos,lstArquivos);
            JanelaRenomear.ShowDialog();

        }
    }
}
