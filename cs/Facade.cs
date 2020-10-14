namespace cs
{
    public class Subsystem1
    {
        public string operation1()
        {
            return "System 1 Operation 1";
        }
        public string operationN()
        {
            return "System 1 Operation N";
        }
    }
    public class Subsystem2
    {
        public string operation1()
        {
            return "System 2 Operation 1";
        }
        public string operationZ()
        {
            return "System 2 Operation Z";
        }
    }
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;
        public Facade()
        {
            this._subsystem1 = new Subsystem1();
            this._subsystem2 = new Subsystem2();
        }
        public string Operation()
        {
            return 
                this._subsystem1.operation1()+"\n"+
                this._subsystem2.operation1()+"\n"+
                this._subsystem1.operationN()+"\n"+
                this._subsystem2.operationZ();
        }
    }

}