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
        public Person CurrentReservation { get; set; }

        public ReservationSession()
        {
            CurrentReservation = new Person();
            CurrentReservation.gender = "Male";
            CurrentReservation.name = "Homer";
            CurrentReservation.surname = "Simpson";
            CurrentReservation.streetAdress = "Pyong yang 17";
            CurrentReservation.city = "Kim Jong Simpson";
            CurrentReservation.phoneNumber = 0612345678;
        }
    }
}
