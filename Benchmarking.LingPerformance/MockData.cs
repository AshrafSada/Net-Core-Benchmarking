using Bogus;

namespace Benchmarking.LingPerformance
{
    public class MockData
    {
        private readonly Faker<Product> faker = new();
        private readonly List<Product> products;

        public MockData()
        {
            this.products = this.faker
                .RuleFor(p => p.Id, f => f.UniqueIndex)
                .RuleFor(p => p.Name, f => f.Finance.AccountName())
                .RuleFor(p => p.Price, f => f.Finance.Amount())
                .RuleFor(p => p.Active, f => f.Random.Bool())
                .Generate(60000);
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