class Fliywight{
    constructor (){
        this.State = 0;
    }
    IncState(value){
        this.State += value
    }
}

class FlyweightFactory{
    constructor (){
        this.fliywights = {
        };
    }
    GetFlyweight(key){
        if (!this.fliywights[key])
            this.fliywights[key] = new Fliywight();
        return this.fliywights[key];    
    }
}

export {FlyweightFactory, Fliywight};