using Engine.Models;

namespace Engine.Models
{
    public class ReservationAdministration
    {
        public string[] custommers;
        public string[] reservations;
        public Custommer custommer;

        public ReservationAdministration()
        {
            
        }

        public void AddCustomer(string email, string gender, string name, string surname, string streetadress, string postcode, string city,
            int phonenumber)
        {
           custommer = new Custommer(email, gender, name, surname, streetadress, postcode, city, phonenumber);
        }

    }
}