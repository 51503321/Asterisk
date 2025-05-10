/* https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing?redirectedfrom=MSDN
 * Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type.
 */

namespace Asterisk.MyTek.LearnNote.Common;

public class Boxing_Unboxing
{
    public const int ooo = 9;

    public static void StaticMethod() // get this as an example in static
    {

    }

    public void Main()
    {
        int i = 123;
        // Boxing copies the value of i into object o.
        // creating an object reference o, on the stack, that references a value of the type int, on the heap.
        object o = i; // boxing or object o = (object)i; explicit(rõ ràng) boxing
        i = 456;
        // because o is get ref from the heap, which is a different value, so value o doesn't change.

        // unboxing
        int j = (int)o;
    }
}
