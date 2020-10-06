class RealSubject {
    Request (){
        return "Real subject response";
    }
}

class Proxy{
    constructor (subject){     
            this._subject = subject ||  new RealSubject();
    }

    Request (){
     if (this.CheckAccess()){
            let response = this._subject.Request();
            this.LogAccess (response);
            return response;
        }
        else 
            return "Proxy response";           
    }

    CheckAccess()
    {
        return Math.random()<0.5;
    }

    LogAccess(message){
        console.log(`Request was proxied:${message}`);
    }
} 

export {RealSubject, Proxy} 