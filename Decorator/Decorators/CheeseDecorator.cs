using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += $"{Environment.NewLine}Add cheese!";
            return type;
        }
    }
}
