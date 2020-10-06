class Component {
    Operation () {
        return "ConcreteComponent";
    }
}

class Decorator {
    constructor (component){
        this._component = component || new Component();
    }
    Operation (){
        if (this._component)
            return this._component.Operation();
        else
            return "Nothing is decorated";
    }    
}

class ConcreteDecoratorA extends Decorator{
    Operation(){
        return `ConcreteDecoratorA(${super.Operation()})`;
    }
}

class ConcreteDecoratorB extends Decorator{
    Operation(){
        return `ConcreteDecoratorB(${super.Operation()})`;
    }
}

export {Component, Decorator, ConcreteDecoratorA,  ConcreteDecoratorB}