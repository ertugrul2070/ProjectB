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

            makeReservationID();
        }

        private void makeReservationID()
        {
            try
            {
                dbc.cnn.Open();

                string query = "SELECT COUNT(*) as newResID FROM `reservations`.`reservationstable`";

                MySqlCommand command = new MySqlCommand(query, dbc.cnn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    _reservationID = reader.GetInt32("newResID") + 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbc.cnn.Close();
            }
        }
    }
}
