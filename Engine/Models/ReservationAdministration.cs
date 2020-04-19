using Engine.Models;

namespace Engine.Models
{
    public class ReservationAdministration
    {
        public string[] custommers;
        public string[] reservations;

        public ReservationAdministration()
        {
            
        }

        public void addCustomer(string email, string gender, string name, string surname, string streetadress, string postcode, string city,
            int phonenumber)
        {
            Custommer cust = new Custommer(email, gender, name, surname, streetadress, postcode, city, phonenumber);
        }

    }
}