﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa01Presentacion
{
    class Configuracion
    {
        public static string getConnetionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;
            }
        }
    }
}
