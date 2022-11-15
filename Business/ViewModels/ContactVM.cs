using DAL.Models;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class ContactVM
    {
        public Reservation Reservation { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
