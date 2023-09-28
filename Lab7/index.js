let input = document.getElementById('num');
let squareB = document.getElementById('squareB');
let canvas = document.getElementById('canvas');

squareB.addEventListener('click',function() {SquareInit(input.value)})

function SquareInit(num){
    for(let i=0;i < num;i++)
        {   
            console.log(num);
            let newSquare = document.createElement('div');
            let side = Math.random()*100;
            let x = Math.random() * (canvas.clientWidth + side); // Random x-coordinate
            let y = Math.random() * (canvas.clientHeight + side); // Random y-coordinate 
            newSquare.style= `width:${side}px;height: ${side}px;top: ${x}px;left:${y}px`;
            console.log(`${newSquare.style.width}`,x,y);
            newSquare.classList.add('square');
            canvas.appendChild(newSquare);
        }
}