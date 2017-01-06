using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhoneNumber = Console.ReadLine();
            string companyFaxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhoneNumber = Console.ReadLine();
            if (companyFaxNumber == string.Empty)
            {
                companyFaxNumber = "(no fax)";
            }
            Console.WriteLine(@"{0}
Address: {1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager: {5} {8} (age: {6}, tel. {7})", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, webSite, managerFirstName, managerAge, managerPhoneNumber, managerLastName);
        }
    }
}
