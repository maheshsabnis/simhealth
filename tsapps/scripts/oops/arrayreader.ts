class Person {
    constructor(public Id:number, public Name:string) { }
}

let persons: Array<Person> = new Array<Person>();

persons.push(new Person(101, 'A'));
persons.push(new Person(102, 'B'));


function dynaicReader(data: Array<Person>): string {
    // Dynamically Read all ENtries from data with its Schema  (PropertyNAmes) and Values
    // First Read all public keys of the Person class
    let per = new Person(0, '');
    // Read Public Properties
    let keys = Object.keys(per);

    // Lets generate a Table with Person Info
    let table: string = '<table>';
    table += '<thead><tr>';
    for (let column of keys) {
        table += `<th>${column}</th>`;
    }
    table += '</tr></thead>';

    // Lets generate Body
    table += '<tbody>';
    for (let p of data) {
        table += `<tr><td>${p.Id}</td><td>${p.Name}</td></tr>`;
    }
    table += '</tbody>';
    table += '</table>';
    return table;
}