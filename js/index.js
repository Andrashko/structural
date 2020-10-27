// import {Component, Decorator, ConcreteDecoratorA,  ConcreteDecoratorB} from "./Decorator";

// let component = new Component();
// let decoratedA = new ConcreteDecoratorA(component);
// let decoratedAB = new ConcreteDecoratorB(decoratedA);
// let decoratedABA = new ConcreteDecoratorA(decoratedAB);  
// console.log(decoratedABA.Operation());


// function FunctionDecorator  (component){
//     const _operation = component.Operation;
//     component.Operation = function () {
//         return  `FunctionDecorator(${_operation()})`;
//     }    
//     return component;
// }

// let decoratedABAF = FunctionDecorator (FunctionDecorator (new Component()));
// console.log(decoratedABAF.Operation());

// import {RealSubject, Proxy} from "./Proxy";
// let subject = new RealSubject();
// console.log (subject.Request());
// subject = new Proxy(subject);
// console.log (subject.Request());
// console.log (subject.Request());
// console.log (subject.Request());


// import {Page, AboutPage, ProjectsPage,  LigthThem, DarckThem, AquaThem} from "./Bridge";
// let aboutD = new AboutPage( "UzhNU",  new DarckThem());
// let aboutL = new AboutPage( "UzhNU", new LigthThem());
// console.log (aboutD.Render());
// console.log (aboutL.Render());
// let projectsA = new ProjectsPage( ["Системний аналіз", "Математика"], new AquaThem());
// console.log(projectsA.Render())

// import {Good, Cart, CuponCart} from "./Adapter";
// let goods = [ new Good ("Bread", 12.95, 2), new Good("Milk", 35.00, 1) ];
// let cart = new Cart(goods);
// console.log(`Goods price is: ${cart.calcTotalPrice()}`);
// let cuponCart = new CuponCart(cart, "20%");
// console.log(`Goods price  with 20% cupon is: ${cuponCart.calcTotalPriceWithCupon()}`);

// import {TYPE, Facade} from "./Facade2";

// const music = new Facade (TYPE.MUSIC);
// music.get(3)
//     .then(data => console.log(data))
//     .catch(e => console.error(e));

// const books = new Facade(TYPE.BOOK);
// books.get(5)
// .then(data => console.log(data))
// .catch(e => console.error(e));   

import {FlyweightFactory} from "./Flyweight";
let factory = new FlyweightFactory();
let fw1 = factory.GetFlyweight("one");
let fw2 = factory.GetFlyweight("two");
let fw3 = factory.GetFlyweight("one");
console.log(fw1.State);
console.log(fw2.State);
console.log(fw1.State);
fw1.IncState(1);
fw2.IncState(1);
fw3.IncState(1);
console.log(fw1.State);
console.log(fw2.State);
console.log(fw1.State);