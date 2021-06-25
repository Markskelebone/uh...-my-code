using System;

namespace glue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "elmer's gloop";
            Console.ForegroundColor = ConsoleColor .Cyan;
            Console.WindowHeight = 40;

           Console.WriteLine ("my name is elmer, i like glue, whats your name?");

            string userName = Console.ReadLine ();

            if (userName == "elmer")
            {
             Console.WriteLine ("my name is elmer too but i dont like you so your name sucks");
            }
            else
            {
                Console.WriteLine("hmm..." + userName + ", kinda a shit name tbh\nurname sucks ");
            }
            
            
            Console.ReadLine ();

            Console.WriteLine ("go away\nor not idk");

            Console.ReadLine ();   

            Console.WriteLine ("ok"); 

            Console.ReadLine ();

            Console.WriteLine ("whats your favorite flavor of food");
            
            
            
            string favoriteFlavor = Console.ReadLine ();


  if (favoriteFlavor == "blue")
  {
      Console.WriteLine ("my favorite flavor is blue too");
  }          

 else
 {
    Console.WriteLine ("okay... in my opinion blue is the best flavor\nyour opinion sucks ass");   
 }         

            double num01;
            double num02;
        
            Console.Write("give number: ");

            num01 = Convert.ToDouble( Console.ReadLine () );

            Console.Write ("give moar number: ");

            num02 = Convert.ToDouble(Console.ReadLine () );

            Double result = num01 * num02;

            Console.WriteLine ("both of those multiplied together give you " + result);

            Console.ReadLine ();

                        Console.WriteLine ("goodbye now bitch boy");

            Console.ReadLine ();

            Console.WriteLine ("come suck my glue stick");

            Console.ReadKey ();

        

            

        
        }
    }
}
