
using Decorator.Decorators;
using Decorator.Interfaces;
using DesignPatterns.Decorator;

namespace DesingPatterns.Decorator;

/*
 *  Summary:
 *      The decorator pattern is a design strategy that allows adding behavior 
 *      to an object dynamically without affecting other objects of the same
 *      class.
 *      
 *  Problem:
 *      The decorator pattern solves the problem of extending an object’s 
 *      functionality dynamically without using inheritance.
 *      At design time or runtime, add behavior to a class without affecting
 *      behavior of other objects from the same class. Supports Single 
 *      Responsibility Principle as functionality is divided between classes 
 *      with unique areas of concern.
 *      
 *  Solution:
 *      The decorator pattern provides more flexibility than static inheritance, 
 *      as it can operate on any implementation of a given interface without 
 *      creating subclasses. The decorator pattern also leads to cleaner and 
 *      testable code, as it avoids creating many classes for different 
 *      combinations of behaviors.
 *      “Wrapper” is the alternative nickname for the Decorator pattern that 
 *      clearly expresses the main idea of the pattern. Make the wrapper’s 
 *      reference field accept any object that follows that interface. 
 *      This will let you cover an object in multiple wrappers, adding the
 *      combined behavior of all the wrappers to it.
 *      The decorator pattern works well in scenarios where there are many
 *      optional features or behaviors that an object may have, and you want to
 *      combine them dynamically at run-time. For example, you can use the 
 *      decorator pattern to add logging, caching, encryption or compression to
 *      any object that implements a certain interface.
 *      
 *  Add the following classes:    
 *      1. Base interface, IPizza
 *      2. Contrete class, Pizza
 *      3. Base decorator class, PizzaDecorator
 *      4. Derived decorator classes, CheeseDecorator, 
 *         MushroomDecorator, and OnionDecorator
 */

public static class Program
{
    public static void Main(string[] args)
    {
        IPizza basePizza = new Pizza();

        IPizza cheeseDecorator = new CheeseDecorator(basePizza);
        IPizza mushroomDecorator = new MushroomDecorator(cheeseDecorator);
        IPizza onionDecorator = new OnionDecorator(mushroomDecorator);
       
        // Now tha the pizza is decorated, print out the pizza type.
        Console.WriteLine(onionDecorator.GetPizzaType());
    }
}

