using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company_Info
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            byte managerAge = byte.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            if (faxNumber == "")
            {
                 faxNumber = "(no fax)";
            }

            Console.WriteLine(companyName + "\n" + "Address: {0}", companyAddress + "\n" + "Tel. " + phoneNumber + "\n" +  "Fax: " + faxNumber + "\n" + "Web site: " + website 
                + "\n" + "Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", " +  "tel. " + managerPhone + ")");
        }
    }
}
