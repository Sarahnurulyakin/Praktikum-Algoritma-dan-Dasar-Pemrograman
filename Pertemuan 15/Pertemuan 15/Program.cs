using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace WebServiceExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://riset-akademik.site/WISUDA/prodi?kode=705&wskey=4LL4h"; using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); string responseData = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseData);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}