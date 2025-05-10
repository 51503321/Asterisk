using Asterisk.MyTek.HackerRank;

namespace Asterisk.MyTek;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        WebApplication app = builder.Build();
        app.MapGet("/", () =>
        {
            Solution.MainSolution();
        });
        app.Run();
    }
}