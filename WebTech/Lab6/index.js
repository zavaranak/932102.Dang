var cat = document.getElementById('cat');
var dog = document.getElementById('dog');
var catDiv = document.getElementById('cat-div');
var dogDiv = document.getElementById('dog-div');
var buttonL = document.getElementById('left');
var buttonB = document.getElementById('both');
var buttonR = document.getElementById('right');
var meow = document.getElementById('meow');
var goff = document.getElementById('goff');

buttonL.addEventListener('click',function() {AnimalActive(cat,dog,catDiv,dogDiv,meow)});
buttonR.addEventListener('click',function() {AnimalActive(dog,cat,dogDiv,catDiv,goff)});
buttonB.addEventListener('click',function() {BothActive()});


function BothActive(){
    catDiv.style.width = '50%';
    dogDiv.style.width = '50%';
    cat.style ="display:block;width:90%;height:60%";
    dog.style ="display:block;width:90%;height:60%";
    meow.play();
    goff.play();
    
}

function AnimalActive(x1,x2,y1,y2,audio){
    x1.style = 'height :220px; width:370px; display:flex';
    x2.style = 'display:none';
    y2.style = 'width:50px';
    y1.style = 'height :300px; width:600px;';
    audio.play();
}

