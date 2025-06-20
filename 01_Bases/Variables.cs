partial class Program
{
    //PascalCase: Reservado para nombres de clases, métodos y propiedades.
    //camelCase: Reservado para nombres de variables y parámetros.
    static void Variables()
    {
        int edad = 22;
        string nombre = "Miguel Payan";
        bool esEstudiante = true;

        Console.WriteLine($"{nombre} tiene {edad} años y es estudiante: {esEstudiante}");
    }
}