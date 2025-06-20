partial class Program
{
    //PascalCase: Reservado para nombres de clases, métodos y propiedades.
    //camelCase: Reservado para nombres de variables y parámetros.
    static void DataTypes()
    {
        int entero = 42;
        double decimalNumber = 3.1416;
        bool booleano = true;
        char caracter = 'A'; //Usar comillas simples para caracteres
        string cadenaTexto = "Hola C#!"; //Usar comillas dobles para cadenas de texto

        Console.WriteLine($"Entero: {entero}, Decimal: {decimalNumber}, Booleano: {booleano}, Caracter: {caracter}, Cadena: {cadenaTexto}");
    
    }
}