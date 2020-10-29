using System;
using System.Collections.Generic;

namespace cs
{
    abstract class CompositeComponent
    {
        public CompositeComponent() { }
        public abstract string Operation();
        public virtual void Add(CompositeComponent component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(CompositeComponent component)
        {
            throw new NotImplementedException();
        }
        public virtual bool IsComposite()
        {
            return true;
        }
    }
    class Leaf : CompositeComponent
    {
        public override string Operation()
        {
            return "Leaf";
        }
        public override bool IsComposite()
        {
            return false;
        }
    }

    class Composite : CompositeComponent
    {
        protected List<CompositeComponent> _children = new List<CompositeComponent>();
        public override void Add(CompositeComponent component)
        {
            this._children.Add(component);
        }
        public override void Remove(CompositeComponent component)
        {
            this._children.Remove(component);
        }
        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";
            foreach (CompositeComponent component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";
        }
    }

}