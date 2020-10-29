using System.Collections;
using System;
namespace cs
{
    interface Flyweight
    {
        public void IncState(int value);
    }
    class ConcreteFlyweight : Flyweight
    {
        public int State = 0;

        public string Templite;

        public ConcreteFlyweight (string templite){
            this.Templite = templite;
        }
        public  void IncState(int value)
        {
            State += value;
        }

        public void Print (){
            Console.Write(this.Templite);
        }
    }
   
    class FlyweightFactory
    {
        Hashtable flyweights = new Hashtable();       
        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
                flyweights.Add(key, new ConcreteFlyweight(key));
            return flyweights[key] as Flyweight;
        }
    }
}