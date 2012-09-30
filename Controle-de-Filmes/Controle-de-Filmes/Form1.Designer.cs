namespace Controle_de_Filmes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup28 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup29 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup30 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup31 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup32 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup33 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup34 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup35 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup36 = new System.Windows.Forms.ListViewGroup("Ficção-científica", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NomeFilme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.label_NomeFilme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Filmes Assistidos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cadastro);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // Cadastro
            // 
            this.Cadastro.BackColor = System.Drawing.SystemColors.Menu;
            this.Cadastro.Controls.Add(this.buttonGravar);
            this.Cadastro.Controls.Add(this.buttonEditar);
            this.Cadastro.Controls.Add(this.buttonRemover);
            this.Cadastro.Controls.Add(this.buttonAdicionar);
            this.Cadastro.Controls.Add(this.listView1);
            this.Cadastro.Controls.Add(this.textBoxLocal);
            this.Cadastro.Controls.Add(this.dateTimePicker1);
            this.Cadastro.Controls.Add(this.comboBoxGenero);
            this.Cadastro.Controls.Add(this.textBoxNome);
            this.Cadastro.Controls.Add(this.labelLocal);
            this.Cadastro.Controls.Add(this.labelData);
            this.Cadastro.Controls.Add(this.labelGenero);
            this.Cadastro.Controls.Add(this.label_NomeFilme);
            this.Cadastro.Controls.Add(this.groupBox1);
            this.Cadastro.Location = new System.Drawing.Point(4, 27);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(830, 496);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravar.Location = new System.Drawing.Point(165, 289);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(119, 55);
            this.buttonGravar.TabIndex = 21;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(34, 289);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(119, 55);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(165, 228);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(119, 55);
            this.buttonRemover.TabIndex = 19;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(33, 228);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(119, 55);
            this.buttonAdicionar.TabIndex = 18;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomeFilme,
            this.data,
            this.local});
            this.listView1.FullRowSelect = true;
            listViewGroup28.Header = "Ação";
            listViewGroup28.Name = "Acao";
            listViewGroup29.Header = "Aventura";
            listViewGroup29.Name = "Aventura";
            listViewGroup30.Header = "Comédia";
            listViewGroup30.Name = "Comedia";
            listViewGroup31.Header = "Terror";
            listViewGroup31.Name = "Terror";
            listViewGroup32.Header = "Suspense";
            listViewGroup32.Name = "Suspense";
            listViewGroup33.Header = "Documentário";
            listViewGroup33.Name = "Documentario";
            listViewGroup34.Header = "Infantil";
            listViewGroup34.Name = "Infantil";
            listViewGroup35.Header = "Romance";
            listViewGroup35.Name = "Romance";
            listViewGroup36.Header = "Ficção-científica";
            listViewGroup36.Name = "ficcao-cientifica";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup28,
            listViewGroup29,
            listViewGroup30,
            listViewGroup31,
            listViewGroup32,
            listViewGroup33,
            listViewGroup34,
            listViewGroup35,
            listViewGroup36});
            this.listView1.Location = new System.Drawing.Point(306, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 461);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // NomeFilme
            // 
            this.NomeFilme.Text = "Nome do Filme";
            this.NomeFilme.Width = 209;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 95;
            // 
            // local
            // 
            this.local.Text = "Local";
            this.local.Width = 191;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(33, 170);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(251, 24);
            this.textBoxLocal.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 24);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "Ficção-científica"});
            this.comboBoxGenero.Location = new System.Drawing.Point(33, 110);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(125, 26);
            this.comboBoxGenero.TabIndex = 14;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(33, 55);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(251, 24);
            this.textBoxNome.TabIndex = 13;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.Location = new System.Drawing.Point(30, 148);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(49, 18);
            this.labelLocal.TabIndex = 12;
            this.labelLocal.Text = "Local";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(171, 88);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 18);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Data ";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(30, 88);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(64, 18);
            this.labelGenero.TabIndex = 10;
            this.labelGenero.Text = "Gênero";
            // 
            // label_NomeFilme
            // 
            this.label_NomeFilme.AutoSize = true;
            this.label_NomeFilme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_NomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NomeFilme.Location = new System.Drawing.Point(30, 33);
            this.label_NomeFilme.Name = "label_NomeFilme";
            this.label_NomeFilme.Size = new System.Drawing.Size(123, 18);
            this.label_NomeFilme.TabIndex = 9;
            this.label_NomeFilme.Text = "Nome do Filme";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 461);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label label_NomeFilme;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NomeFilme;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader local;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

