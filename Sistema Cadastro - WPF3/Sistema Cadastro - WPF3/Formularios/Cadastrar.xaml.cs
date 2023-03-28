using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Sistema_Cadastro___WPF3.Formularios
{
    /// <summary>
    /// Lógica interna para Cadastrar.xaml
    /// </summary>
    public partial class Cadastrar : Window
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;


        public Cadastrar()
        {
            InitializeComponent();
        }

        public void Conexao()
        {
            string conexaoString = "server=localhost;database=banco_PDS;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conexao();
            var nome = edNome.Text;
            var cpf = edCPF.Text;
            var telefone = edTelefone.Text;
            string sexo = null;
            var dataNasc = dtpDataNasc;


            bool masculino = Convert.ToBoolean(rdMasculino);
            bool feminino = Convert.ToBoolean(rdFeminino);

            
            if (!masculino && !feminino)
            {
                MessageBox.Show("Marque uma opção");
            }
            else 
            {
                if (masculino)
                {
                    sexo = "Feminino";
                }
                
            }

            string querry = "insert into contato (nome_con, cpf_con, telefone_con, sexo_con ,data_nasc_cont) values (@_nome, @_cpf, @_telefone, @_sexo, @_data_nasc)";
            var comando = new MySqlCommand(querry, conexao);

            comando.Parameters.AddWithValue("@_nome", nome);
            comando.Parameters.AddWithValue("@_cpf", cpf);
            comando.Parameters.AddWithValue("@_telefone", telefone);
            comando.Parameters.AddWithValue("@_sexo", sexo);
            comando.Parameters.AddWithValue("@_data_nasc", dataNasc);


            comando.ExecuteNonQuery();
            conexao.Close();

        }
    }
}
