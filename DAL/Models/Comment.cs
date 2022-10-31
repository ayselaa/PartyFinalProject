using DAL.Base;
using DAL.Entity;
using DAL.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Comment : BaseEntity, IEntity
    {
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string Text { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }

    }
}
