using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antropofagico
{
    public partial class Form3 : Form
    {

        List<string> Arquivos = new List<string>();
        private ListBox Listbox;
        public Form3(List<string> arquivos,ListBox lst)
        {
            InitializeComponent();
            Arquivos = arquivos;
            Listbox = lst;

        }
        private void Renomear()
        {
            int indice = 1;
            int indice_grupos = 1;
            string nomeEscolhido = textBox1.Text;
            
            if (nomeEscolhido.Contains("-"))
            {
                nomeEscolhido = nomeEscolhido.Replace('-', '_'); 
            }


            foreach (string file in Arquivos)
            {
                string pathAntiga = Path.GetDirectoryName(file) + "\\";
                string nomeNovo = pathAntiga + nomeEscolhido + indice.ToString() + "-" + indice_grupos.ToString() + ".txt";
                File.Move(file, nomeNovo);
                if (indice_grupos == int.Parse(textBox2.Text))
                {
                    indice_grupos = 0;
                    indice++;
                }
                indice_grupos++;
            }
            indice = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renomear();
            MessageBox.Show("Arquivos Renomeados","Aviso",MessageBoxButtons.OK,MessageBoxIcon.None);
            Listbox.Items.Clear();
            Arquivos.Clear();
            this.Close();
        }
    }
}
