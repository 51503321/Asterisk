/* https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-9.0#collections
 * https://stackoverflow.com/questions/54336578/cant-decide-between-taskiactionresult-iactionresult-and-actionresultthing
 * 
 * Discards are useful in working with tuples when your application code uses some tuple elements but ignores others.
 * 
 * ForEach() is a method and not a regular foreach loop. 
 * As it is a normal method call, action doesn't know anything about the enclosing(bao quanh) foreach, thus you can't break.
/*/

public static class Common_P1
{
    public static void ForEach<T>(this IEnumerable<T> input, Action<T> action)
    {
        foreach (var i in input)
            action(i);
    }

    /* i++ and ++i
     * 
     */

}