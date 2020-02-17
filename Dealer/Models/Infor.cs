using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealer.Models
{
    public class Infor
    {

        private static List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos
        {
            get
            {
                if (vehiculos == null)
                {
                    vehiculos = new List<Vehiculo>();
                }
                return vehiculos;
            }
            }

       
    }
    
    }


