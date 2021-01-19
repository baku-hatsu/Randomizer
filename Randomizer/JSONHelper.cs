using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Randomizer
{
    public static class JSONHelper<T> where T : class
    {
        public static async Task Save(T model, string path)
        {
            using FileStream createStream = File.Create(path);
            await JsonSerializer.SerializeAsync(createStream, model);
        }

        public static async Task<T> Load(string path)
        {
            using FileStream openStream = File.OpenRead(path);
            return await JsonSerializer.DeserializeAsync<T>(openStream);
        }
    }
}
