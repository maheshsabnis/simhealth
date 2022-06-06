class ClsFonctionOverloading {
    printMessage(str: string, msg:string): void;
    printMessage(str: string, msg: string): void;

    printMessage(str: string, msg: string): void {
        if ( msg === undefined) {
            console.log(`The Message is ${str}`);
        }
        else {
            console.log(`The Message is ${str} and ${msg} printing`); 
        }
    }

    add(a: number, b:number): number;
    add(a: number, b: string): string;

    add(a: number, b: number) {

    }


    
    //printMessage(str: string): void {
    //    console.log(`The Message is ${str}`);  
    //}
    //printMessage(str: string, msg: string): void {
    //    console.log(`The Message is ${str} and ${msg} printing`); 
    //}
}

