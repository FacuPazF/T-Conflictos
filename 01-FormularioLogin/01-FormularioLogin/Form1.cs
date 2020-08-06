using System;
using System.Windows.Forms;

namespace _01_FormularioLogin
{
    public partial class frmLogin : Form
    {

<<<<<<< HEAD
        //Comentario Facu
=======
        // Constructor de la Clase frmLogin
>>>>>>> bec520d88417281df532d2377385dd09ddf77cd9
        public frmLogin()
        {

            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string clave = "admin";

            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                this.txtUsuario.Focus();
                MessageBox.Show("DATO REQUERIDO: USUARIO", "DATO REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                this.txtClave.Focus();
                MessageBox.Show("DATO REQUERIDO: CLAVE", "DATO REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtUsuario.Text == usuario && this.txtClave.Text == clave)
            {
                MessageBox.Show("ACCESO AL SISTEMA CORRECTO", "ESTADO DEL ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            else
            {
                MessageBox.Show("USUARIO Y/O CLAVE INCORRECTOS", "ESTADO DEL ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtUsuario.Focus();
                this.txtClave.Text = "";
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
