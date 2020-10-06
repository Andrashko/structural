using System;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Component component = new ConcreteComponent();
            Component decoratedA = new ConcreteDecoratorA(component);
            Component decoratedAB = new ConcreteDecoratorB(decoratedA);
            Component decoratedABA = new ConcreteDecoratorA(decoratedAB);
            Console.WriteLine(decoratedABA.Operation());
          
            ISubject subject = new RealSubject ();
            Console.WriteLine (subject.Request()) ;
            subject = new Proxy(subject as RealSubject);
            Console.WriteLine (subject.Request()) ;
            Console.WriteLine (subject.Request()) ;
            Console.WriteLine (subject.Request()) ;
            */
            IImplementation implementationA = new ConcreteImplementationA();
            IImplementation implementationB = new ConcreteImplementationB();
            Abstraction abstractionA = new Abstraction(implementationA);
            Abstraction abstractionB = new Abstraction(implementationB);
            Abstraction exAbstractionA = new ExtendedAbstraction(implementationA);
            Abstraction exAbstractionB = new ExtendedAbstraction(implementationB);
            Console.WriteLine (abstractionA.Operation());
            Console.WriteLine (abstractionB.Operation());
            Console.WriteLine (exAbstractionA.Operation());
            Console.WriteLine (exAbstractionB.Operation());
        }
    }
}
