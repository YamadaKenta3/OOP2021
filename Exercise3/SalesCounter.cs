using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{//売上集計クラス
    class SalesCounter
    {
        private IEnumerable<Sale> _sales;
        //コンストラクタ
        public SalesCounter(string filepath)
        {
            _sales = ReadSales(filepath);
        }


        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);

            }
            return sales;
        }

        public IDictionary<string, int> GetPerCategorySales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCategory))
                    //すでにコレクションに店舗が登録されている
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        
        
        
        
        


        
        }
        
    }

    
}
