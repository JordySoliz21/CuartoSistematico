using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVehiculos
{
    public class Automovil : IVehiculo
    {
        private int gasolina;
        public Automovil(int CantidadLlenarGasolinaInicial)
        {
            gasolina = CantidadLlenarGasolinaInicial;
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("Su Automovil está conduciendo.");
            }
            else
            {
                Console.WriteLine("El Automovil no tiene suficiente gasolina para poder conducir.");
            }
        }
        public bool LlenarTanque(int CantidadLlenarGasolina)
        {
            if(CantidadLlenarGasolina >= 0)
            {
                gasolina += CantidadLlenarGasolina;
                return true;
            }
            else
            {
                Console.WriteLine("La cantidad de gasolina a llenar debe ser mayor o tiene que ser igual a 0.");
                return false;
            }
        }
    }
}
