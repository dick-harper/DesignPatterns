using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class MushroomDecorator : PizzaDecorator
    {
        public MushroomDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += $"{Environment.NewLine}Add mushrooms!";
            return type;
        }
    }
}
