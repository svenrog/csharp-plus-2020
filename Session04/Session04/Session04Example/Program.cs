using System;
using System.Linq;

namespace Session04Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 1, 2, 3, 4 };

            // Antalet värden i arrayen
            int arrayLength = array.Length;

            // Komma åt data i arrayen, index är baserat på 0
            int firstPosition = array[0];

            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y', 'å', 'ä', 'ö' };
            
            // Se om arrayen innehåller ett värde
            // Använda linq
            vowels.Contains('å');

            // Ger ett index på vilken position i arrayen som innehåller tex å
            // -1 om det givna värdet inte finns
            int vowelIndex = Array.IndexOf(vowels, 'å');
            
            // Ovan är samma som detta, det som skiljer är att man får tillbaks den sista positionen
            int vowelIndexFromLoop = -1;

            for (int i = 0; i < vowels.Length; i++)
            {
                var currentVowel = vowels[i];
                if (currentVowel == 'å')
                    vowelIndexFromLoop = currentVowel;
            }

            // Man kan istället göra så här för att få identiskt resultat med Array.IndexOf
            vowelIndexFromLoop = -1;

            for (int i = 0; i < vowels.Length; i++)
            {
                var currentVowel = vowels[i];
                if (currentVowel == 'å')
                {
                    vowelIndexFromLoop = i;
                    break;
                }   
            }

            // Man bör skriva så här
            vowelIndexFromLoop = -1;

            for (int i = 0; i < vowels.Length; i++)
            {
                var currentVowel = vowels[i];
                if (currentVowel != 'å')
                    continue;

                vowelIndexFromLoop = i;
                break;
            }

            // Går att göra samma sak med tex språk-koder
            string[] supportedLanguages = new string[] { "sv", "no", "dk" };
            int languageIndexFromLoop = -1;

            for (int i = 0; i < supportedLanguages.Length; i++)
            {
                var currentLanguage = supportedLanguages[i];
                if (currentLanguage != "sv")
                    continue;

                languageIndexFromLoop = i;
                break;
            }
        }

        static int GetSupportedLanguageIndex(string language)
        {
            string[] supportedLanguages = new string[] { "sv", "no", "dk" };

            for (int i = 0; i < supportedLanguages.Length; i++)
            {
                var currentLanguage = supportedLanguages[i];
                if (currentLanguage == language)
                    return i;
            }

            return -1;
        } 
    }
}
