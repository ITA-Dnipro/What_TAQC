using Newtonsoft.Json;

namespace What_Common.Utils
{
    public class JsonHelper
    {
        public static void CreateJson<T>(List<T> list, string path, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            using (StreamWriter sw = new StreamWriter(path + fileName + ".json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, list);
            }
        }
        public static IEnumerable<T> ReadJson<T>(string path)
        {
            IEnumerable<T> data = JsonConvert.DeserializeObject<T[]>(File.ReadAllText(path));
            return data;
        }
    }
}
