// class is a keyword
// default access specifier for class members is 'public'
// contains: Data Members, Member Funtions, properties(Get/Set)
// the 'constructor()' is a standard function 
var ClsSimple = /** @class */ (function () {
    function ClsSimple() {
        console.log('The Constructor Function');
    }
    // Return Type is Recommended for FUnctions
    ClsSimple.prototype.printMessage = function () {
        console.log('The Print Message Method');
    };
    return ClsSimple;
}());
//# sourceMappingURL=simpleclass.js.map