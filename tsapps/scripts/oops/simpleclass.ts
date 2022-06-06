// class is a keyword
// default access specifier for class members is 'public'
// contains: Data Members, Member Funtions, properties(Get/Set)
// the 'constructor()' is a standard function 
class ClsSimple {
    constructor() {
        console.log('The Constructor Function');  
    }
    // Return Type is Recommended for FUnctions
    printMessage(): void {
        console.log('The Print Message Method');   
    }
}
