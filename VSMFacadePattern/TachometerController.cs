﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern.Controllers
{
    class TachometerController:ITachometerController
    {

        public int Rpm
        {
            get;
            set;
        }

        public int Limit
        {
            get;
            private set;
        }

        public TachometerController()
        {
            Limit = 5000;
        }
    }
}
