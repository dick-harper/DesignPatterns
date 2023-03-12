
using Decorator.Decorators;
using Decorator.Interfaces;
using DesignPatterns.Decorator;

namespace DesingPatterns.Decorator;

/*
 *  1. Base interface, IPizza
 *  2. Contrete class, Pizza
 *  3. Base decorator class, PizzaDecorator
 *  4. Derived decorator classes, CheeseDecorator, 
 *     MushroomDecorator, and OnionDecorator
 */

public static class Program
{
    public static void Main(string[] args)
    {
        IPizza basePizza = new Pizza();

        IPizza cheeseDecorator = new CheeseDecorator(basePizza);
        IPizza mushroomDecorator = new MushroomDecorator(cheeseDecorator);
        IPizza onionDecorator = new OnionDecorator(mushroomDecorator);
        Console.WriteLine(onionDecorator.GetPizzaType());
    }
}

