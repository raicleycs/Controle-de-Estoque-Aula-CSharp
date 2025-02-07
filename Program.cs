using System;
using System.Windows.Forms;
using ControleDeEstoque.Database;

namespace ControleDeEstoque
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Database.Initialize(); // Cria tabelas se não existirem
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
