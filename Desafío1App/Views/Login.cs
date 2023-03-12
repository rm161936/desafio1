using Desafío1App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1App.Views
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            List<Users> usersList = Users.LocalDbUsers();

            var userLogin = usersList.Where(i => i.Username.Equals(TxtUser.Texts) && i.Password.Equals(TxtPassword.Texts)).FirstOrDefault();

            if (userLogin != null)
            {
                //SE CREA VARIABLE DE SESION CON CLASE ESTATICA PARA VALIDAR USUARIO CUANDO SEA NECESARIO
                ActiveSession.Sesion = true;
                ActiveSession.UserName = userLogin.Username;
                ActiveSession.Categorias = CategoriaModel.LocalDbCategories();
                Hide();
                MainForm frm = new();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Por favor ingrese su usuario personal de acceso al sistema de estadisticas.","Usuario Incorrecto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }


        }
    }
}
