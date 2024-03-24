using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryPet.Data
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal GetPriceCoin(string nameCoin)
        {
            using (ConnectDb db = new ConnectDb())
            {
                Coin coin = db.Coins.FirstOrDefault(x => x.Name == nameCoin);
                if (coin != null)
                {
                    return coin.Price;
                }
                return 0;
            }
        }
    }
}
