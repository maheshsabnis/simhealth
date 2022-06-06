var ClsCtorMembers = /** @class */ (function () {
    function ClsCtorMembers(x, y, z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    ClsCtorMembers.prototype.add = function () {
        if (!this.validate(this.x, this.y)) {
            return 0;
        }
        /*  else {*/
        this.z = (this.x * this.x) + 2 * this.x * this.y + (this.y * this.y);
        return this.z;
        /* }*/
    };
    ClsCtorMembers.prototype.validate = function (a, b) {
        if (a === 0 || b === 0)
            return false;
        return true;
    };
    return ClsCtorMembers;
}());
//# sourceMappingURL=construtormembers.js.map