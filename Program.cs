using System;

namespace PrintCharactersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Please enter sentance :");
            string SentanceStr = Console.ReadLine();
            string frequentCharacter = "";
            Console.WriteLine("Please enter frequent character :");
            frequentCharacter = Console.ReadLine();
            while (frequentCharacter.Length != 1)
            {
                frequentCharacter = Console.ReadLine();
                Console.WriteLine("Please enter frequent character with length size 1 only");
            }
            
            int FrequentCharacterCount = GetFrequentCharacterCountByCharacter(SentanceStr, frequentCharacter);
            Console.WriteLine("Frequent Character is : "+frequentCharacter +"");
            Console.WriteLine("Character Count is : "+FrequentCharacterCount);
            Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Some error in Main Method ");
            }
        }

        static int GetFrequentCharacterCountByCharacter(string SentanceStr, string InputCharacter)
        {
            int count = 0;
            try
            {
                if (SentanceStr.Length > 0)
                {
                    string Character = InputCharacter.ToString().ToUpper();
                    for (int j = 0; j < SentanceStr.Length; j++)
                    {
                        if (SentanceStr[j].ToString().ToUpper() == Character.ToString())
                        {
                            count++;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Some error in GetFrequentCharacterCountByCharacter Method ");
            }
            return count;
        }
    }
}
