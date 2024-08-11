using CADAplicacionComercial;

namespace AplicacionComercial
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text =="")
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un USUARIO");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuario, "");
            if (txtContrasena.Text == "")
            {
                errorProvider1.SetError(txtContrasena, "Debe ingresar una contrasena");
                txtContrasena.Focus();
                return;
            }
            errorProvider1.SetError(txtContrasena, "");
            if (CADUsuario.ValidarUsuario(txtUsuario.Text, txtContrasena.Text) == true)
            {
                MessageBox.Show("Exito", "Entrada al sistema con exito", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrectos", "Error", MessageBoxButtons.OK);

            }
        }
    }
}
