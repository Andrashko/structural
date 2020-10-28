class File{
    constructor (name, ext){
        this.name = name;
        this.ext = ext;
        this.isComposite = false;  
    }  
    
    toString(level=0){
        return `${" . ".repeat(level)} ${this.name}.${this.ext}\n`;
    }
}

class Folder{
    constructor (name){
        this.files = [];
        this.name = name;        
    }

    Add(file){
        this.files.push(file);
        return this;        
    }

    Remove(file){
        const index = this.files.findIndex(f => file.name === f.name);
        if (index > -1) 
            this.files.splice(index,1);           
        return this;    
    }

    toString(level=0){
        let result = `${" . ".repeat(level)} > ${this.name}\n`;
        for (let file of this.files)
            result += file.toString(level+1);
        return result;
    }
}

export {File, Folder};