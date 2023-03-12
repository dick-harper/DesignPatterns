using Decorator.Interfaces;

namespace DesignPatterns.Decorator;

public class Pizza : IPizza
{
    public string GetPizzaType()
    {
        return "This is a pizza with tomato sauce.";
    }
}