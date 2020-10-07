/*import {Component, Decorator, ConcreteDecoratorA,  ConcreteDecoratorB} from "./Decorator";

let component = new Component();
let decoratedA = new ConcreteDecoratorA(component);
let decoratedAB = new ConcreteDecoratorB(decoratedA);
let decoratedABA = new ConcreteDecoratorA(decoratedAB);  
console.log(decoratedABA.Operation());


function FunctionDecorator  (component){
    const _operation = component.Operation;
    component.Operation = function () {
        return  `FunctionDecorator(${_operation()})`;
    }    
    return component;
}

let decoratedABAF = FunctionDecorator (FunctionDecorator (new Component()));
console.log(decoratedABAF.Operation());

import {RealSubject, Proxy} from "./Proxy";
let subject = new RealSubject();
console.log (subject.Request());
subject = new Proxy(subject);
console.log (subject.Request());
console.log (subject.Request());
console.log (subject.Request());
*/

import {Page, AboutPage, ProjectsPage,  LigthThem, DarckThem, AquaThem} from "./Bridge";
let aboutD = new AboutPage( "UzhNU",  new DarckThem());
let aboutL = new AboutPage( "UzhNU", new LigthThem());
console.log (aboutD.Render());
console.log (aboutL.Render());
let projectsA = new ProjectsPage( ["Системний аналіз", "Математика"], new AquaThem());
console.log(projectsA.Render());