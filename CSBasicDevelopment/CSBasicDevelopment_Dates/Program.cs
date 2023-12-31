﻿// See https://aka.ms/new-console-template for more information
DateTime fecha1 = new DateTime(1989, 11, 2);
DateTime fecha2 = new DateTime(1978, 4, 15);
//int fechaResultado = DateTime.Compare(fecha1, fecha2);
//indistintamente
int fechaResultado = fecha1.CompareTo(fecha2);

if (fechaResultado < 0)
{
    Console.WriteLine("La primera fecha es menor");
}
else if (fechaResultado == 0)
{
    Console.WriteLine("Las fechas son iguales");
}
else
{
    Console.WriteLine("La segunda fecha es menor");
}

// Imprimir fecha con formato
DateTime fecha = new DateTime(1989, 11, 2, 11, 16, 16, 123);
Console.WriteLine(fecha.ToString());
Console.WriteLine(fecha.ToShortDateString());
Console.WriteLine(fecha.ToLongDateString());
Console.WriteLine(fecha.ToShortTimeString());
Console.WriteLine(fecha.ToString("yyy-MM-ddThh:mm:ss.ms"));


