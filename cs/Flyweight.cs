using System.Collections;
namespace cs
{
    interface Flyweight
    {
        public void IncState(int value);
    }
    class ConcreteFlyweight : Flyweight
    {
        public int State = 0;
        public  void IncState(int value)
        {
            State += value;
        }
    }
   
    class FlyweightFactory
    {
        Hashtable flyweights = new Hashtable();       
        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
                flyweights.Add(key, new ConcreteFlyweight());
            return flyweights[key] as Flyweight;
        }
    }
}