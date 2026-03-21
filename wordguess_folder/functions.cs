using System.Text;

namespace wordguess_folder
{
    public class Functions
    {
        Random random = new Random();
        string[] wordList = ["troposphere", "pineapple", "chair", "oranges", "strawberries"];
        public string MaskWord()
        {
            int attempts = 6;
            string selectedWord = wordList[random.Next(0, wordList.Length)];
            
            while(attempts > 0)
            {
                StringBuilder sb = new StringBuilder(selectedWord);
                int wordLength = selectedWord.Length - 2;



                for(int i = 1; i <= wordLength && i < sb.Length; i++)
            {                
                sb[i] = '*';
            }
                string maskedWord = sb.ToString();
                Console.WriteLine($"The word to guess is: {maskedWord} \n");


                Console.WriteLine($"You have {attempts} attempts left.");
                Console.Write("Enter your guess: ");
                string guess = Console.ReadLine() ?? string.Empty;

                if(guess == selectedWord)
                {
                    Console.WriteLine("Congratulations! You've guessed the word!");
                    return guess;
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again.");
                    attempts--;
                }
            }
            return string.Empty;
        }
    }
}