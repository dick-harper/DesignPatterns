using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += $"{Environment.NewLine}Add onions!";
            return type;
        }
    }
}
