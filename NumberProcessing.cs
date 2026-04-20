using System;

public class NumberProcessing
{
    // Tarea 1: Verificar si un número es palíndromo
    public static bool IsPalindrome(int n)
    {
        string numStr = n.ToString();
        int left = 0;
        int right = numStr.Length - 1;

        while (left < right)
        {
            if (numStr[left] != numStr[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    // Tarea 2: Contar cuántas veces aparece "22" en el número
    public static int Count22(int n)
    {
        string numStr = n.ToString();
        int count = 0;

        for (int i = 0; i < numStr.Length - 1; i++)
        {
            if (numStr[i] == '2' && numStr[i + 1] == '2')
                count++;
        }
        return count;
    }

    
    public static void Main()
    {
        Console.WriteLine(IsPalindrome(12321)); // True
        Console.WriteLine(IsPalindrome(12341)); // False
        Console.WriteLine(IsPalindrome(888));   // True

        Console.WriteLine(Count22(122));     // 1
        Console.WriteLine(Count22(222));     // 2
        Console.WriteLine(Count22(32224222)); // 4
    }
}