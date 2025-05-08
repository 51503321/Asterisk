public class SwitchExample
{
    public readonly struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) => (X, Y) = (x, y);
    }

    /*
     * A case guard is another condition that must be satisfied together with a matched pattern.
     */
    static Point Transform(Point point) => point switch
    {
        { X: 0, Y: 0 } => new Point(0, 0),
        { X: var x, Y: var y } when x < y => new Point(x + y, y),
        { X: var x, Y: var y } when x > y => new Point(x - y, y),
        { X: var x, Y: var y } => new Point(2 * x, 2 * y),
    };

    public void Main()
    {
        
    }
}
