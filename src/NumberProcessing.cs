using System;

public static class NumberUtility
{
    /// <summary>
    /// Tarea 1: Calcula si un número es palíndromo.
    /// Un número es palíndromo si se lee igual de izquierda a derecha que de derecha a izquierda.
    /// </summary>
    public static bool IsPalindrom(int number)
    {
        // Los números negativos no son palíndromos por el signo "-"
        if (number < 0) return false;
        
        int original = number;
        int reversed = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;
            reversed = (reversed * 10) + lastDigit;
            number /= 10;
        }

        return original == reversed;
    }

    /// <summary>
    /// Tarea 2: Cuenta las ocurrencias de la secuencia "22" en un número.
    /// Para n = 222, el resultado es 2 porque hay dos solapamientos de "22".
    /// </summary>
    public static int CountOccurrencesOf22(int number)
    {
        int count = 0;
        // Trabajamos con el valor absoluto por si se ingresan negativos
        number = Math.Abs(number);

        while (number >= 22)
        {
            // Verificamos si los últimos dos dígitos terminan en 22
            if (number % 100 == 22)
            {
                count++;
            }
            // Dividimos por 10 para desplazar un dígito a la vez y detectar solapamientos
            number /= 10;
        }

        return count;
    }
}

