using Engine.Models;
using Engine.ViewModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Engine.Models
{
    public class ReservationAdministration
    {
        public int resID;
        DatabaseConnection dbc = new DatabaseConnection();
        public Custommer custommer;
        public Dictionary<string, double> ticketDictionary;
        public int TicketAmount;

        public string movie;
        public string dataUrl;
        public string MovieId;
        public int zaal = (new Random()).Next(1,11);


        public string date;
        public string time;

        public Dictionary<string, string> Seats;

        public List<string> chosenSnacks = new List<string>();

        public ReservationAdministration()
        {
            
        }

        public void AddCustomer(string email, string gender, string name, string surname, string streetadress, string postcode, string city,
            int phonenumber)
        {
           this.custommer = new Custommer(email, gender, name, surname, streetadress, postcode, city, phonenumber);
        }

        public void AddMovie(string moviename, string moviepic, string movieid)
        {
            this.MovieId = movieid;
            this.dataUrl = moviepic;
            this.movie = moviename;
        }

        public void AddPlaceDateTime(string date, string time)
        {
            this.date = date;
            this.time = time;
        }

        public void AddSeats(Dictionary<string, string> seats)
        {
            this.Seats = seats;
        }

        public void AddTickets(string ID, double price)
        {
            ticketDictionary.Add(ID, price);
            TicketAmount++;
        }

        public void ReservationToDatabase()
        {

            try
            {
                dbc.cnn.Open();

                ExecuteSqlQuery($"INSERT INTO `mydb`.`reservations` (`customer_idcustomer`, `date`) VALUES ('{GetCustomerID()}', '{this.date}');");
                resID = GetReservationID();
                //ExecuteSqlQuery($"INSERT INTO `mydb`.`reservation_snack` (`snackcatelogus_idsnackcatelogus`, reservation_idreservation) VALUES('1', '2');");
                ExecuteSqlQuery($"INSERT INTO `mydb`.`reservation_zaal` (reservering_idreservering, cinemahall_idcinemahall) VALUES ('{this.zaal}', '{resID}');");

                //ExecuteSqlQuery($"");
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                dbc.cnn.Close();
            }
        }

        private int GetCustomerID()
        {
            string query = $"SELECT idUsers FROM mydb.customers WHERE email LIKE '{this.custommer.Email}';";
            MySqlCommand command = new MySqlCommand(query, dbc.cnn);
            MySqlDataReader dataReader = command.ExecuteReader();

            int id = 0;

            while (dataReader.Read())
            {
                id = (int) dataReader.GetInt32("idUsers");
            }

            dataReader.Close();
            return id;
        }

        private int GetReservationID()
        {
            string query = $"SELECT MAX(idreservations) as id FROM mydb.reservations;";
            MySqlCommand command = new MySqlCommand(query, dbc.cnn);
            MySqlDataReader dataReader = command.ExecuteReader();

            int id = 0;

            while (dataReader.Read())
            {
                id = (int)dataReader.GetInt32("id");
            }

            dataReader.Close();
            return id;
        }


        private void ExecuteSqlQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, dbc.cnn);
            command.ExecuteNonQuery();
        }

    }
}