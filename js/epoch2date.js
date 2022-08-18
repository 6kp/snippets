console.clear()

console.log('\x1b[35m%s\x1b[1m', '[1] Epoch > Date');
console.log('\x1b[35m%s\x1b[1m', '[2] Date > Epoch');

const target = new document();
document.addEventListener("keypress", function onEvent(event) {
    if (event.key === "1") {
        console.clear()
    }
    else if (event.key === "2") {
        console.clear()
    }
});