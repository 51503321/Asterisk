/* Both covariance and contravariance in C# 4.0 refer to the ability of using a derived class instead of base class.
 * Covariance
 * Is aided(ho tro) by out keyword and it means that a generic type using a derived class of the out type parameter is OK.
 * 
 * Contravariance
 * Allows a generic type parameter to be assigned to a less general type(more specific type).
 * It's used when the generic type parameter is only used in input positions(as a method parameter, or a set property)
of an interface or a delegate, usually in delegates.
 * The principle is the same, it means that => the delegate can accept more derived class.
 */

public class Invariant_Contravariance_Covariant
{
    public delegate void Action<in T>(T arg);

    interface IInvariant<T> where T : class
    {
        T Get(); 
        void Set(T t);
    }

    interface ICovariant<out T> where T : class
    {
        T Get();
    }

    interface IContravariant<in T> where T : class
    {
        void Set(T t);
    }

    public record Animal;
    public record Mammal : Animal;
    public record Dog : Mammal;

    public void Main()
    {
        #region Invariance, same hierarchy level 

        /* Conslusion:
         *  By default, generic type parameters in C# are invariant.
         *  This means that if you have a generic type G<T>, then G<Derived> is not assignable to G<Base>, and G<Base> is not assignable to G<Derived>,
         even if Derived inherits from Base.
         * Depending on whether the generic type parameter is higher or lower in class hierarchy,the generic types themselves are incompatible
         for different reasons.
         */

        IInvariant<Animal> invariantAnimal1 = (IInvariant<Animal>)null;
        //IInvariant<Animal> invariantAnimal2 = (IInvariant<Mammal>)null;
        //IInvariant<Animal> invariantAnimal3 = (IInvariant<Dog>)null;

        //IInvariant<Mammal> invariantMammal1 = (IInvariant<Animal>)null;
        IInvariant<Mammal> invariantMammal2 = (IInvariant<Mammal>)null;
        //IInvariant<Mammal> invariantMammal3 = (IInvariant<Dog>)null;

        //IInvariant<Dog> invariantDog1 = (IInvariant<Animal>)null;
        //IInvariant<Dog> invariantDog2 = (IInvariant<Mammal>)null;
        IInvariant<Dog> invariantDog3 = (IInvariant<Dog>)null;

        #endregion

        #region Covariance (out), lower or equal hierarchy level 

        ICovariant<Animal> covariantAnimal1 = (ICovariant<Animal>)null; 
        ICovariant<Animal> covariantAnimal2 = (ICovariant<Mammal>)null;
        ICovariant<Animal> covariantAnimal3 = (ICovariant<Dog>)null; 

        //ICovariant<Mammal> covariantMammal1 = (ICovariant<Animal>)null;
        ICovariant<Mammal> covariantMammal2 = (ICovariant<Mammal>)null; 
        ICovariant<Mammal> covariantMammal3 = (ICovariant<Dog>)null; 

        //ICovariant<Dog> covariantDog1 = (ICovariant<Animal>)null;
        //ICovariant<Dog> covariantDog2 = (ICovariant<Mammal>)null;
        ICovariant<Dog> covariantDog3 = (ICovariant<Dog>)null;

        #endregion

        #region Contravariance (in), higher or equal hierarchy level 

        IContravariant<Animal> contravariantAnimal1 = (IContravariant<Animal>)null; 
        //IContravariant<Animal> contravariantAnimal2 = (IContravariant<Mammal>)null;
        //IContravariant<Animal> contravariantAnimal3 = (IContravariant<Dog>)null;

        IContravariant<Mammal> contravariantMammal1 = (IContravariant<Animal>)null; 
        IContravariant<Mammal> contravariantMammal2 = (IContravariant<Mammal>)null; 
        //IContravariant<Mammal> contravariantMammal3 = (IContravariant<Dog>)null;

        IContravariant<Dog> contravariantDog1 = (IContravariant<Animal>)null; 
        IContravariant<Dog> contravariantDog2 = (IContravariant<Mammal>)null;
        IContravariant<Dog> contravariantDog3 = (IContravariant<Dog>)null;

        /*
         * counterintuitive example, phản trực giác
         */

        Animal animal = (Dog)null; // Dog is animal
        //IContravariant<Animal> contravariantAnimal = (IContravariant<Dog>)null;

        //Dog dog = (Animal)null; not every Animal is a Dog
        IContravariant<Dog> contravariantDog = (IContravariant<Animal>)null;

        #endregion
    }
}