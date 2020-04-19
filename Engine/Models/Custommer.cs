using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Models
{
    public class Custommer
    {
        public int ID;
        public string Email;
        public string[] Reservations;
        public string Gender;
        public string Name;
        public string Surname;
        public string StreetAdress;
        public string Postcode;
        public string City;
        public int PhoneNumber;
        
        public Custommer(string email, string gender, string name, string surname, string streetadress, string postcode, string city,
            int phonenumber)
        {
            this.ID = 1000;
            this.Email = email;
            this.Gender = gender;
            this.Name = name;
            this.Surname = surname;
            this.StreetAdress = streetadress;
            this.Postcode = postcode;
            this.City = city;
            this.PhoneNumber = phonenumber;
        }
        
    }
}
