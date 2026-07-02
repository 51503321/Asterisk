using Asterisk.MyTek.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

namespace Asterisk.MyTek.Controllers;

public class FlashController(IConnectionMultiplexer redis, MyDbContext dbContext) : ControllerBase
{
    private readonly IDatabase _redisDb = redis.GetDatabase();
    private const string StockKey = "product:flash-sale:stock";
    private MyDbContext _dbContext = dbContext;


    // Adding a CancellationToken

    [HttpPost("init")]
    public async Task<IActionResult> InitializeStock([FromQuery] int amount = 50)
    {
        await _redisDb.StringSetAsync(StockKey, amount);

        // 2. Reset the real SQL Database stock so they match perfectly
        var product = await _dbContext.Challenges.FirstOrDefaultAsync();
        if (product != null)
        {
            product.Stock = amount;
            await _dbContext.SaveChangesAsync();
        }
        else
        {
            // Optional: If the test product doesn't exist yet, create it automatically
            _dbContext.Products.Add(new Product { Id = productId, Name = "Test Product", Stock = amount });
            await _dbContext.SaveChangesAsync();
        }

        return Ok($"Stock initialized to {amount} in both Redis and SQL Database.");
    }
}



//[HttpPost("init")]
//    public async Task<IActionResult> InitializeStock([FromQuery] int amount = 50)
//    {
//        await _redisDb.StringSetAsync(StockKey, amount);
//        return Ok($"Stock initialized to {amount}");
//    }

//    [HttpPost("buy")]
//    public async Task<IActionResult> BuyItem()
//    {
//        // Atomically subtract 1 from the stock counter in Redis memory
//        long remainingStock = await _redisDb.StringDecrementAsync(StockKey);

//        // If the result goes below 0, it means it was already 0 before this request
//        if (remainingStock < 0)
//        {
//            return BadRequest(new { success = false, message = "Sold out!" });
//        }

//        // Only requests that successfully kept stock >= 0 make it here
//        return Ok(new { success = true, message = "Ticket secured!", ticketNumber = remainingStock + 1 });
//    }

//    [HttpPost("buy-without-redis")]
//    public async Task<IActionResult> BuyItem(int productId)
//    {
//        // 1. Read the product from the database
//        var product = await _dbContext.Products.FindAsync(productId);

//        // 2. Check if there is stock available
//        if (product == null || product.Stock <= 0)
//        {
//            return BadRequest(new { success = false, message = "Sold out!" });
//        }

//        // 3. Deduct the stock
//        product.Stock -= 1;

//        // 4. Save changes back to the database
//        await _dbContext.SaveChangesAsync();

//        return Ok(new { success = true, message = "Ticket secured!" });
//    }

//    [HttpPost("buy-optimistic")]
//    public async Task<IActionResult> BuyItemOptimistic(int productId)
//    {
//        while (true) // Loop to retry if a concurrency conflict happens
//        {
//            try
//            {
//                var product = await _dbContext.Products.FindAsync(productId);

//                if (product == null || product.Stock <= 0)
//                {
//                    return BadRequest(new { success = false, message = "Sold out!" });
//                }

//                product.Stock -= 1;

//                // EF Core generates: UPDATE Products SET Stock = @p1 WHERE Id = @p2 AND RowVersion = @p3
//                await _dbContext.SaveChangesAsync();

//                return Ok(new { success = true, message = "Ticket secured!" });
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                // 🔄 Concurrency conflict! Another user saved changes first.
//                // Loop runs again: re-reads the fresh stock, checks if > 0, and tries to save again.
//            }
//        }
//    }

//    [HttpPost("buy-pessimistic")]
//    public async Task<IActionResult> BuyItemPessimistic(int productId)
//    {
//        // Start an explicit transaction
//        using var transaction = await _dbContext.Database.BeginTransactionAsync();

//        try
//        {
//            // 💡 Use raw SQL or EF LINQ tracking to execute a SELECT with an exclusive row lock (XLOCK)
//            // This forces other requests for this product ID to wait until this request finishes.
//            var product = await _dbContext.Products
//                .FromSqlRaw("SELECT * FROM Products WITH (UPDLOCK, ROWLOCK) WHERE Id = {0}", productId)
//                .SingleOrDefaultAsync();

//            if (product == null || product.Stock <= 0)
//            {
//                await transaction.RollbackAsync();
//                return BadRequest(new { success = false, message = "Sold out!" });
//            }

//            product.Stock -= 1;
//            await _dbContext.SaveChangesAsync();

//            await transaction.CommitAsync(); // Releases the row lock safely

//            return Ok(new { success = true, message = "Ticket secured!" });
//        }
//        catch (Exception)
//        {
//            await transaction.RollbackAsync();
//            throw;
//        }
//    }
