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
        public Person person;
        
        public Custommer(string email, string gender, string name, string surname, string streetadress, string postcode, string city,
            int phonenumber)
        {
            this.ID = 1000;
            this.Email = email;
            this.person = new Person(gender, name, surname, streetadress, postcode, city, phonenumber);
        }
        
        
    }
}
