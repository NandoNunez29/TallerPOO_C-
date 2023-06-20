using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Conosla
{

    public interface IVehiculo
    {
        public void Conducir();       

        public bool Repostar(int cantidadGasolina);

    }
}