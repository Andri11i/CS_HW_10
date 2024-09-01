using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_10
{
    public class SecondTask
    {
        static public async Task DownloadDataAsync(string url, string path)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string content = await client.GetStringAsync(url);
                    await File.WriteAllTextAsync(path, content);
                    Console.WriteLine("Download successful");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
