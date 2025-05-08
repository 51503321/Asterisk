namespace Asterisk.MyTek.HackerRank;

public class Solution
{
    public enum Type
    {
        None,
        Percentage,
        Fixed
    }

    private const int product_skip_first_idx = 1;
    private const int product_price_idx = 0;
    private const int discount_tag_idx = 0;
    private const int discount_type_idx = 1;
    private const int discount_amount_idx = 2;
    private const string empty_tag_value = "EMPTY";

    public static decimal GetDiscountNumber(decimal price, string type, string amount)
    {
        if (Enum.TryParse(type, out Type discountType) && int.TryParse(amount, out int amountNumber))
        {
            return discountType switch
            {
                Type.Percentage => price * (1 - (amountNumber / 100m)),
                Type.Fixed => price - amountNumber,
                _ => amountNumber
            };
        }

        return 0;
    }

    public static int FindLowestPrice(List<List<string>> products, List<List<string>> discounts)
    {
        int result = 0;

        foreach (var product in products)
        {
            var price = product[product_price_idx];
            if (!int.TryParse(price, out int priceNumber)) continue;

            var tags = product.Skip(product_skip_first_idx)
                .Where(p => !p.ToLowerInvariant().Equals(empty_tag_value.ToLowerInvariant()))
                .ToArray();

            if (tags.Length == 0)
            {
                result += priceNumber;
                continue;
            }

            var lowestPrices = new HashSet<int>();

            discounts.ForEach(discount =>
            {
                var tag = discount[discount_tag_idx];
                if (tags.Contains(tag))
                {
                    var type = discount[discount_type_idx];
                    var amount = discount[discount_amount_idx];
                    var priceAfterDiscount = GetDiscountNumber(priceNumber, type, amount);
                    var roundPrice = (int)Math.Round(priceAfterDiscount, 2, MidpointRounding.ToZero);
                    lowestPrices.Add(roundPrice);
                }
            });

            result += lowestPrices.Min();
        }

        return result;
    }

    public static void MainSolution()
    {
        var enviroment = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        TextWriter textWriter = new StreamWriter(enviroment, true);

        using (StreamReader sr = new StreamReader(enviroment))
        {
            while (sr.Peek() >= 0)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }

        int productsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int productsColumns = Convert.ToInt32(Console.ReadLine().Trim());
        List<List<string>> products = new List<List<string>>();
        for(int i = 0; i < productsRows; i++)
        {
            products.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        int discountRows = Convert.ToInt32(Console.ReadLine().Trim());
        int discountColumns = Convert.ToInt32(Console.ReadLine().Trim());
        List<List<string>> discounts = new List<List<string>>();
        for (int i = 0; i < discountRows; i++)
        {
            discounts.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        int result = FindLowestPrice(products, discounts);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
