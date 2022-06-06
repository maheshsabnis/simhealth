class ClsCtorMembers {
    constructor(
        private x: number,
        private y: number,
        private z: number
    ) { }

    add(): number {
        if (!this.validate(this.x, this.y)) {
            return 0;
        }
      /*  else {*/
            this.z = (this.x * this.x) + 2 * this.x * this.y + (this.y * this.y);
            return this.z;
       /* }*/
    }

    private validate(a: number, b: number): boolean {
        if (a === 0 || b === 0) return false;
        return true;
    }
}