﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Yazar
    {
        public int YazarId { get; set; }
        public string YazrAdiSoyadi { get; set; }
        public DateTime YazarDogumTarihi { get; set; }
    }
}