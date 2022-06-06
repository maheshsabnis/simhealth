var Person = /** @class */ (function () {
    function Person(Id, Name) {
        this.Id = Id;
        this.Name = Name;
    }
    return Person;
}());
var persons = new Array();
persons.push(new Person(101, 'A'));
persons.push(new Person(102, 'B'));
function dynaicReader(data) {
    // Dynamically Read all ENtries from data with its Schema  (PropertyNAmes) and Values
    // First Read all public keys of the Person class
    var per = new Person(0, '');
    // Read Public Properties
    var keys = Object.keys(per);
    // Lets generate a Table with Person Info
    var table = '<table>';
    table += '<thead><tr>';
    for (var _i = 0, keys_1 = keys; _i < keys_1.length; _i++) {
        var column = keys_1[_i];
        table += "<th>".concat(column, "</th>");
    }
    table += '</tr></thead>';
    // Lets generate Body
    table += '<tbody>';
    for (var _a = 0, data_1 = data; _a < data_1.length; _a++) {
        var p = data_1[_a];
        table += "<tr><td>".concat(p.Id, "</td><td>").concat(p.Name, "</td></tr>");
    }
    table += '</tbody>';
    table += '</table>';
    return table;
}
//# sourceMappingURL=arrayreader.js.map