using Sistema_de_Cadastro;

namespace Sistema_de_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarContato cadastrarContato = new CadastrarContato();
            cadastrarContato.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarContatos lista = new ListarContatos();
            lista.ShowDialog();
        }
    }
}