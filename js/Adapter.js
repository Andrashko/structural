class Good{
    constructor (description, price, amount){
        this.description = description || "No description";
        this.price = price || 0;        
        this.amount = amount || 0;
    }
    toPay (discountFunction){
        if (discountFunction) 
           return discountFunction(this.price * this.amount)
        return this.price * this.amount;
    }  
}
class Cart{
    constructor (goods){
        this.goods = goods;
    }

    calcTotalPrice(){
        let total = 0;
        for (let good of this.goods )
            total += good.toPay();
        return total;     
    }

    calcTotalPriceWithDiscount (discountFunction){
        let total = 0;
        for (let good of this.goods )
            total += good.toPay(discountFunction);
        return total;  
    }
}

class CuponCart{
    constructor (cart, cupon){
        this.cart = cart || new Cart();              
        this.cupon = cupon || "0";
    }

    cuponToNumber (){
        return parseFloat(this.cupon) / 100;
    } 
    calcTotalPriceWithCupon (){
        let discountCoefficient = 1 - this.cuponToNumber();
        let  percentDiscount = price => price * discountCoefficient;
        return this.cart.calcTotalPriceWithDiscount(percentDiscount); 
    }
}

Cart.calcTotalPriceWithCupon = function (){
    let discountCoefficient = 1 - this.cuponToNumber();
    let  percentDiscount = price => price * discountCoefficient;
    return this.cart.calcTotalPriceWithDiscount(percentDiscount); 
}  

export {Good, Cart, CuponCart};