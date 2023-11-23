console.log(formData)
const operator = formData.operator
const numb1 = parseFloat(formData.numb1)
const numb2 = parseFloat(formData.numb2)
let result = null 
switch(operator){
case('+'): result = numb1 + numb2; break;
case('-'): result = numb1 - numb2; break;
case('/'): result = numb1 / numb2; break;
case('*'): result = numb1 * numb2; break;
}
console.log(result)
const show = document.querySelector('.showResult')
const display = document.createElement('h3')
show.appendChild(display)
display.innerHTML = `${numb1} ${operator} ${numb2} = ${result}`