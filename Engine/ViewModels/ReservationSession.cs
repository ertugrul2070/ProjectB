using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using MySql.Data.MySqlClient;

namespace Engine.ViewModels
{
    public class ReservationSession
    {
        public ReservationAdministration CurrentReservation;
        public DatabaseConnection dbc = new DatabaseConnection();

        public static int _reservationID;

        public ReservationSession()
        {
            CurrentReservation = new ReservationAdministration();
            CurrentReservation.AddCustomer("hhh@hotmail.com","Male", "Homer", "Simpson", 
                "Pyong Yang 17", "321312","Parkweg", 061345665);
            CurrentReservation.AddMovie("3", "No Time To Die", "https://www.youtube.com/embed/KK8FHdFluOQ");

        }
    }
}
