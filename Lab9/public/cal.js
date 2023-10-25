const numbs = document.getElementsByClassName('butnum')
const mathOperators = document.getElementsByClassName('but')
const screen = document.getElementById('screen')
const execute = document.getElementById('doMath')
const clear = document.getElementById('clear')
const storedValue = document.getElementById(`storedValue`)
const del = document.getElementById('delete')
const tds = document.getElementsByTagName('td')

var tempbut
var tempstr = ''
var result = null
var length = numbs.length
var length2 = mathOperators.length
var mathEnd = false


del.addEventListener('click',function(){screen.value= screen.value.slice(0,-1),highLight(this)})
execute.addEventListener('click',function(){executeMath(),highLight(this)})
clear.addEventListener('click',function(){clearMath(),highLight(this)})


for(var i =0; i<length;i++){
       
    numbs[i].addEventListener('click',function(event){ 
        if (mathEnd) {
            screen.value =''
            mathEnd = false
        }
        var numb = (event.target.textContent)    
        putIntoScreen(numb)       
        highLight(this)
    }) 
        
}
    
for(var i =0; i<length2;i++){
    mathOperators[i].addEventListener('click',function(event){
        var temp = event.target.textContent
        mathEnd = false

        if ((tempstr!=='')&&(needChange())&&(temp!=='-')) changeOperator(temp)
        else if ((tempstr)&&(temp=='-')) screen.value += temp
        else getOperator(temp)

        highLight(this)
    }) 
}
function showStoredValue(){
    storedValue.textContent = tempstr
}
function needChange(){
    var operator = tempstr[tempstr.length-1]
    if ((operator=='+')||(operator=='/')||(operator=='*')) 
    return true 
}
function getOperator(oper){    
    var keepGoing
    try{
        var test = eval(screen.value)
        keepGoing = true}
    catch(error){
        keepGoing = false
        alert(`Wrong Input`)}                
    if(keepGoing){
        screen.value+=oper
        tempstr = screen.value
        screen.value = ''
        showStoredValue()
    }          
}
function changeOperator(oper){
    console.log(`change ${tempstr[tempstr.length-1]} to ${oper}`)
    var tempstr2 = tempstr
    tempstr2 = tempstr.slice(0,-1)
    tempstr2 += oper
    tempstr = tempstr2 
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
    storedValue.textContent = ''
    tempstr = ''
}
function executeMath(){
    var temp = screen.value
    console.log(tempstr + temp)
    try{
        result = eval(tempstr+temp)}
    catch(error){
        alert('wrong input')
    }
    screen.value = result
    tempstr=''
    showStoredValue()
    mathEnd = true
 }
function highLight(button){
    if (tempbut) tempbut.style.border="none"
    button.style.border = "1.5px solid blue"
    tempbut = button
}







