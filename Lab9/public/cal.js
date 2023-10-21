const numbs = document.getElementsByClassName('butnum')
const mathOperators = document.getElementsByClassName('but')
const screen = document.getElementById('screen')
const execute = document.getElementById('doMath')
const clear = document.getElementById('clear')
const storedValue = document.getElementById(`storedValue`)
const del = document.getElementById('delete')
var operator = null
var number1 = null
var number2 = null
var result = null
var tempOperator = null
var mathContinue = true
var length = numbs.length
var length2 = mathOperators.length

del.addEventListener('click',()=>{screen.value= screen.value.slice(0,-1)})
execute.addEventListener('click',()=>executeMath())
clear.addEventListener('click',()=>clearMath())

for(var i =0; i<length;i++){
        numbs[i].addEventListener('click',(event)=>{
            var numb = (event.target.textContent)    
            putIntoScreen(numb)       
        }) 
    }
    
for(var i =0; i<length2;i++){
        mathOperators[i].addEventListener('click',(event)=>{          
            getOperator(event)
        }) 
    }

function showStoredValue(){
    storedValue.textContent = `${number1}` + operator
}
function getOperator(event){          
        if (operator !== null) mathContinue = true    
        if ((number1!==null)&&(mathContinue)){
            number2 = parseFloat(screen.value)
            number1 = doMath()
        } 
        else(
            number1 = screen.value
        )
        operator = (event.target.textContent)    
        screen.value = ''
        showStoredValue()
}

function putIntoScreen(but){
    var input = but
    screen.value +=input
}
function clearMath(){
    number1 = null
    number2 = null
    result = null
    operator =null
    screen.value = ''
}
function mathDone(){
    result = doMath()
    tempOperator = operator
    screen.value = result
    number1 = result
    number2 = null
    operator = null
    mathContinue=false
    storedValue.textContent=''
}
function doMath(){  
    number1 = parseFloat(number1)  
    screen.value = ''
    switch(operator){
        case '+': 
            result = number1+number2 
            break
        case '-':
            result = number1-number2 
            break
        case '*':
            result = number1*number2 
            break
        case '/':
            result = number1/number2 
            break         
    }
    return result
    
}
function executeMath(){
    console.log(number1,number2,mathContinue)
    number2 = parseFloat(screen.value)
    if ((number2 !==null)&&(operator!==null))
        mathDone()
 }




