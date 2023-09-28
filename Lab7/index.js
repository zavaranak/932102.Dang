let input = document.getElementById('num');
let squareB = document.getElementById('squareB');
let circleB = document.getElementById('circleB');
let triangleB = document.getElementById('triangleB');
let canvas = document.getElementById('canvas');

squareB.addEventListener('click',function() {FigureInit(input.value,'square')})
circleB.addEventListener('click',function() {FigureInit(input.value,'circle')})
triangleB.addEventListener('click',function() {FigureInit(input.value,'triangle')})
function FigureInit(num,figure){
    for(let i=0;i < num;i++)
        {   

            console.log(num);
            let newFigure = document.createElement('div');
            let side = Math.random()*150;
            let x = 60 + Math.random() * 350; // Random x-coordinate
            let y = 60 + Math.random() * 350 +Math.random() * 150 + Math.random() * 150; // Random y-coordinate 
            newFigure.classList.add(`${figure}`);                                        //Поставить фигуру
            newFigure.addEventListener('dblclick',()=>{newFigure.remove()})              //Удалить при 2-разном нажитии
            console.log(figure);
            if (figure=='triangle'){
                newFigure.style= `border-bottom-width:${side}px;border-left-width:${side}px;border-right-width:${side}px;top: ${x}px;left:${y}px`;
            }
            else{newFigure.style= `width:${side}px;height: ${side}px;top: ${x}px;left:${y}px`;}
            console.log(`${newFigure.style.width}`,x,y);
            canvas.appendChild(newFigure);
        }
}