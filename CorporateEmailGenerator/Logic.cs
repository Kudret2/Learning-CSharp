using System;

namespace CorporateEmailGenerator
{
    /// <summary>
    /// Contains the core business logic for generating corporate identity data.
    /// </summary>
    public static class Logic
    {
        /// <summary>
        /// Generates a list of corporate emails using names from a 2D array.
        /// </summary>
        /// <param name="array">A 2D array where each row contains [First Name, Last Name].</param>
        /// <param name="domain">The email domain to be appended.</param>
        /// <returns>An array of formatted email strings.</returns>
        public static string[] UserNameCreator(string[,] array, string domain = "contoso.com")
        {
            // Validation: Check if the array structure is suitable for [First Name, Last Name] pairs
            string[] invalid = ["Missing first or last name."];
            if (array.GetLength(1) % 2 != 0)
            {
                return invalid;
            }

            // Initialization of temporary arrays to store processed names
            int totalNames = (array.GetLength(0) * array.GetLength(1)) / 2;
            string[] userNames = new string[totalNames];
            string[] firstNames = new string[totalNames];
            string[] lastNames = new string[totalNames];

            int counter = 0;

            // Step 1: Extract first and last names from the 2D input array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j += 2)
                {
                    firstNames[counter] = array[i, j];
                    lastNames[counter] = array[i, j + 1];
                    counter++;
                }
            }

            // Step 2: Combine names into the corporate format (e.g., "jodoe")
            for (int i = 0; i < userNames.Length; i++)
            {
                // Format: First 2 letters of First Name + Full Last Name
                userNames[i] = (firstNames[i].Substring(0, 2) + lastNames[i]).ToLower();
            }

            // Step 3: Append the domain to each username
            for (int i = 0; i < userNames.Length; i++)
            {
                userNames[i] += $"@{domain}";
            }

            return userNames;
        }
    }
}