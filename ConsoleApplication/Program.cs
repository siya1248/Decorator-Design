using ConsoleApplication.Components;
using ConsoleApplication.Interfaces;
using ConsoleApplication.Decorators;
public class Program
    {
        public static void Main(string[] args)
        {
            
            IComponent<string> component = new ConcreteComponent();

            
            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
            IComponent<string> colorDecorator = new ColorDecorator(component);

           
            Console.WriteLine("ConcreteComponent: " + component.GetText());
            Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());
            Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());
        }
    }