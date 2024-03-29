namespace ConsoleApplication.Decorators;
public class UpperCaseDecorator : Decorators<string>
{
    public UpperCaseDecorator(IComponent<string> component) : base(component)
    {}
    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}