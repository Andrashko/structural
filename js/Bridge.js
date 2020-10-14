class Page{
    constructor (content, them){        
        this.content = content || "";
        this.them = them || new Them ("black", "white"); 
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

class ProjectsPage extends Page{
    constructor (projects, them){
        let content = "<ol>\n";
        for (let project of projects){
            content += `<li> ${project} </li>\n`; 
        }
        content += "</ol>\n";
        super (content, them);
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
        super ("white", "black");
    }
}

class LigthThem extends Them {
    constructor (){
        super ( "black", "white");
    }
}

class AquaThem extends Them {
    constructor(){
        super ("aqua", "blue");
    }
}

export {Page, AboutPage, ProjectsPage, LigthThem, DarckThem, AquaThem}