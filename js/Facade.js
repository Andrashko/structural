class Subsystem1 {
    operation1() {
        return "System 1 Operation 1";
    }
    operationN() {
        return "System 1 Operation N";
    }

}

class Subsystem2 {
    operation1() {
        return "System 2 Operation 1";
    }
    operationZ() {
        return "System 2 Operation Z";
    }
}


class Facade {
    constructor() {
        this._subsystem1 = new Subsystem1();
        this._subsystem2 = new Subsystem2();
    }
    Operation() {
        return
        this._subsystem1.operation1() + "\n" +
            this._subsystem2.operation1() + "\n" +
            this._subsystem1.operationN() + "\n" +
            this._subsystem2.operationZ();
    }
}


export default Facade; 