using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";


            Dictionary<string, int> counts = CountCharacters(text);
        }

        public static Dictionary<string, int> CountCharacters(string text)
        {
            return null;
        }
    }
}