const content = document.querySelector('.container')
if(content) console.log(numb1,numb2,math)
const mathView = document.createElement('div')
var result = 0
var op = '+'
switch(math){
    case('plus'): result = numb1 + numb2; break
    case('minus'): result = numb1 - numb2; op = '-'; break
    case('mult'): result = numb1 * numb2; op ='*'; break
    case('div'): result = numb1 / numb2; op='/'; break
}

mathView.innerHTML+=
`${numb1} ${op} ${numb2} = ${result}`
content.appendChild(mathView)

