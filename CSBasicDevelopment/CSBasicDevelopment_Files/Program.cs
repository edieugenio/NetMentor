// See https://aka.ms/new-console-template for more information
// Leer un fichero
using System.Reflection.PortableExecutable;

using (StreamReader reader = new StreamReader("c:\\ejemplo\\fichero.txt"))
{
    string text; // Creamos la variable que contendrá el texto
    while ((text = reader.ReadLine()) != null) // Leemos línea por línea
    {
        Console.WriteLine(text); // Mostramos la información
    }
}


// Escribir un fichero

// Tipo StreamWriter
string[] countries = new string[] { "USA", "England", "Germany" };
using (StreamWriter writer = new StreamWriter("C:\\ejemplo\\ficheroPaises.txt"))
{
    foreach(string item in countries)
    {
        writer.WriteLine(item);
    }
}

// Tipo File
File.WriteAllText("C:\\ejemplo\\ficheroPaises2.txt", "China Japón Korea");
File.WriteAllLines("C:\\ejemplo\\ficheroPaises3.txt", countries);