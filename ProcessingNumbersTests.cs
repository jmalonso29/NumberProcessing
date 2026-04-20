using NUnit.Framework;
using ProcessingNumbersAssessment2; // Asegúrate de que el namespace coincida

namespace ProcessingNumbersAssessment2.Tests
{
    [TestFixture]
    public class ProcessingNumbersTests
    {
        [TestCase(757U, true)]
        [TestCase(989U, true)]
        [TestCase(777U, true)]
        [TestCase(99U, true)]
        [TestCase(585U, true)]
        [TestCase(8888U, true)]
        [TestCase(1234554321U, true)]
        [TestCase(988U, false)]
        [TestCase(12345U, false)]
        [TestCase(0U, true)] // Caso límite: el cero es palíndromo
        public void IsNumberPalindrome_ValidatesCorrectness(uint number, bool expected)
        {
            bool result = ProcessingNumbers.IsNumberPalindrome(number);
            
            Assert.That(result, Is.EqualTo(expected), 
                $"Error: El número {number} {(expected ? "debería" : "no debería")} ser un palíndromo.");
        }

        [TestCase(1U, 0)]
        [TestCase(22U, 1)]
        [TestCase(222U, 2)] // Prueba de solapamiento
        [TestCase(32224222U, 4)]
        [TestCase(22222222U, 7)]
        [TestCase(1234526278U, 0)]
        public void CountOccurrenceOf22_ReturnsExpectedCount(uint number, int expected)
        {
            int result = ProcessingNumbers.CountOccurrenceOf22InDecimalNumberRepresentaion(number);

            Assert.That(result, Is.EqualTo(expected), 
                $"Error en el número {number}: se esperaban {expected} ocurrencias de '22', pero se encontraron {result}.");
        }
    }
}