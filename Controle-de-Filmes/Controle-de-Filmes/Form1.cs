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

        //Dicionario com Lista de Filmes, onde a chave do dicionário é o gênero do filme
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
            //Adiciona Itens no ListView
            ListViewItem FilmeAssistido = new ListViewItem();
            FilmeAssistido.Text = (textBoxNome.Text);
            FilmeAssistido.SubItems.Add(dateTimePicker1.Text);
            FilmeAssistido.SubItems.Add(textBoxLocal.Text);
            //Adiciona do grupo que tem o mesmo índice do combobox
            FilmeAssistido.Group = listView1.Groups[comboBoxGenero.SelectedIndex];
            listView1.Items.Add(FilmeAssistido);//Adiciona

            //Passagem por referência pra classe 'Filme'
            Filme FilmeX = new Filme(textBoxNome.Text, comboBoxGenero.Text, dateTimePicker1.Text, textBoxLocal.Text);

            if (dic.ContainsKey(comboBoxGenero.Text))
            {
                //Se a chave com a lista ja existir, armazena o filme dentro dela
                List<Filme> ListaX = dic[comboBoxGenero.Text];
                //Adiciona FilmeX na ListaX
                ListaX.Add(FilmeX);
            }
            else
            {
                //Se a lista não existir cria uma nova lista
                List<Filme> NovaLista = new List<Filme>();
                //Adiciona FilmeX na ListaFilmes
                NovaLista.Add(FilmeX);
                //Adiciona a lista de Filmes no dicionário
                dic.Add(comboBoxGenero.Text, NovaLista);
            }                       
        }
    }
}
