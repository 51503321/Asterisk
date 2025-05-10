namespace Asterisk.MyTek.HackerRank;

public class HackerRankTest1
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
    private const string empty_tag = "EMPTY";

    private static decimal GetDiscountNumber(decimal price, string type, string amount)
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

    public int FindLowestPrice(List<List<string>> products, List<List<string>> discounts)
    {
        int result = 0;

        foreach (var product in products)
        {
            var price = product[product_price_idx];
            if (!int.TryParse(price, out int priceNumber)) continue;

            var tags = product.Skip(product_skip_first_idx)
                .Where(p => !p.ToLowerInvariant().Equals(empty_tag.ToLowerInvariant()))
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

    public List<List<string>> GetProducts()
    {
        return [["100", "dcoupon1"], ["50", "dcoupon1"], ["30", "dcoupon1"], ["100", "dcoupon2"], ["50", "dcoupon2"], ["30", "dcoupon2"]];
        // return [["10", "d0", "d1"], ["15", "EMPTY", "EMPTY"], ["20", "d1", "EMPTY"]];
        // return [["10", "sale", "january-sale"], ["200", "sale", "EMPTY"]];
        // return [["100", "A"], ["200", "B"], ["150", "C"], ["250", "D"]];
    }

    public List<List<string>> GetDiscounts()
    {
        return [["dcoupon1", "0", "60"], ["dcoupon1", "1", "30"], ["dcoupon1", "1", "20"], ["dcoupon2", "2", "20"], ["dcoupon2", "1", "85"], ["dcoupon2", "0", "15"]];
        // return [["d0", "1", "27"], ["d1", "2", "5"]];
        // return [["sale", "0", "10"], ["january-sale", "1", "10"]];
        // return [["A", "0", "80"], ["B", "1", "20"], ["C", "0", "120"], ["D", "1", "15"]];
    }

    public int Main()
    {
        var products = GetProducts();
        var discounts = GetDiscounts();
        int result = FindLowestPrice(products, discounts);
        return result;
    }
}
