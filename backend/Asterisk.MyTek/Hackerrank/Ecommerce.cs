namespace Asterisk.MyTek.HackerRank;

public class Ecommerce
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

    public static decimal GetPriceAfterDiscount(decimal price, string type, string amount)
    {
        if (Enum.TryParse(type, out Type discountType) && int.TryParse(amount, out int amountNumber))
        {
            return discountType switch
            {
                Type.None => amountNumber,
                Type.Percentage => price * (1 - (amountNumber / 100m)),
                Type.Fixed => price - amountNumber,
                _ => 0
            };
        }

        return 0;
    }

    public static int FindLowestPrice(List<List<string>> products, List<List<string>> discounts)
    {
        int sum = 0;

        foreach (var product in products)
        {
            if (int.TryParse(product[product_price_idx], out int price))
            {
                var productTags = product
                    .Skip(product_skip_first_idx)
                    .ToArray();
                var currentDiscounts = discounts
                    .Where(discount => productTags.Contains(discount[discount_tag_idx]))
                    .ToArray();
                
                var lowestPrices = new HashSet<int>();

                if (currentDiscounts.Length == 0) lowestPrices.Add(price);

                foreach (var discount in currentDiscounts)
                {
                    var priceAfterDiscount = GetPriceAfterDiscount(price, discount[discount_type_idx], discount[discount_amount_idx]);
                    var roundPrice = (int)Math.Round(priceAfterDiscount, 2, MidpointRounding.ToZero);
                    lowestPrices.Add(roundPrice);
                }

                sum += lowestPrices.Min();
            }
        }

        return sum;
    }
}
