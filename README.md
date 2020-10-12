# Week7Functions

## Gender

```
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            UsersGender();
            

        }
        public static void UsersGender()
        {
           Console.WriteLine("If you are male, press m, if you are female, press f !");
            string userInput = Console.ReadLine();
            if(userInput == "m")
            {
                Console.WriteLine("Hello, Sir!");
            }
            else if(userInput == "f")
            {
                Console.WriteLine("Hello, Madam!");
            }
            else
            {
                Console.WriteLine("Hello, Attack Helicopter.");
            }
        }
    }

```


## Functions Return

```
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("Enter your year of Birth: ");
            string userInput = Console.ReadLine();
            Validateage(CalculateAge(userInput));
            //int userage = CalculateAge(userInput);
            //Validateage(userage);
            //Console.WriteLine($"You are {userage} years old.");
        }
        public static int CalculateAge(string userInput)
        {
            int userage = 2020 - Int32.Parse(userInput);
            return userage;

        }
        public static void Validateage(int age)
        {
            if (age < 18 )
            {
                Console.WriteLine("you are not old enough to drink vodka xxx");

            }
            else
            {
                Console.WriteLine("Go get it blyat");
            }
        }

    }    

```
