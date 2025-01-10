
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //ejemplo de prueba
        Console.WriteLine(RemoveDuplicateChars("AaAaBbBb")); // AaBb
        Console.WriteLine(RemoveDuplicateChars("Google")); // Gogle
        Console.WriteLine(RemoveDuplicateChars("Yahoo")); // Yaho
        Console.WriteLine(RemoveDuplicateChars("CNN")); // CN

    }

    /// <summary>
    /// Elimina los caracteres duplicados de una cadena manteniendo el orden original.
    /// </summary>
    /// <param name="input">Cadena de entrada.</param>
    /// <returns>Cadena sin caracteres duplicados.</returns>
    static string RemoveDuplicateChars(string input)
    {
        // Conjunto para registrar caracteres encontrados
        HashSet<char> seen = new HashSet<char>();
        //StringBuilder para construir la cadena resultante
        StringBuilder result = new StringBuilder();

        //Recorrer cada caracter de la cadena de entrada
        foreach(char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c); // Agregar caracter al conjunto
                result.Append(c); // Agregar caracter al resultado
            }
        }

        //Convertir y devolver la cadena resultante
        return result.ToString();
    }
}
