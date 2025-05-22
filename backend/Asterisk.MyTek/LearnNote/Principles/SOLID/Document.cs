/* Class Design principles
 * SOLID
 * 
 * Single Responsibility Principle (SRP)
 * Definition: A class should have one, and only one, reason to change, otherwise it should be split into multiple classes.

 * Open/Closed Principle (OCP)
 * Definition: A class should be open for extension but closed for modification.
example: use interfaces or abstract classes to allow new functionality.

 * Liskov Substitution Principle (LSP)
 * Definition: all derived classes must be substitutable for their base class.
example: if a class is derived from another class, it should be able to be used in place of the base class without any issues.

 * Interface Segregation Principle (ISP)
 * Definition: a class should not be forced to implement interfaces it does not use.
example: if a class implements an interface, it should only implement the methods that are relevant to it.

 * Dependency Inversion Principle (DIP)
 * High-level modules(core business logic), low-level modules(implementation details, ex: class access database, ...).
 * Definition:
 * 1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
example: use interfaces or abstract classes to decouple high-level and low-level modules.
 * 2. Abstractions should not depend on details. Details should depend on abstractions.
Your interface or abstract class (the abstraction) should be defined purely in terms of the high-level contract or behavior,
without any knowledge of the specific concrete classes that will implement it.
example: 
 */

/* This method is too specific */
public interface I_Wrong_Noti_Service
{
    void SendEmailNotification(string recipient, string subject, string body);
}

/* This can be send by an SMTP(email) or SMS */
public interface I_Correct_Noti_Service
{
    void Send(string recipient, string message);
}