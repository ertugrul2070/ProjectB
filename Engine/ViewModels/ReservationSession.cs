﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class ReservationSession
    {
        public ReservationAdministration CurrentReservation;

        public ReservationSession()
        {
            CurrentReservation = new ReservationAdministration();
            CurrentReservation.AddCustomer("hhh@hotmail.com","Male", "Homer", "Simpson", 
                "Pyong Yang 17", "321312","Parkweg", 061345665);
        }
    }
}