namespace CarpinteriaLogin
{
    public partial class FrmLogin : Form
    {
        string User = "Local";
        string Password = "1234";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        public bool Verificar(string user, string pas)
        {
            bool valido = false;

            if (txtUser.Text.Equals(user) & txtPass.Text.Equals(pas))
            {
                valido = true;
            }
            return valido;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(Verificar(User, Password))
            {
                FrmAltaPresupuesto frmPresupuesto = new FrmAltaPresupuesto();
                frmPresupuesto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario incorrectos. Intente de nuevo");
                txtUser.Text = String.Empty;
                txtPass.Text = String.Empty;
            }
        }

        private void cbxMosPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMosPass.Checked)
            {
                txtPass.Visible = true;
            }
            else
            {
                txtPass.Visible = false;
            }
        }
    }
}