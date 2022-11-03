using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class ContactVM
    {
        public Reservation Reservation { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
