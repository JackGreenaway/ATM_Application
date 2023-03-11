using System.Reflection.Metadata.Ecma335;

namespace ATM_Library
{
    public class pin_code
    {
        public string pin_validity(string pin_code)
        {
            while (true)
            {
                while (true)
                {
                    // numbers only
                    double clean_pin_code = 0;
                    if (!double.TryParse(pin_code, out clean_pin_code))
                    {
                        Console.WriteLine("You have used letters");
                        Console.WriteLine("Please enter a 4 digit PIN code:");
                        pin_code = Console.ReadLine();
                        break;
                    }
                    // too long
                    if (pin_code.Length > 4)
                    {
                        Console.WriteLine($"You have entered a PIN code too long ({pin_code.Length}), please re-enter:");
                        pin_code = Console.ReadLine();
                        break;
                    }
                    // too short
                    if (pin_code.Length < 4)
                    {
                        Console.WriteLine($"You have entered a PIN code too short ({pin_code.Length}), please re-enter:");
                        pin_code = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        return pin_code;
                    }
                }

            }
        }
    }
    public class balance_alt
    {
        public double balance_change(double balance, string op)
        {
            double bal = 0;
            switch (op)
            {
                case "d":
                    // get deposit amount
                    Console.WriteLine("\nHow much would you like to deposit?");
                    string deposit_amt = Console.ReadLine();
                    double new_deposit_amt = 0;

                    // convert string to double 
                    while (!double.TryParse(deposit_amt, out new_deposit_amt))
                    {
                        Console.WriteLine("Please enter a number:");
                        deposit_amt = Console.ReadLine();
                    }
                    bal = balance + new_deposit_amt;

                    // output new balance
                    Console.WriteLine("Deposit Successful");
                    Console.WriteLine($"New balance: £{bal}");
                    return bal;
                    break;


                case "w":
                    // get withdraw amount
                    Console.WriteLine("\nHow much would you like to withdraw?");
                    string withdraw_amt = Console.ReadLine();
                    double new_withdraw_amt = 0;

                    // convert string to double 
                    while (!double.TryParse(withdraw_amt, out new_withdraw_amt))
                    {
                        Console.WriteLine("Please enter a number:");
                        withdraw_amt = Console.ReadLine();
                    }

                    // check if funds are sufficient
                    while (new_withdraw_amt > balance)
                    {
                        Console.WriteLine("Insuffient funds");
                        return balance;
                    }

                    bal = balance - new_withdraw_amt;
                    // output new balance
                    Console.WriteLine($"You have withdrawn £{new_withdraw_amt}");
                    Console.WriteLine($"New balance: £{bal}");
                    return bal;
            }
            return bal;
        }
    }
}