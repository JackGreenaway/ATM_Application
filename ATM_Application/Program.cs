using ATM_Library;

namespace atm_program
{
    class program
    {
        static void Main(string[] args)
        {
            // temp valid PIN code
            string temp_code = "0000";

            Console.WriteLine("Welcome to the bank of Jack");
            Console.WriteLine("---------------------------\n");

            while (true)
            {
                // initiate pin_code variable
                string pin_code = "";
                Console.WriteLine("Please enter your 4 digit PIN code:");
                pin_code = Console.ReadLine();

                // check the validity of the PIN code

                pin_code pin_length = new pin_code();

                pin_length.pin_validity(pin_code);
                if (pin_code != temp_code)
                {
                    Console.WriteLine("Invalid PIN Code");
                }
                else
                {
                    break;
                }
            }

            // entry granted

            Console.WriteLine("\n-------------");
            Console.WriteLine("Welcome back!");

            Random random = new Random();
            double balance = random.Next(100, 10000);

            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine($"Current balance: £{balance}\n");
                Console.WriteLine("What would you like to do?\n");

                // ATM options
                string op = "";
                Console.WriteLine("\t 1. Deposit (d)");
                Console.WriteLine("\t 2. Withdraw (w)");
                op = Console.ReadLine();

                balance_alt balance_alt = new balance_alt();

                balance = balance_alt.balance_change(balance, op);

                Console.WriteLine("Would you like to exit?");

                Console.WriteLine("Enter 'n' to close the app, press any other key to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n\n");
            }
        }
    }
}

