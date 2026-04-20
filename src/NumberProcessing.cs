using System;

namespace ProcessingNumbersAssessment2
{
    public static class ProcessingNumbers
    {
        /// <summary>
        /// Determina si un número es palíndromo sin usar conversiones a string.
        /// </summary>
        public static bool IsNumberPalindrome(uint number)
        {
            // Optimizaciones rápidas
            if (number < 10) return true;
            if (number % 10 == 0) return false;

            uint original = number;
            uint reversed = 0;

            while (number > 0)
            {
                // Invertimos el número matemáticamente
                reversed = (reversed * 10) + (number % 10);
                number /= 10;
            }

            return original == reversed;
        }

        /// <summary>
        /// Cuenta cuántas veces aparece el par "22" en un número.
        /// </summary>
        public static int CountOccurrenceOf22InDecimalNumberRepresentaion(uint number)
        {
            int count = 0;
            
            // Analizamos el número mientras sea mayor o igual a 22
            while (number >= 22)
            {
                // El operador % 100 nos devuelve los últimos dos dígitos
                if (number % 100 == 22)
                {
                    count++;
                }
                // Desplazamos un dígito para revisar el siguiente par (permite detectar 222 como 2 ocurrencias)
                number /= 10;
            }
            
            return count;
        }
    }
}

