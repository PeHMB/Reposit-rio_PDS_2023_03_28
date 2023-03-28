using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Cadastro
{
    public partial class ListarContatos : Form
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;

        public ListarContatos()
        {
            InitializeComponent();
            Conexao();
            CarregarDados();

            dgvContato.Columns[0].HeaderText = "ID";
            dgvContato.Columns[1].HeaderText = "Nome";
            dgvContato.Columns[2].HeaderText = "CPF";
            dgvContato.Columns[3].HeaderText = "Telefone";
            dgvContato.Columns[4].HeaderText = "Sexo";
            dgvContato.Columns[5].HeaderText = "Data Nascimento";



        }

        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();

            

        }

        private void CarregarDados()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM contato", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dgvContato.DataSource = dt;



        }
        private void ListarContatos_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //adicionar o verificaror
            //Caso seja CPF a pessoa digita sem mascara mas o na hora de pesquisar no banco de dados ele consulte com mascara

            string querry = "Select * from contato where nome_con like '%" + edNome.Text + "%' OR cpf_con like '" + edNome.Text + "%'";
            MySqlCommand command = new MySqlCommand(querry, conexao);

            // Preenche o DataGridView com os resultados da consulta SQL
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvContato.DataSource = table;




        }
    }
}

