namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintResponseToFavoriteSubject());
            Console.WriteLine("Happy Friday! You just went through exercise 2. Now for exercise 1.");



            //Exercise 1

            
            var r = new Random();

            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number!");

            

            var userGuessedNumber = false;

            do
            {

                var userInput = int.Parse(Console.ReadLine());




                if (userInput < favNumber)
                {
                    Console.WriteLine("Sorry, but that guess is too low! Try Again!");

                }

                else if (userInput > favNumber)

                {
                    Console.WriteLine("Sorry, but that guess is too high! Try again!");




                }

                else

                {
                    Console.WriteLine("Congrats! You guessed my number!");

                    userGuessedNumber = true;

                }
                
            } while (!userGuessedNumber);





            //Exercise 2



      

            static string PrintResponseToFavoriteSubject()
            {
                Console.WriteLine("What is your favorite school subject?");

                var subject = Console.ReadLine();

                switch (subject)
                {

                    case "Math":


                    Console.WriteLine ("I think math is great too!");

                    break;



                    case "Reading":

                    Console.WriteLine("I read alot because I like to learn new things!");

                    break;



                    case "Science":

                    Console.WriteLine("Science is my favorite subject! I like it because I analyze everything!");

                    break;



                    case "History":

                    Console.WriteLine("I read alot because I like to learn new things!");

                    break;



                    case "Gym":

                    Console.WriteLine("Science is my favorite subject! I like it because I analyze everything!");

                    break;



                    default:

                        Console.WriteLine("I am not too familiar with that subject" + subject);

                        break;




                }

                return "";





            }



        }
    }
}
