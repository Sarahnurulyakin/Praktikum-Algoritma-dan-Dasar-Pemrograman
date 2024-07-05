using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StudentDataApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter the program study (prodi) code: ");
            string prodiCode = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(prodiCode))
            {
                Console.WriteLine("Prodi code cannot be empty.");
                return;
            }

            try
            {
                string response = await GetStudentDataAsync(prodiCode);
                Console.WriteLine("Raw response from server: " + response);
                StudentData[] students = JsonConvert.DeserializeObject<StudentData[]>(response);

                Console.WriteLine("Student Data:");
                foreach (StudentData student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, NIM: {student.NIM}, IPK: {student.IPK}");
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine("Network error: " + httpEx.Message);
                if (httpEx.InnerException != null)
                {
                    Console.WriteLine("Inner exception: " + httpEx.InnerException.Message);
                }
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine("Error parsing JSON: " + jsonEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static async Task<string> GetStudentDataAsync(string prodiCode)
        {
            using (HttpClientHandler handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            })
            using (HttpClient client = new HttpClient(handler))
            {
                string url = $"https://riset-akademik.site/WISUDA/prodi?kode={prodiCode}&wskey=4LL4h";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }
    }

    public class StudentData
    {
        public string Name { get; set; }
        public string NIM { get; set; }
        public double IPK { get; set; }
    }
}
