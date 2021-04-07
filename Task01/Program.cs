using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace FindEmailAddresses
{
    public class Program
    {
        public static async System.Threading.Tasks.Task Main(string[] args)
        {
            string url = args[0];

            if (url.Length == 0)
            {
                throw new ArgumentException("You have to provide url as an argument!");
            }

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();

                if (message != null)
                {
                    Regex regex = new Regex(@"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                            + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                            + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                            + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})", RegexOptions.IgnoreCase);
                    
                    //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    Match match = regex.Match(message);

                    while (match.Success)
                    {
                        Console.WriteLine(match.Value);
                        match = match.NextMatch();
                    }
                }
            }

        }
    }
}
