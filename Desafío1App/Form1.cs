using Desafío1App.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Desafío1App
{
    public partial class WelcomeForm : Form
    {
        private int welcomeDuration = 15;
        public WelcomeForm()
        {
            InitializeComponent();

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

            //SE INICIA CUENTA REGRESIVA EN INTERVALOS DE 1000 MILISEGUNDOS (1 SEGUNDO)
            CountDownWelcome.Interval = 1000;
            CountDownWelcome.Start();
        }

        private void CountDownWelcome_Tick(object sender, EventArgs e)
        {
            welcomeDuration--;
            if (welcomeDuration <= 0)
            {
                CountDownWelcome.Stop();
                Hide();
                FrmLogin formLogin = new();
                formLogin.StartPosition = FormStartPosition.CenterScreen;
                formLogin.Show();

            }
        }
    }
}