﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public abstract class Horse : Hoofed
    {
        public Horse(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname)
            : base(birthDate, weight, habitat, tame, wool, nickname)
        {
            HoofType = HoofType.Paranormous;
        }
    }
}
