using Less16_Controllers.Models.Domain;
using System.Text.Json;

namespace Less16_Controllers.Models
{
    public class Inventory
    {
        public List<Products> prods = new List<Products>();
        public Inventory(string json)
        {
            string jsonString = File.ReadAllText(json);
            prods = JsonSerializer.Deserialize<List<Products>>(jsonString);
        }
    }
}
