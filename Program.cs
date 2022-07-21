using System;
using System.Windows.Forms;
using coursework.Forms;

namespace coursework
{
    public delegate void EmptyMessage();
    public delegate void AttachedMessage<T>(T obj);
    public delegate void ErrorMessage(string msg);
    public delegate void ParamsMessage(params object[] values);
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
