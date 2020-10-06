class Page{
    constructor (content, them){        
        this.content = content || "";
        this.them = them || {}; 
        this.template = 
        `<html>
            <head>
                {{style}}
            </head>
            <body>
                {{content}}
            </body>
        </html>`
    }
    Render(){
        return this.template.replace("{{content}}", this.content).replace("{{style}}", this.them.GetStyle());
    }
}

class AboutPage extends Page{
    constructor(company, them){       
        let content = 
        `<h1 > 
            ${company}
        </h1>`;
        super(content, them);
    }
}

class Them {
    constructor (color, background){
        this.color = color;
        this.background = background;
        this.template = `
            <style>
                * {
                    color: {{color}}; 
                    background: {{background}};
                }
            </style>`;
    }
    GetStyle (){
        return this.template.replace("{{color}}", this.color).replace("{{background}}", this.background);
    }
}

class DarckThem extends Them {
    constructor(){
        super ("white", "black")
    }
}

class LigthThem extends Them {
    constructor (){
        super ( "black", "white")
    }
}

export {Page, AboutPage, LigthThem, DarckThem}