var ClsFonctionOverloading = /** @class */ (function () {
    function ClsFonctionOverloading() {
    }
    ClsFonctionOverloading.prototype.printMessage = function (str, msg) {
        if (msg === undefined) {
            console.log("The Message is ".concat(str));
        }
        else {
            console.log("The Message is ".concat(str, " and ").concat(msg, " printing"));
        }
    };
    return ClsFonctionOverloading;
}());
//# sourceMappingURL=functionoverloading.js.map