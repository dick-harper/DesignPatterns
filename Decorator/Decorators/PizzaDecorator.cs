using Decorator.Interfaces;

namespace Decorator.Decorators;

public abstract class PizzaDecorator : IPizza
{
    private IPizza _pizza;

    public PizzaDecorator(IPizza pizza)
    {
        _pizza = pizza;
    }

    public virtual string GetPizzaType()
    {
        return _pizza.GetPizzaType();
    }
}