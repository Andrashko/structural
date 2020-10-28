using System;
using System.Collections.Generic;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {         
            // Component component = new ConcreteComponent();
            // Component decoratedA = new ConcreteDecoratorA(component);
            // Component decoratedAB = new ConcreteDecoratorB(decoratedA);
            // Component decoratedABA = new ConcreteDecoratorA(decoratedAB);
            // Console.WriteLine(decoratedABA.Operation());
         
            // ISubject subject = new RealSubject ();
            // Console.WriteLine (subject.Request()) ;
            // subject = new Proxy(subject as RealSubject);
            // Console.WriteLine (subject.Request()) ;
            // Console.WriteLine (subject.Request()) ;
            // Console.WriteLine (subject.Request()) ;

            // IImplementation implementationA = new ConcreteImplementationA();
            // IImplementation implementationB = new ConcreteImplementationB();
            // Abstraction abstractionA = new Abstraction(implementationA);
            // Abstraction abstractionB = new Abstraction(implementationB);
            // Abstraction exAbstractionA = new ExtendedAbstraction(implementationA);
            // Abstraction exAbstractionB = new ExtendedAbstraction(implementationB);
            // Console.WriteLine (abstractionA.Operation());
            // Console.WriteLine (abstractionB.Operation());
            // Console.WriteLine (exAbstractionA.Operation());
            // Console.WriteLine (exAbstractionB.Operation());
            
            // Adaptee oldLib = new Adaptee();
            // Console.WriteLine(oldLib.GetSpecificRequest(true));
            // Adapter newLib = new Adapter(oldLib);
            // Console.WriteLine(newLib.GetRequest());
           
            // Process process = new Process();
            // AdaptedPocess adaptedPocess = new AdaptedPocess(process) ;
            // ProcessInformation pi = adaptedPocess.Create ("notepad.exe"); 
            // Console.WriteLine (pi.hProcess);
          
            // Facade facade = new Facade();
            // Console.WriteLine(facade.Operation());            

            // FlyweightFactory factory = new FlyweightFactory();
            // ConcreteFlyweight fw1 = factory.GetFlyweight("one") as ConcreteFlyweight;
            // ConcreteFlyweight fw2 = factory.GetFlyweight("two") as ConcreteFlyweight;
            // ConcreteFlyweight fw3 = factory.GetFlyweight("one") as ConcreteFlyweight;
            // Console.WriteLine(fw1.State);
            // Console.WriteLine(fw2.State);                     
            // Console.WriteLine(fw3.State);
            // fw1.IncState(1);
            // fw2.IncState(1);
            // fw3.IncState(1);
            // Console.WriteLine(fw1.State);
            // Console.WriteLine(fw2.State);                     
            // Console.WriteLine(fw3.State);


            //    string text = LongText.Generate(); 
            // List<ConcreteFlyweight> list = new List<ConcreteFlyweight>();
            // Console.WriteLine("Choose action : \n 1) Create flywaight \n 2) create regural objects");             
            // int Choose = int.Parse(Console.ReadLine());
            // if (Choose == 1){
            //     for (int i=0; i< text.Length;i++ ){
            //         list.Add(factory.GetFlyweight(text[i].ToString()) as ConcreteFlyweight);
            //     }
            // }
            // if (Choose == 2 ){
            //     for (int i=0; i< text.Length;i++ ){
            //         list.Add(new ConcreteFlyweight());
            //     }
            // }
            // Console.WriteLine("Done");
            // Console.ReadLine()           ;


            Composite root = new Composite();
            Composite left = new Composite();
            left.Add(new Leaf());
            left.Add(new Leaf());
            root.Add(left);
            Composite right = new Composite();
            right.Add(new Leaf());
            right.Add(new Composite());
            right.Add(new Leaf());
            root.Add(right);
            Console.WriteLine( root.Operation());
        }
    }
}