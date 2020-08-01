using System;
using System.IO;

namespace Validator
{
    class Program
    {
        private static bool PinCode()
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Please enter in a pin code.");
            var pinCode = Console.ReadLine();

            foreach (var L in letters)
            {
                if (pinCode.Contains(L))
                {
                    Console.WriteLine("Pin cannot contain letters.");
                    return false;
                }
            }

            if (pinCode.Length > 8)
            {
                Console.WriteLine("Pin code too long.");
                return false;
            }

            if (pinCode.Length < 4)
            {
                Console.WriteLine("Pin code too short.");
                return false;
            }

            if (pinCode.Length >= 4 && pinCode.Length <= 8)
            {
                Console.WriteLine("Pin is valid.");
                return true;
            }
            return false;
        }
        private static bool PhoneNumberValidation()
        {
            Console.WriteLine("Enter in a phone number");
            var phoneNumber = Console.ReadLine();
            char[] newNumber = phoneNumber.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToCharArray();
            
            if (newNumber.Length == 10)
            {
                char[] firstNums = new char[3];
                for (int i = 0; i < 3; i++)
                {
                    firstNums[i] = newNumber[i];
                }
                if (firstNums[0] == '5' && firstNums[1] == '5' && firstNums[2] == '5')
                {
                    Console.WriteLine("Invalid phone number.");
                    return false;
                }
            }

            Console.WriteLine("Phone number is valid.");
            return true;
        }


        static void Main()
        {
            string end;
            do
            {
                Console.WriteLine("Type in the program you want to try out.");
                Console.WriteLine("Programs: Pincode, Phone number");
                var programToRun = Console.ReadLine();
                programToRun = programToRun.Trim().ToLower();

                if (programToRun == "pincode")
                {
                    Console.WriteLine(PinCode());
                } else if (programToRun == "phone number")
                {
                    Console.WriteLine(PhoneNumberValidation());
                } 
                Console.WriteLine("Want to exit program? Type in quit to leave program.");
                end = Console.ReadLine();

            } while (end != "quit");
        }
    }
}
