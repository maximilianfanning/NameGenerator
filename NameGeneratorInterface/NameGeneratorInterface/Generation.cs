using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGeneratorInterface
{
    public class Generation
    {
        private char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '.', '-', '&', '\'', '/', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public string finalWord;
        int isVowel = 2;
        /*
         * The value 0 is a vowel
         * The value 1 is a consonant
         * The value 2 means it can be whatever
         */

        public Generation(string serializedLetterData, string serializedFirstLetterData, string minLength, string maxLength)
        {
            string letterDataText = File.ReadAllText(serializedLetterData);
            string firstLetterDataText = File.ReadAllText(serializedFirstLetterData);
            int[,] letterData = JsonConvert.DeserializeObject<int[,]>(letterDataText);
            int[] firstLetterData = JsonConvert.DeserializeObject<int[]>(firstLetterDataText);
            finalWord = ReturnFullName(letterData, firstLetterData, Convert.ToInt32(minLength), Convert.ToInt32(maxLength));
        }
        public char ReturnFirstLetter(int[] firstLetterData)
        {
            int sumOfAll = ArrayElementAdd(firstLetterData);
            Random rng = new Random();
            int placeHolder = rng.Next(0, (sumOfAll + 1));
            for (int i = 0; i < firstLetterData.Length; i++)
            {
                placeHolder -= firstLetterData[i];
                if (placeHolder <= 0)
                {
                    return NumberToLetter(i);
                }
            }
            throw new InvalidOperationException("Yo ur place holder never reached or went below zero");
        }
        public string ReturnWordFromFirstLetter(char firstLetter, int[,] letterData, int minLength, int maxLength)
        {
            string output = (char.ToUpper(firstLetter)).ToString();
            Random rng = new Random();
            char previousLetter = firstLetter;
            for (int i = 0; i < rng.Next(minLength, maxLength + 1); i++)
            {
                int placeHolder = rng.Next(0, (ArrayElementAdd(letterData, LetterToNumber(previousLetter))) + 1);
                for (int k = 0; k < 41; k++)
                {
                    placeHolder -= letterData[LetterToNumber(previousLetter), k];
                    if (placeHolder <= 0)
                    {
                        bool Check;
                        if (output.Length > 1)
                        {
                            Check = CriteriaCheck(letterData, i, output);
                        }
                        else
                        {
                            Check = true;
                        }
                        if (((isVowel == 1 && CheckForVowel(NumberToLetter(k)) == true) || (isVowel == 0 && CheckForVowel(NumberToLetter(k)) == false)) || Check == false)
                        {
                            placeHolder = rng.Next(0, (ArrayElementAdd(letterData, LetterToNumber(previousLetter))) + 1);
                            k = 0;
                            i--;
                        }
                        else
                        {
                            output += NumberToLetter(k).ToString();
                            previousLetter = NumberToLetter(k);
                            break;
                        }
                    }
                }
            }
            return output;
        }
        private bool CriteriaCheck(int[,] letterData, int i, string currentOutput)
        {
             if ((currentOutput[i] == currentOutput[i - 1] && i != 0 && (currentOutput[i] != 'a' && currentOutput[i] != 'h' && currentOutput[i] != 'i' && currentOutput[i] != 'j' && currentOutput[i] != 'k' && currentOutput[i] != 'q' && currentOutput[i] != 'u' && currentOutput[i] != 'v' && currentOutput[i] != 'w' && currentOutput[i] != 'x' && currentOutput[i] != 'y')))
            {
                if (CheckForVowel(currentOutput[i]))
                {
                    isVowel = 0;
                }
                else
                {
                    isVowel = 1;
                }
                return true;
            }
            else if (!CheckForVowel(currentOutput[i]) && !CheckForVowel(currentOutput[i - 1]))
            {
                isVowel = 1;
                return true;
            }
            else
            {
                isVowel = 2;
            }
            return false;
        }
        public string ReturnFullName(int[,] letterData, int[] firstLetterData, int minLength, int maxLength)
        {
            string finalWord = ReturnWordFromFirstLetter(ReturnFirstLetter(firstLetterData), letterData, minLength, maxLength);
            return finalWord;
        }

        private int ArrayElementAdd(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }
            return sum;
        }
        private int ArrayElementAdd(int[,] inputArray, int position1)
        {
            int sum = 0;
            if (isVowel == 0)
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i == 41)
                    {
                        int butter = 4;
                        butter++;
                    }
                    if (!CheckForVowel(NumberToLetter(i)))
                    {
                        sum += inputArray[position1, i];
                    }
                }
            }
            else if (isVowel == 1)
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (CheckForVowel(NumberToLetter(i)))
                    {
                        sum += inputArray[position1, i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < 41; i++)
                {
                    sum += inputArray[position1, i];
                }
            }
            return sum;
        }
        public int LetterToNumber(char input)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (input == alphabet[i])
                {
                    return (i);
                }
            }
            throw new InvalidOperationException("Could not find character in array");
        }
        public char NumberToLetter(int input)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (input == i)
                {
                    return alphabet[i];
                }
            }
            throw new InvalidOperationException("Could not find number in the array");
        }
        private bool CheckForVowel(int input)
        {
            if (NumberToLetter(input) == 'a' || NumberToLetter(input) == 'e' || NumberToLetter(input) == 'i' || NumberToLetter(input) == 'o' || NumberToLetter(input) == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckForVowel(char input)
        {
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
