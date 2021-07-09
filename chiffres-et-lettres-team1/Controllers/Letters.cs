using System;
using System.Collections.Generic;

namespace chiffres_et_lettres_team1.Controllers
{
    public class Letters
    {
        private List<String> vowel = new List<String>()
        {
            "a","e","i","o","u","y"
        };
        private List<String> consonant = new List<String>()
        {
            "b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","t","v","w","z"
        };
        private int number_of_letters = 10;
        private bool peer = true;
        private List<String> letters_in_game = new List<string>();
        private int number_of_vowel;

        public Letters()
        {
            Console.WriteLine("Combien de voyelle voulez vous?");
            int number_of_vowel = Convert.ToInt32(Console.ReadLine());
            if(number_of_vowel > number_of_letters)
            {
                number_of_vowel = number_of_letters;
            }
            int number_of_consonant = 0;
            if(number_of_vowel - number_of_letters < 0)
            {
                number_of_consonant -= number_of_vowel - number_of_letters;
            }
            int index = 0;
            Random random = new Random();
            for (index = 0;index <number_of_consonant; index++)
            {
                letters_in_game.Add(consonant[random.Next(consonant.Count)]);
            }
            for (index = 0; index < number_of_vowel; index++)
            {
                letters_in_game.Add(vowel[random.Next(consonant.Count)]);
            }
            Console.WriteLine(" Voici vaux lettres ");

            for (index = 0; index<number_of_letters; index++)
            {
                if(index != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(letters_in_game[index]
                    );
            }

        }
    }
}
