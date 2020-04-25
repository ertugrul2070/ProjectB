using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.ViewModels;
using Engine.Models;

namespace UI
{
    public static class Program
    {
        public static ReservationSession _ReservationSession = new ReservationSession();
        public static DatabaseConnection dbc = new DatabaseConnection();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Overzicht());
        }
    }
}
