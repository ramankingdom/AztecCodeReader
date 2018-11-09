using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AzTecReader.WebApiClient
{
    public class Proxy
    {
        public static async Task<string> SendScannedCode(string request)
        {
            string result = string.Empty;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.PostAsync(request, null);
                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsStringAsync();

                    }
                    else
                    {
                        result = response.ReasonPhrase;
                    }
                }
            }
            catch (Exception ex)
            {

                result = ex.InnerException.ToString();
            }

            return result;
        }
    }
}
