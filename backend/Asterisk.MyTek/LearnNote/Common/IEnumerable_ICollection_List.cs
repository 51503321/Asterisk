/*
 * IEnumerable<> for a list of objects that only needs to be iterated through.
    * contains only GetEnumerator method to get Enumerator and allows looping.
     
 * ICollection<> for a list of objects that needs to be iterated through and modified.
    * ICollection is inherited from IEnumerable.
    * ICollection contains additional methods: Add, Remove, Contains, Count, CopyTo.

 * IList<T> inherits from ICollection<T> and IEnumerable<T>.

 * List<> for a list of objects that needs to be iterated through, modified, sorted.
    * is a concrete class that implements IList<T>.
    * It represents a dynamically sized, ordered collection of objects that can be accessed by index, vd: list[0]
 *
/*/

/*
 * Upcasting: You have a specific type (like a Dog) and you treat it as its more general type (like an Animal).
This is usually safe and often implicit. Every Dog is an Animal.
 * Downcasting: You have a general type (like an Animal) and you try to treat it as its more specific type (like a Dog).
This is not always safe because not every Animal is a Dog -> "use it when You know the actual runtime type of the object".
 */

namespace Asterisk.MyTek.LearnNote.Common
{
    public class ListExample
    {
        public static void ProcessAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        public static IEnumerable<Dog> GetDogs()
        {
            return [new Dog { Name = "Lucy" }, new Dog { Name = "Charlie" }];
        }

        public static void TheMoreYouKnow()
        {
            // Why List<T> is NOT Covariant in T:
            // List<Dog> dogList = new List<Dog>();
            // List<Animal> animalList = dogList; // Hypothetically allowed if List<T> were covariant
            // animalList.Add(new Cat()); // Oops! We added a Cat to a list that was originally meant for Dogs!
            // Dog myDog = dogList[0]; // This would now potentially throw an exception at runtime!
        }

        public static void MainA()
        {
            List<Dog> dogList = [new Dog { Name = "Buddy" }, new Dog { Name = "Max" }];
            ProcessAnimals(dogList);
            // We are passing a List<Dog>. 
            // Because List<T> implements IEnumerable<T>, and IEnumerable<out T> is covariant in T,
            // the List<Dog> is implicitly upcast to IEnumerable<Animal>.
            // The method can safely iterate through the list, treating each Dog as an Animal.

            IEnumerable<Animal> animalEnumerable = GetDogs(); // Implicitly upcast due to covariance
            ProcessAnimals(animalEnumerable);
            // We are assigning this result to a variable of type IEnumerable<Animal>.
            // This is allowed because of the out keyword in the definition of IEnumerable<T>.
            // We can treat the sequence of dogs as a sequence of animals.

            Animal myAnimal = new Dog(); // Upcasting is implicit
            // Downcasting - requires explicit cast
            Dog myDog = (Dog)myAnimal;
        }

        // If IEnumerable<T> were defined without out,
        // the C# compiler would treat IEnumerable<Dog> and IEnumerable<Animal> as completely unrelated types. 
    }

    public class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}