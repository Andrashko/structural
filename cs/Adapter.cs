namespace cs
{
    public interface ITarget
    {
        string GetRequest();
    }
     class Adaptee
    {
        public string GetSpecificRequest(bool mustBeTrue)
        {
            if (!mustBeTrue) 
                throw new System.Exception ("U must call GetSpecificRequest(true)");
            return "Specific request.";
        }
    }
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }
        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest(true)}'";
        }
    }
}
