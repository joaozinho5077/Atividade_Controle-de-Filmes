using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_Filmes
{
    public partial class Form1 : Form
    {
        
        //List<Filme> Filmes = new List<Filme>();
        Dictionary<string, List<Filme>> dic = new Dictionary<string, List<Filme>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
                ListViewItem FilmesAssistido = new ListViewItem();
                FilmesAssistido.Text = (textBoxNome.Text);
                FilmesAssistido.SubItems.Add(dateTimePicker1.Text);
                FilmesAssistido.SubItems.Add(textBoxLocal.Text);
                FilmesAssistido.Group = listView1.Groups[comboBoxGenero.SelectedIndex];
                listView1.Items.Add(FilmesAssistido);

                Filme X = new Filme (textBoxNome.Text, comboBoxGenero.Text, dateTimePicker1.Text, textBoxLocal.Text);
                dic[comboBoxGenero.Text].Add();
                //dic.Add("Ação", );
            
        }
    }
}
