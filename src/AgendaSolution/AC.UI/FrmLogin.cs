using AC.BLL;
using AC.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
           Usuario usuario = new Usuario();
           bool loginValido;
           usuario.UserName = txbUsuario.Text;
           usuario.Password = txbSenha.Text;

           var login = new UsuarioBLL();
           loginValido = login.AutenticarAcesso(usuario);


           if(loginValido == true)
            {
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Atenção !!!, Usuário ou Senha inválidos");
            }


        }
    }
}
