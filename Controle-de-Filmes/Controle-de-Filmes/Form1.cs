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
            //Adiciona no grupo que tem o mesmo índice do combobox
            FilmeAssistido.Group = listView1.Groups[comboBoxGenero.SelectedIndex];
            listView1.Items.Add(FilmeAssistido);//Adiciona

            //converte a Data
            dateTimePicker1.Value.ToShortDateString();
            //Passagem por referência pra classe 'Filme'
            Filme FilmeX = new Filme(textBoxNome.Text, dateTimePicker1.ToString(), textBoxLocal.Text);

            if (dic.ContainsKey(comboBoxGenero.Text))
            {
                //Se a chave com a lista ja existir, armazena o filme dentro da lista existente
                List<Filme> ListaX = dic[comboBoxGenero.Text];
                //Adiciona FilmeX na ListaX
                ListaX.Add(FilmeX);
            }
            else
            {
                //Se a lista não existir, cria uma nova lista
                List<Filme> NovaLista = new List<Filme>();
                //Adiciona FilmeX na ListaFilmes
                NovaLista.Add(FilmeX);
                //Adiciona a lista de Filmes no dicionário
                dic.Add(comboBoxGenero.Text, NovaLista);
            }                       
        }
        private void Deletar()
        {
            foreach (ListViewItem listViewItem in listView1.SelectedItems)
            {
                //Remve item do Lis ListView1
                listView1.Items.Remove(listViewItem);

                // Remove o filme do dicionario que está selecionado no ListView
                string Genero = listViewItem.Group.Header;
                List<Filme> ListaFilme = dic[Genero];

                for (int I = 0; I < ListaFilme.Count; I++)
                    if (ListaFilme[I].Nome == listViewItem.Text)
                    {
                        ListaFilme.RemoveAt(I);
                        I--;
                    }
            }
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            // Remover item selecionadodo ListView 
            foreach (ListViewItem listViewItem in listView1.SelectedItems)
            {   
                    Deletar();
            }

        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            //Remover item selecionados pela tecla Delete 
            if (e.KeyCode == Keys.Delete)
            {
                Deletar();
            }        
        }
    }
}
