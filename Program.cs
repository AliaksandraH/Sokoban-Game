using System;
using System.Windows.Forms;

namespace Sokoban
{
    public struct Place
    {
        public int x;
        public int y;
        public Place(int xx, int yy)
        {
            x = xx;
            y = yy;
        }
    }

    public enum Cell
    {
        none,
        wall,
        abox,
        done,
        here,
        user1,
        user2
    }

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }
    }
}
