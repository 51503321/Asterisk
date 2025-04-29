using Asterisk.MyTek.Entity;
using Microsoft.AspNetCore.Mvc;

namespace LearnNote.Common
{
    public class Common_P1
    {
        [HttpGet("{id}")]
        public async Task<int> GetById(int id, bool dogsOnly)
        {
            await Task.CompletedTask; // không có này thì 100% chạy sync, DummyTask
            return await Task.FromResult<int>(4); // another DummyTask
        }

        static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            return ("", 0, 0, 0, 0, 0); // returns a tuple
        }

        public void Main()
        {
            var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);
            var p = new Person();
            var (fname, _, city, _) = p;
            p.FirstName = "cu";
        }
    }
}
