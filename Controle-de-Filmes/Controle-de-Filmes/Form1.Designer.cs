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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Ficção-científica", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Filmes Assistidos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cadastro);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.buttonRemover);
            this.Cadastro.Controls.Add(this.button1);
            this.Cadastro.Controls.Add(this.listView1);
            this.Cadastro.Controls.Add(this.textBoxLocal);
            this.Cadastro.Controls.Add(this.dateTimePicker1);
            this.Cadastro.Controls.Add(this.comboBoxGenero);
            this.Cadastro.Controls.Add(this.textBoxNome);
            this.Cadastro.Controls.Add(this.labelLocal);
            this.Cadastro.Controls.Add(this.labelData);
            this.Cadastro.Controls.Add(this.labelGenero);
            this.Cadastro.Controls.Add(this.label_NomeFilme);
            this.Cadastro.Location = new System.Drawing.Point(4, 22);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(830, 501);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomeFilme,
            this.data,
            this.local});
            this.listView1.FullRowSelect = true;
            listViewGroup1.Header = "Ação";
            listViewGroup1.Name = "Acao";
            listViewGroup2.Header = "Aventura";
            listViewGroup2.Name = "Aventura";
            listViewGroup3.Header = "Comédia";
            listViewGroup3.Name = "Comedia";
            listViewGroup4.Header = "Terror";
            listViewGroup4.Name = "Terror";
            listViewGroup5.Header = "Suspense";
            listViewGroup5.Name = "Suspense";
            listViewGroup6.Header = "Documentário";
            listViewGroup6.Name = "Documentario";
            listViewGroup7.Header = "Infantil";
            listViewGroup7.Name = "Infantil";
            listViewGroup8.Header = "Romance";
            listViewGroup8.Name = "Romance";
            listViewGroup9.Header = "Ficção-científica";
            listViewGroup9.Name = "ficcao-cientifica";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            this.listView1.Location = new System.Drawing.Point(58, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 402);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NomeFilme
            // 
            this.NomeFilme.Text = "Nome do Filme";
            this.NomeFilme.Width = 299;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 166;
            // 
            // local
            // 
            this.local.Text = "Local";
            this.local.Width = 235;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(526, 30);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(194, 20);
            this.textBoxLocal.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "ação",
            "aventura",
            "comédia",
            "terror",
            "suspense",
            "documentário",
            "infantil",
            "romance",
            "ficção científica"});
            this.comboBoxGenero.Location = new System.Drawing.Point(276, 30);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenero.TabIndex = 14;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(58, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(203, 20);
            this.textBoxNome.TabIndex = 13;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(523, 13);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(33, 13);
            this.labelLocal.TabIndex = 12;
            this.labelLocal.Text = "Local";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(409, 13);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Data ";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(273, 13);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 10;
            this.labelGenero.Text = "Gênero";
            // 
            // label_NomeFilme
            // 
            this.label_NomeFilme.AutoSize = true;
            this.label_NomeFilme.Location = new System.Drawing.Point(55, 13);
            this.label_NomeFilme.Name = "label_NomeFilme";
            this.label_NomeFilme.Size = new System.Drawing.Size(77, 13);
            this.label_NomeFilme.TabIndex = 9;
            this.label_NomeFilme.Text = "Nome do Filme";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(58, 56);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 19;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRemover;
    }
}

