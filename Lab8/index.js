const add = document.getElementById('add')
const save = document.getElementById('save')
const rows = document.getElementById('rows')
const taskbar = document.getElementById('taskbar')
const arrayOfRow = document.getElementsByClassName('row')

var idIndex=0;
const down = "down"
const up = "up"

function moveRow(row,option){
    if(option === "down")
    {
        var rowNext = row.nextElementSibling
        if (rowNext){
            var parent = row.parentElement
            parent.insertBefore(rowNext,row)
        }
    }
    if(option === "up"){
        var rowPrevious = row.previousElementSibling
        if (rowPrevious){
            var parent = row.parentElement
            parent.insertBefore(row,rowPrevious)    
        }
    }
}

add.addEventListener('click',function(){
    idIndex+=1;
    const newrow = document.createElement('div')  
    newrow.classList.add('row')
    rows.appendChild(newrow)

    newrow.id = `row${idIndex}`

        const input1 = document.createElement('input')
        newrow.appendChild(input1)
        
        const input2 = document.createElement('input')
        newrow.appendChild(input2)

        const bUp = document.createElement('button')
        newrow.appendChild(bUp)
        bUp.innerHTML = "&uarr;"
        bUp.addEventListener(`click`,function(){
            moveRow(newrow,up);     
        })

        const bDown = document.createElement('button')
        newrow.appendChild(bDown)
        bDown.innerHTML = "&darr;"
        bDown.addEventListener(`click`,function(){        
            moveRow(newrow,down); 
        })
        
        const bX = document.createElement('button')
        bX.innerHTML = "x"
        bX.addEventListener(`click`,function(){
            newrow.remove()
        })
        newrow.appendChild(bX)
})

save.addEventListener(`click`,function(){  
    const p = document.createElement('article')
    p.textContent = '{ ';
    const textContent = [];
    for(var i=0;i<arrayOfRow.length;i++){
        const input1value = arrayOfRow[i].childNodes[0].value
        const input2value = arrayOfRow[i].childNodes[1].value
        const newText = input1value + ":" + input2value
        console.log(input1value +":"+ input2value)
        textContent.push(newText)
    }
    p.textContent += textContent.join(', ')
    p.textContent +=" }"
    taskbar.appendChild(p)
})