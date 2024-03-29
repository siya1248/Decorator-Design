namespace ConsoleApplication.Components;
using ConsoleApplication.Interfaces;
public class ConcreteComponent : IComponent<string>
{
    public string GetText(){
        return "This is a string";
    }
}