using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;

namespace OCP
{

    // This code requires the Nuget package Microsoft.AspNet.WebApi.Client to be installed.
// Instructions for doing this in Visual Studio:
// Tools -> Nuget Package Manager -> Package Manager Console
// Install-Package Microsoft.AspNet.WebApi.Client



        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }

        class Items
        {
      //      static void Main(string[] args)
       //     {
      //          InvokeRequestResponseService().Wait();
       //     }

        // static async Task InvokeRequestResponseService()
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            var scoreRequest = new
        //            {

        //                Inputs = new Dictionary<string, StringTable>() {
        //                {
        //                    "input1",
        //                    new StringTable()
        //                    {
        //                        ColumnNames = new string[] {"EquipmentID", "GroupID", "Sequence", "Cycle", "TTL", "Vibration  A P6", "Vibration  A P7", "Vibration  A P4", "Vibration  A P5", "Vibration  A P2", "Vibration  A P3", "Vibration  A P1", "Vibration  H P6", "Vibration  A P8", "Vibration  A P9", "Vibration  H P9", "Vibration  H P8", "Vibration  H P1", "Vibration  H P3", "Vibration  H P2", "Vibration  H P5", "Vibration  H P4", "Vibration  H P7", "Vibration  V P10", "Température P10", "Température P8", "Température P9", "Température P6", "Température P7", "Température P4", "Température P5", "Température P2", "Température P3", "Température P1", "Vibration  V P9", "Vibration  V P8", "Vibration  V P3", "Vibration  V P2", "Vibration  V P1", "Vibration  V P7", "Vibration  V P6", "Vibration  V P5", "Vibration  V P4", "Vibration P2", "Vibration P3", "Vibration P1", "Vibration  A P10", "Vibration  H P10"},
        //                        Values = new string[,] {  { "value", "value", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },  { "value", "value", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },  }
        //                    }
        //                },
        //            },
        //                GlobalParameters = new Dictionary<string, string>()
        //                {
        //                }
        //            };
        //            const string apiKey = "fT2LYRcF3PfngInfR/ornGuWOVt3JLI4RUB7FV/q4NlE3JuLoW9ktbNtthICT3yVUWOzmRCFjAE13qPz0memOw=="; // Replace this with the API key for the web service
        //            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

        //            client.BaseAddress = new Uri("https://europewest.services.azureml.net/workspaces/dc713004d5f14fd7a71f235c469976df/services/b29354ade2b44725beae07be4554e1b0/execute?api-version=2.0&details=true");

        //            // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
        //            // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
        //            // For instance, replace code such as:
        //            //      result = await DoSomeTask()
        //            // with the following:
        //            //      result = await DoSomeTask().ConfigureAwait(false)


        //            HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string result = await response.Content.ReadAsStringAsync();
        //            MessageDialog Results = new MessageDialog("Result: {0}", result);
        //            //Console.WriteLine("Result: {0}", result);
        //        }

        //        else
        //        {
        //            MessageDialog Results = new MessageDialog(string.Format("The request failed with status code: {0}", response.StatusCode));
        //            /// Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

        //            // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
        //            //   Console.WriteLine(response.Headers.ToString());

        //            string responseContent = await response.Content.ReadAsStringAsync();
        //            //     Console.WriteLine(responseContent);
        //        }
        //        }
        //    }
        }
    }



