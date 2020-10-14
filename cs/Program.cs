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
<<<<<<< HEAD
         
=======
            */
            
>>>>>>> 846843c34fe6d1ddd3f161da23f76d4a5e5199a4
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
<<<<<<< HEAD
            
            Adaptee oldLib = new Adaptee();
            Console.WriteLine(oldLib.GetSpecificRequest(true));
            Adapter newLib = new Adapter(oldLib);
            Console.WriteLine(newLib.GetRequest());
            */
            Process process = new Process();
            AdaptedPocess adaptedPocess = new AdaptedPocess(process) ;
            ProcessInformation pi = adaptedPocess.Create ("notepad.exe"); 
            Console.WriteLine (pi.hProcess);
=======
        
>>>>>>> 846843c34fe6d1ddd3f161da23f76d4a5e5199a4
        }
    }
}
