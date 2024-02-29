using DynaFill.Filler;

namespace Benchmarking.LingPerformance
{
    public class MockData
    {
        private readonly List<Product> products;

        public MockData()
        {
            // benchmark 60 000 products
            int prodCount = 60000;
            var filler = new GenericFiller<Product>();
            for (int i = 0; i < prodCount; i++)
            {
                var p = new Product();
                filler.Fill(p);
            }
        }

        public List<String> GetProductNamesLinqToActive() =>
            products.Where(e => e.Active == true).Select(e => e.Name).ToList();

        public List<string> GetProductNamesForEachActive()
        {
            var names = new List<String>();
            foreach (var product in this.products)
            {
                names.Add(product.Name);
            }

            return names;
        }

        public List<string> GetProductNamesForActive()
        {
            var names = new List<string>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Active == true)
                {
                    names.Add(products[i].Name);
                }
            }

            return names;
        }

        public int GetProductsWhereActive() =>
            this.products.Where(e => e.Active == true).Count();

        public int GetProductsCountActive() =>
            this.products.Count(e => e.Active == true);

        public int GetProductsCountForActive()
        {
            int count = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Active == true)
                {
                    count++;
                }
            }

            return count;
        }

        public int GetProductsCountForEachActive()
        {
            int count = 0;
            foreach (var product in products)
            {
                if (product.Active == true)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
