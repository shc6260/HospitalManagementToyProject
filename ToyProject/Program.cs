using System;
using System.Windows.Forms;
using ToyProject.Core.Service;
using ToyProject.Presenter;

namespace ToyProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            new MainPresenter(mainForm, new MessageService(mainForm)); // Presenter 연결
            Application.Run(mainForm);
        }
    }
}
