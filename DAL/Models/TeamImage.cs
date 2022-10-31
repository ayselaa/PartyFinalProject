﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class TeamImage : IEntity
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
