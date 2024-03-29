namespace ConsoleApplication.Decorators;
public ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component)
    {}
    public override GetText()
    {
        return $"\u001b[31m{base.GetText()}\u001b[0m";
    }

}