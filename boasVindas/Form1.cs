namespace boasVindas
{
    public partial class frmAula01 : Form
    {
        public frmAula01()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
            string nomeUsuario; //Declaração de variável string
            nomeUsuario = txtNome.Text;
            MessageBox.Show("Bem vindo ao C#, " + nomeUsuario + "!", "Olá!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensagem.Text = $"Bem vindo ao C#, {nomeUsuario}!";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAula01_Load(object sender, EventArgs e)
        {

        }
    }
}