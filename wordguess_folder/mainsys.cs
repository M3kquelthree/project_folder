using System.Text;

namespace wordguess_folder
{
    public class Mainsys
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Word Guessing Game!");
            Console.WriteLine("Try to guess the word in 6 attempts.");

            
            Functions functions = new Functions();
            string res = functions.MaskWord();

            Console.WriteLine($"The word to guess is: {res}");

            

            

        }

    }
}
