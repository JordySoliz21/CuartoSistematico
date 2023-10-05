using pjVehiculos;

Automovil automovil = new Automovil(0);

Console.WriteLine("Ingrese la cantidad de gasolina que desea para llenar el tanque: ");
int CantidadLlenarGasolina =  int.Parse(Console.ReadLine());

bool LlenadoRealizado = automovil.LlenarTanque(CantidadLlenarGasolina);
if (LlenadoRealizado)
{
    Console.WriteLine("El tanque de su vehiculo ha sido llenado con éxito!");
}
automovil.Conducir();