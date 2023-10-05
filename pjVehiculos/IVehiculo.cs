using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVehiculos
{
    public interface IVehiculo
    {
        void Conducir();
        bool LlenarTanque(int CantidadLlenarGasolina);
    }
}
