using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            UsuariotextBox.Focus();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text ==String.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();

            if (CodigoUsuariotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CodigoUsuariotextBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();

            if (UsuariotextBox.Text == "User" & CodigoUsuariotextBox.Text == "Hola mundo")
            {
                Form Login = new frmMenu();
                Login.Show();
            }
            UsuariotextBox.Clear();
            CodigoUsuariotextBox.Clear();
             
           
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuariotextBox.PasswordChar ==   '*')
            {
                CodigoUsuariotextBox.PasswordChar = '\0';
            }
            else
            {
                CodigoUsuariotextBox.PasswordChar = '*';
            }
        }
    }
}
