/* https://learn.microsoft.com/vi-vn/dotnet/csharp/language-reference/operators/patterns#logical-patterns
 * 
 */

public class PatternMatchingExample
{
    static string GetSourceLabel<T>(IEnumerable<T> source) => source switch
    {
        Array array => $"Length {array.Length}", // Declaration pattern: checks if source is Array AND declares 'array'
        ICollection<T> collection => $"Length {collection.Count}", // Declaration pattern: checks if source is ICollection<T> AND declares 'collection'
        _ => "3", // Discard pattern
    };

    static int GetSourceLabel_v1<T>(IEnumerable<T> source) => source switch
    {
        Array array => 1, // Declaration pattern
        ICollection<T> collection => 2, // Declaration pattern
        _ => 3, // Discard pattern
    };

    // If you want to check only the type of an expression, you can use a discard _ in place of a variable's name
    static int GetSourceLabel_v2<T>(IEnumerable<T> source) => source switch
    {
        Array _ => 1,
        ICollection<T> _ => 2,
        null => throw new ArgumentNullException(nameof(PatternMatchingExample)),
        _ => 3,
    };

    // This method is type pattern
    static int GetSourceLabel_v3<T>(IEnumerable<T> source) => source switch
    {
        Array => 1, // Type pattern: checks if source is an Array
        ICollection<T> => 2, // Type pattern: checks if source is an ICollection<T>
        null => throw new ArgumentNullException(nameof(PatternMatchingExample)),
        _ => 3,
    };

    // This method is constant pattern
    static decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
    {
        1 => 12.0m,
        2 => 20.0m,
        3 => 27.0m,
        4 => 32.0m,
        0 => 0.0m,
        _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
    };

    // This method is relational pattern which compare an expression result with a constant.
    // This method also include logical pattern which use the not, and, or.
    static string Classify(double measurement) => measurement switch
    {
        // relational operators <, >, <=, or >=.
        99 or 100 or 5 => "spring", // Disjunctive(Phân biệt) or, logical pattern
        >= 3 and < 6 => "spring", // Conjunctive(liên từ) and, logical pattern
        < -4.0 => "Too low", // relational pattern
        > 10.0 => "Too high", // relational pattern
        double.NaN => "Unknown",
        _ => "Acceptable",
    };

    // This method is positional pattern
    // Which deconstruct an expression result and match the resulting values against the corresponding nested patterns.
    public readonly struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) => (X, Y) = (x, y);
        public void Deconstruct(out int x) => x = X;
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
        public void Deconstruct(int x, int y) => (x, y) = (X, Y);
    }

    public record Segment(Point Start, Point End);

    static string Classify(Point point) => point switch
    {
        (0, 0) => "Origin",
        (1, 0) => "positive X basis end",
        (0, 1) => "positive Y basis end",
        _ => "Just a point",
    };

    // This method is property pattern which match an expression's properties or fields against nested patterns.
    static bool IsConferenceDay(DateTime date) => date is { Year: 2020, Month: 5, Day: 19 or 20 or 21 };

    // A property pattern is a recursive pattern. You can use any pattern as a nested pattern
    static bool IsAnyEndOnXAxis(Segment segment) => segment is { Start: { Y: 0 } } or { End: { Y: 0 } };


    // Parenthesized pattern
    private static void ParenthesizedPattern(object input)
    {
        if (input is not (float or double))
        {
            return;
        }
    }

    // List patterns
    private static void ListPattern()
    {
        int[] numbers = { 1, 2, 3 };
        if(numbers is [1, 2, 3])
        {

        }

        if(numbers is [0 or 1, <= 2, >= 3])
        {

        }
    }

    private static readonly int[] int32Array = [10, 20, 30];

    private static readonly List<char> charList = ['a', 'b', 'c', 'd'];

    public void Declaration_Type_Pattern()
    {
        object greeting = "Hello, World!";
        if (greeting is string message)
        {
            Console.WriteLine(message.ToLower());  // output: hello, world!
        }

        GetSourceLabel(int32Array);
        GetSourceLabel(charList);

        int? xNullable = 7;
        int y = 23;
        object yBoxed = y; // boxing
        if (xNullable is int a && yBoxed is int b)
        {
            // a new local variable named b of type int is declared and assigned the unboxed value of yBoxed, which is 23.
            Console.WriteLine(a + b);  // output: 30
        }
    }

    public void Main()
    {
        var point = new Point(10, 20);

        #region Deconstruct with tuples require at least 2 variables    
        // var (x) = point; -> wrong
        int fx;
        point.Deconstruct(out fx); // -> correct
        #endregion

        int fx1;
        int fy1;
        point.Deconstruct(out fx1, out fy1);
        var (fx11, fy11) = point;

        int fx2 = 0;
        int fy2 = 1;
        point.Deconstruct(fx2, fy2); // giá trị fx2 và fy2 không đổi.
    }
}