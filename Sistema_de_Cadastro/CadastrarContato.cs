using MySql.Data.MySqlClient;
using Sistema_de_Cadastro.RegrasDeNegocio;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace Sistema_de_Cadastro
    {
    public partial class CadastrarContato : Form
        {
        private MySqlConnection conexao;

        private MySqlCommand comando;

        public CadastrarContato()
            {
            InitializeComponent();
            cbSexo.Items.AddRange(new object[] { "Masculino" , "Feminino" });
            cbSexo.Text = "Selecione";
            edNome.Focus();


            }

        public void Conexao()
            {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
            }

        private void Salvar()
            {
            Conexao();
            var nome = edNome.Text;
            var cpf = edCPF.Text;
            var telefone = edTelefone.Text;
            var sexo = cbSexo.Text;
            var dataNasc = dtpDataNasc.Value;



            string querry = "insert into contato (nome_con, cpf_con, telefone_con, sexo_con ,data_nasc_cont) values (@_nome, @_cpf, @_telefone, @_sexo, @_data_nasc)";
            var comando = new MySqlCommand(querry , conexao);

            comando.Parameters.AddWithValue("@_nome" , nome);
            comando.Parameters.AddWithValue("@_cpf" , cpf);
            comando.Parameters.AddWithValue("@_telefone" , telefone);
            comando.Parameters.AddWithValue("@_sexo" , sexo);
            comando.Parameters.AddWithValue("@_data_nasc" , dataNasc);


            comando.ExecuteNonQuery();
            conexao.Close();

            }


        private void btCadastrar_Click(object sender , EventArgs e)
            {

            if (VerificarCampos())
                {
                MessageBox.Show("Preencha todos os campos" , "Incompleto");
                }
            else
                {
                Salvar();

                edNome.Clear();
                edCPF.Clear();
                edTelefone.Clear();
                cbSexo.Text = "Selecione";
                var opcao = MessageBox.Show("Salvo com sucesso! \nDeseja realizar um novo cadastro" , "Salvo" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                    {
                    edNome.Focus();
                    }
                else
                    {
                    this.Close();
                    }
                }

            }
        private void CadastrarContato_Load(object sender , EventArgs e)
            {

            }

        private void button1_Click(object sender , EventArgs e)
            {
            ListarContatos lista = new ListarContatos();
            lista.ShowDialog();
            }
        public bool VerificarCampos()
            {

            List<string> campos = new List<string> { edNome.Text , edCPF.Text , edTelefone.Text };


            bool verificadoCampos = campos.Any(string.IsNullOrEmpty);//&& cbSexo.;

            return verificadoCampos;
            }

        }
    }
