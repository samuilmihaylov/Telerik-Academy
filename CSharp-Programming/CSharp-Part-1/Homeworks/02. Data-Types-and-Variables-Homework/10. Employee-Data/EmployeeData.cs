namespace _10.Employee_Data
{
    using System;

    public class EmployeeData
    {
        public static void Main(string[] args)
        {
            Random randomNumber = new Random();

            string firstName = "Samuil";
            string lastName = "Mihaylov";
            int age = 22;
            char gender = 'M';
            long personalIdNumber = 8306112507;
            long uniqueEmployeeNumber = randomNumber.Next(27560000, 27569999);

            Console.WriteLine("- First name: " + firstName + "\n" 
                            + "- Last name: " + lastName + "\n" 
                            + "- Age: " + age + "\n" 
                            + "- Gender: " + gender + "\n"
                            + "- Personal ID number: " + personalIdNumber + "\n"
                            + "- Unique employee number: " + uniqueEmployeeNumber);
        }
    }
}
