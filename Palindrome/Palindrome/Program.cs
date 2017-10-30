using System;

namespace Palindrome {
    class Program {
        static void Main(string[] args) {

            string[] TextsEntered = { " ", " Anita lava la tina", " Maam ", "Ali tomo tila","This is not a palindrome", "Anna",
                "Civic", "Kayak", "Level", "Madam", "Mom", "Noon", "Racecar", "Day", "kiss", "Alli ves sevilla", "Aman a panama", " " };

            foreach(var item in TextsEntered) {

                if (item.Trim().Length <= 0)
                    continue;

                if (ValidatePalindrome(string.Join("", item.Split(' ')).ToLower()))
                    Console.WriteLine(item.Trim() + ", It is a Palindrome ");
                else
                    Console.WriteLine(item.Trim() + ", It is not a Palindrome");
            }
            Console.ReadKey();
        }

        private static bool ValidatePalindrome(string TextEntered) {
            
            var ArrayTextEntered = TextEntered.ToCharArray(0, TextEntered.Length);

            for (int x = 0, y = ArrayTextEntered.Length -1; x < ArrayTextEntered.Length; x++, y--) {
                if (ArrayTextEntered[x] != ArrayTextEntered[y])
                    return false;
            }
            return true;
        }

    }
}
