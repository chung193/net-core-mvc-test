using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using testMVC.Models;

namespace testMVC.Common
{
    public class XuLyDuLieu
    {
        public static string filePath = @"D:\Task\Resources\Slide 1\1\data.json";
        public static List<Item> items = new List<Item>();
        public static List<Item> loadJson()
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
            return items;
        }
    }
}
