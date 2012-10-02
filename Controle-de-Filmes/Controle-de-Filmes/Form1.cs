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
        bool Editar = false;

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
        private void botao_Adicionar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "" && comboBoxGenero.Text != null && textBoxLocal.Text != "")
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
                    Limpar();
                }
            }
            else
                MessageBox.Show("Preencha todos os campos");
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            // Remover item selecionadodo ListView 
            Deletar();
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            //Remover item selecionados pela tecla Delete 
            if (e.KeyCode == Keys.Delete)
            {
                Deletar();
            }        
        }
        
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar_Item();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Gravar_Edicao();
        }
        #region "Função Deletar"
        private void Deletar()
        {
            foreach (ListViewItem listViewItem in listView1.SelectedItems)
            {
                // Remove o filme do dicionario que está selecionado no ListView
                string Genero = listViewItem.Group.Header;
                List<Filme> ListaFilme = dic[Genero];

                for (int I = 0; I < ListaFilme.Count; I++)
                    if (ListaFilme[I].Nome == listViewItem.Text)
                    {
                        ListaFilme.RemoveAt(I);
                        I--;
                    }
                //Remve item do ListView1
                listView1.Items.Remove(listViewItem);
            }
        }
        #endregion
        #region "Função Gravar_Edicao"
        private void Gravar_Edicao()
        {
            Filme FilmeEditado = new Filme(textBoxNome.Text, dateTimePicker1.ToString(), textBoxLocal.Text);
            if (textBoxNome.Text != "" && comboBoxGenero.Text != null && textBoxLocal.Text != "")
            {
                if (Editar)
                {
                    foreach (ListViewItem listViewItem in listView1.SelectedItems)
                    {
                        string Genero = listViewItem.Group.Header;
                        List<Filme> ListaFilme = dic[Genero];

                        for (int I = 0; I < ListaFilme.Count; I++)
                            if (ListaFilme[I].Nome == listViewItem.Text)
                            {
                                ListaFilme.RemoveAt(I);
                                I--;
                            }

                        if (dic.ContainsKey(comboBoxGenero.Text))
                        {
                            List<Filme> ListaX = dic[comboBoxGenero.Text];
                            ListaX.Add(FilmeEditado);
                        }
                        else
                        {
                            List<Filme> NovaLista = new List<Filme>();
                            NovaLista.Add(FilmeEditado);
                            dic.Add(comboBoxGenero.Text, NovaLista);
                        }
                        // grava o filme editado no item selecionado do ListView
                        listViewItem.Text = textBoxNome.Text;
                        listViewItem.Group.Header = comboBoxGenero.Text;
                        listViewItem.SubItems[1].Text = dateTimePicker1.Text;
                        listViewItem.SubItems[2].Text = textBoxLocal.Text;
                    }
                }
                else
                    MessageBox.Show("Não tem itens pra ser editados");
                Limpar();
                Editar = false;
            }
            else
                MessageBox.Show("Preencha todos os campos");
        }
        #endregion
        #region "Função Editar_Item"
        private void Editar_Item()
        {
            //percorre todo o ListView pra achar iten selecionado
            foreach (ListViewItem listViewItem in listView1.SelectedItems)
            {
                // Os campos serão iguais aos itens e subitens selecionado
                textBoxNome.Text = listViewItem.Text;
                comboBoxGenero.Text = listViewItem.Group.Header;
                dateTimePicker1.Text = listViewItem.SubItems[1].Text;
                textBoxLocal.Text = listViewItem.SubItems[2].Text;
            }
            Editar = true;
        }
        #endregion
        #region "Função para Limpar campos"
        private void Limpar()
        {
            //Limpar compos de texto
            textBoxNome.Text = "";
            comboBoxGenero.Text = null;
            textBoxLocal.Text = "";
        }
        #endregion
    }
}
