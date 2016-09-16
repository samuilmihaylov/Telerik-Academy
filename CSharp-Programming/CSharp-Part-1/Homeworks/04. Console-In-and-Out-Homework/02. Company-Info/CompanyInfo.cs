namespace _02.Company_Info
{
    using System;

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

            if (string.IsNullOrEmpty(faxNumber))
            {
                 faxNumber = "(no fax)";
            }

            Console.WriteLine(companyName + "\n" + 
                            "Address: {0}", companyAddress + "\n" + 
                            "Tel. " + phoneNumber + "\n" +  
                            "Fax: " + faxNumber + "\n" + 
                            "Web site: " + website + "\n" + 
                            "Manager: " + managerFirstName + " " + managerLastName + 
                                " (age: " + managerAge + ", " +  
                                "tel. " + managerPhone + ")");
        }
    }
}
