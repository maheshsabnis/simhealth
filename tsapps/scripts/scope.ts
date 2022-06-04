function display(x) {
    if (x) {
        let y = 10;
        console.log('In if statement y ' + y);
    }
    console.log('Out of if block');
}

// call function
console.log('call for true');
display(true);
console.log('call for false');
display(false);