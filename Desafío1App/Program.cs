using Desafío1App.Views;

namespace Desafío1App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            WelcomeForm Form = new()
            {
                StartPosition = FormStartPosition.CenterScreen
            };


            Application.Run(Form);
        }
    }
}