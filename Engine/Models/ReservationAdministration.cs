using Engine.Models;
using System.Collections.Generic;

namespace Engine.Models
{
    public class ReservationAdministration
    {
        public string[] custommers;
        public string[] reservations;
        public Custommer custommer;
        public Dictionary<string, double> ticketDictionary= new Dictionary<string, double>();

        public string movie;
        public string dataUrl;

        public string date;
        public string time;

        public List<string> chosenSnacks = new List<string>();

        public ReservationAdministration()
        {
            
        }

        public void AddCustomer(string email, string gender, string name, string surname, string streetadress, string postcode, string city,
            int phonenumber)
        {
           this.custommer = new Custommer(email, gender, name, surname, streetadress, postcode, city, phonenumber);
        }

        public void AddPlaceDateTime(string date, string time)
        {
            this.date = date;
            this.time = time;
        }

        public void AddTickets(string ID, double price)
        {
            ticketDictionary.Add(ID, price);
        }

    }
}