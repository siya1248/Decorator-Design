namespace ConsoleApplication.Decorators;
public class PlainDecorator : Decorators<string>
{
 public PlainDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return "Prefix: " + base.GetText();
        }
}