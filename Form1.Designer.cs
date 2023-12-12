namespace Antropofagico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnConverter;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            st = new StatusStrip();
            slblStatus = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStrip1 = new ToolStrip();
            tsddbArquivo = new ToolStripDropDownButton();
            tsmiAbrirArquivo = new ToolStripMenuItem();
            tsmiConverterArquivo = new ToolStripMenuItem();
            lstArquivos = new ListBox();
            lblArquivos = new Label();
            txtArquivos = new TextBox();
            btnProcurar = new Button();
            comboBox1 = new ComboBox();
            RemoveSelecionado = new Button();
            RemoveTodos = new Button();
            renomearToolStripMenuItem = new ToolStripMenuItem();
            btnConverter = new Button();
            st.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConverter.Location = new Point(250, 480);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(300, 40);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // st
            // 
            st.Items.AddRange(new ToolStripItem[] { slblStatus, toolStripProgressBar1 });
            st.Location = new Point(0, 539);
            st.Name = "st";
            st.Size = new Size(784, 22);
            st.TabIndex = 0;
            st.Text = "statusStrip1";
            // 
            // slblStatus
            // 
            slblStatus.AutoSize = false;
            slblStatus.Margin = new Padding(0, 3, 360, 2);
            slblStatus.Name = "slblStatus";
            slblStatus.Size = new Size(200, 17);
            slblStatus.Text = "STATUS:";
            slblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(200, 16);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsddbArquivo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsddbArquivo
            // 
            tsddbArquivo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddbArquivo.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbrirArquivo, tsmiConverterArquivo, renomearToolStripMenuItem });
            tsddbArquivo.Image = (Image)resources.GetObject("tsddbArquivo.Image");
            tsddbArquivo.ImageTransparentColor = Color.Magenta;
            tsddbArquivo.Name = "tsddbArquivo";
            tsddbArquivo.Size = new Size(62, 22);
            tsddbArquivo.Text = "Arquivo";
            // 
            // tsmiAbrirArquivo
            // 
            tsmiAbrirArquivo.Name = "tsmiAbrirArquivo";
            tsmiAbrirArquivo.Size = new Size(180, 22);
            tsmiAbrirArquivo.Text = "Abrir";
            // 
            // tsmiConverterArquivo
            // 
            tsmiConverterArquivo.Name = "tsmiConverterArquivo";
            tsmiConverterArquivo.Size = new Size(180, 22);
            tsmiConverterArquivo.Text = "Converter";
            // 
            // lstArquivos
            // 
            lstArquivos.FormattingEnabled = true;
            lstArquivos.ItemHeight = 15;
            lstArquivos.Location = new Point(12, 81);
            lstArquivos.Name = "lstArquivos";
            lstArquivos.Size = new Size(760, 394);
            lstArquivos.TabIndex = 2;
            // 
            // lblArquivos
            // 
            lblArquivos.AutoSize = true;
            lblArquivos.Location = new Point(12, 34);
            lblArquivos.Name = "lblArquivos";
            lblArquivos.Size = new Size(52, 15);
            lblArquivos.TabIndex = 4;
            lblArquivos.Text = "Arquivo:";
            // 
            // txtArquivos
            // 
            txtArquivos.Location = new Point(12, 52);
            txtArquivos.Name = "txtArquivos";
            txtArquivos.Size = new Size(420, 23);
            txtArquivos.TabIndex = 5;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(438, 52);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(75, 23);
            btnProcurar.TabIndex = 6;
            btnProcurar.Text = "Procurar...";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 490);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 9;
            // 
            // RemoveSelecionado
            // 
            RemoveSelecionado.Location = new Point(634, 52);
            RemoveSelecionado.Name = "RemoveSelecionado";
            RemoveSelecionado.Size = new Size(138, 23);
            RemoveSelecionado.TabIndex = 10;
            RemoveSelecionado.Text = "Remover Selecionado";
            RemoveSelecionado.UseVisualStyleBackColor = true;
            RemoveSelecionado.Click += button3_Click;
            // 
            // RemoveTodos
            // 
            RemoveTodos.Location = new Point(634, 480);
            RemoveTodos.Name = "RemoveTodos";
            RemoveTodos.Size = new Size(138, 23);
            RemoveTodos.TabIndex = 11;
            RemoveTodos.Text = "Remover Todos";
            RemoveTodos.UseVisualStyleBackColor = true;
            RemoveTodos.Click += RemoveTodos_Click;
            // 
            // renomearToolStripMenuItem
            // 
            renomearToolStripMenuItem.Name = "renomearToolStripMenuItem";
            renomearToolStripMenuItem.Size = new Size(180, 22);
            renomearToolStripMenuItem.Text = "Renomear";
            renomearToolStripMenuItem.Click += renomearToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(RemoveTodos);
            Controls.Add(RemoveSelecionado);
            Controls.Add(comboBox1);
            Controls.Add(btnProcurar);
            Controls.Add(txtArquivos);
            Controls.Add(lblArquivos);
            Controls.Add(btnConverter);
            Controls.Add(lstArquivos);
            Controls.Add(toolStrip1);
            Controls.Add(st);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Antropofagico";
            st.ResumeLayout(false);
            st.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip st;
        private ToolStripStatusLabel slblStatus;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsddbArquivo;
        private ToolStripMenuItem tsmiAbrirArquivo;
        private ToolStripMenuItem tsmiConverterArquivo;
        private ListBox lstArquivos;
        private Label lblArquivos;
        private TextBox txtArquivos;
        private Button btnProcurar;
        private ComboBox comboBox1;
        private Button RemoveSelecionado;
        private Button RemoveTodos;
        private ToolStripMenuItem renomearToolStripMenuItem;
    }
}