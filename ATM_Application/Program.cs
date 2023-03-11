namespace atm_program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bank of Jack");
            Console.WriteLine("---------------------------\n");

            // initiate pin_code variable
            string pin_code = "";
            Console.WriteLine("Please enter your PIN code:");
            pin_code = Console.ReadLine();

        // check the validity of the PIN code
            // length of PIN code
            // too long
            while (pin_code.Length > 4)
            {
                Console.WriteLine($"You have entered a PIN code too long ({pin_code.Length}), please re-enter:");
                pin_code = Console.ReadLine();
            }
            // too short
            while (pin_code.Length < 4)
            {
                Console.WriteLine($"You have entered a PIN code too short ({pin_code.Length}), please re-enter:");
                pin_code = Console.ReadLine();
            }
            // numbers only
            double clean_pin_code = 0;
            while (!double.TryParse(pin_code, out clean_pin_code))
            {
                Console.WriteLine("You have used letters");
                Console.WriteLine("Please enter a 4 digit PIN code:");
                pin_code = Console.ReadLine();

            }
        }
    }
}

