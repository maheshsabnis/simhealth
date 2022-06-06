var ClsMembers = /** @class */ (function () {
    function ClsMembers(n1) {
        // default is public
        this.num1 = 0;
        this.num2 = 20;
        this.num1 = n1;
    }
    ClsMembers.prototype.printValues = function () {
        console.log("Value for Private num1 is = ".concat(this.num1));
    };
    return ClsMembers;
}());
//# sourceMappingURL=classwithmembers.js.map