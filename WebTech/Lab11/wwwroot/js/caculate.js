const content = document.querySelector('.container')
if(content) console.log(numb1,numb2)
const math = document.createElement('div')
math.innerHTML =`<b>Rand Value First: ${numb1}<br>Rand Value Second: ${numb2}</b><br>`
math.innerHTML+=`<b>Add:<br></b>${numb1}+${numb2}=${parseInt(numb1+numb2)}
<br><b>Sub:<br></b>${numb1}-${numb2}=${parseInt(numb1-numb2)}
<br><b>Mult:<br></b>${numb1}*${numb2}=${parseInt(numb1*numb2)}
<br><b>Div:<br></b>${numb1}/${numb2}=${parseInt(numb1/numb2)}`
content.appendChild(math)
