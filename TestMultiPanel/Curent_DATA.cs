using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestMultiPanel
{
    public class Crypto_Price
    {
        public double BTC { get; set; }
        public double USD { get; set; }
        public double EUR { get; set; }
    }

    public class Curent_DATA
    {
        static HttpClient client = new HttpClient();
        static void ShowProduct(Crypto_Price product)
        {
            Console.WriteLine($"BTC: {product.BTC}\tUSD: " +
                $"{product.USD}\tEUR: {product.EUR}");
        }




        static async Task<Crypto_Price> GetProductAsync(string path)
        {
            Crypto_Price product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Crypto_Price>();
            }
            return product;
        }

        public static async Task<Crypto_Price> RunAsyncCurrent(String ASSET1)
        {
            Crypto_Price test = null;
            try
            {
                

                Uri baseUri = new Uri("https://min-api.cryptocompare.com");


                Uri LocalPath = new Uri(baseUri, "/data/price");

                Uri SubQueryTest = new Uri(LocalPath, ("?fsym=" + ASSET1 + "&tsyms=BTC,USD,EUR&api_key={7518522f704453f042b646acd7e367f8f060ad70b5d4f6fa924edfd684f7a4b6}"));

                // Get the product
                //"https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=BTC,USD,EUR&api_key={7518522f704453f042b646acd7e367f8f060ad70b5d4f6fa924edfd684f7a4b6}"
                Console.WriteLine(SubQueryTest.AbsoluteUri);
                test = await GetProductAsync(SubQueryTest.AbsoluteUri);
                //ShowProduct(test);
                return test;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Console.ReadLine();
            return test;
        }
    }
}
