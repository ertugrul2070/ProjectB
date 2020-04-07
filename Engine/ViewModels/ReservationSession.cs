using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class ReservationSession
    {
        public Person CurrentPerson { get; set; }
        public Custommer CurrentCustommer { get; set; }

        public ReservationSession()
        {
            CurrentPerson = new Person();
            CurrentPerson.gender = "Male";
            CurrentPerson.name = "Homer";
            CurrentPerson.surname = "Simpson";
            CurrentPerson.streetAdress = "Pyong yang 17";
            CurrentPerson.postcode = "3213SC";
            CurrentPerson.city = "Kim Jong Simpson";
            CurrentPerson.phoneNumber = 0612345678;
            CurrentCustommer.email = "kimsimpson@gemmm.com";
        }
    }
}
