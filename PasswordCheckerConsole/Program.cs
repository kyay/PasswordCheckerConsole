using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheckerConsole
{
    class Program
    {
        //The maximum number of attempts allowed
        private const int MAX_INCORRECT_PASSWORDS = 3;
        //The user password
        private const string USER_PASSWORD = "correcthorsebatterystaple";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user");
            int intAttemptsCount = 0;
            string strUserInput = "";
            bool blnPasswordCorrect = false;

            do
            {
                Console.WriteLine("Please enter your password:");
                strUserInput = Console.ReadLine();
                intAttemptsCount++;
                blnPasswordCorrect = strUserInput.Equals(USER_PASSWORD);

            } while (intAttemptsCount < MAX_INCORRECT_PASSWORDS && !blnPasswordCorrect);

            if (intAttemptsCount == MAX_INCORRECT_PASSWORDS)
            {
                Console.WriteLine("You have tried too many incorrect passwords. Please contact an administrator");
            }
            else
            {
                Console.WriteLine("Correct password. Welcome");
            }
            Console.ReadKey();
        }
    }
}
