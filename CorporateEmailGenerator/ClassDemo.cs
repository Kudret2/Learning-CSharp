namespace CorporateEmailGenerator
{
    /// <summary>
    /// A class to test and display the Email Generator Class.
    /// </summary>
    internal class ClassDemo
    {
        static void Main(string[] args)
        {
            // Sample data: Multi-dimensional array with single row of pairs
            string[,] extraCrew =
            {
                {"Gökhan", "Gönül", "Caner", "Erkin", "Jose", "Sosa"}
            };

            // Sample data: Structured corporate list
            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            // Sample data: External contractors list
            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            // Executing the logic with various parameters
            string[] corporateEMails = Logic.UserNameCreator(array: corporate); // Uses default domain
            string[] externalEMails = Logic.UserNameCreator(array: external, domain: externalDomain); // Uses custom domain
            string[] extraCrewEMails = Logic.UserNameCreator(extraCrew);

            // Displaying the generated results to the console
            Console.WriteLine("--- Corporate Emails ---");
            foreach (string eMail in corporateEMails)
            {
                Console.WriteLine(eMail);
            }

            Console.WriteLine("\n--- External Emails ---");
            foreach (string eMail in externalEMails)
            {
                Console.WriteLine(eMail);
            }

            Console.WriteLine("\n--- Extra Crew Emails ---");
            foreach (string eMail in extraCrewEMails)
            {
                Console.WriteLine(eMail);
            }
        }
    }
}