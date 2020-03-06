using System;

namespace KeyCheck {
    class Program {

        static void KeyLoop () {
            Console.Write ("Enter A Character: ");
            char ch = (char) Console.Read ();
            if (Char.IsUpper (ch)) {
                Console.WriteLine ("The Character is Uppercase");
            } else if (Char.IsLower (ch)) {
                Console.WriteLine ("The Character is Lowercase");
            } else if (Char.IsDigit (ch)) {
                Console.WriteLine ("The Character is a Number");
            } else {
                Console.WriteLine ("The Character is a From another planet! YOU ALIEN!");
            }
        }
        static void Main (string[] args) {

            KeyLoop ();

        }
    }
}