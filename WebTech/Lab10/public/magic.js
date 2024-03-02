
const container = document.querySelector('.container')

const curtain = document.createElement('img')
curtain.src = '/imgs/1.jpg'
curtain.alt = 'curtain'
curtain.classList.add('curtain')
curtain.addEventListener('click',(e)=>{
    closeCurtain(e)
        .then(function(){
            return new Promise((resolve)=>{
                setTimeout(resolve,250)})
            })
        .then(function(){     
            const lamp = document.createElement('img')
            lamp.src = '/imgs/3.jpg'
            lamp.alt = 'lamp'
            lamp.classList.add('lamp')
            curtain.remove() 
            container.appendChild(lamp)
            return lamp
        })
        .then(function(lamp){
            const magicianBlock = document.createElement('div')
            const magician = document.createElement('img') 
            const yellowLight = document.createElement('div')
            const rabbitOrBird = document.createElement(`img`)
            const hat = document.createElement('img')
            const hatBox = document.createElement('div')

            container.appendChild(yellowLight)

            magicianBlock.style = 'display: none; justify-content: space-around; width: 500px; margin-top: 120px'
            magician.src = '/imgs/2.jpg'
            magician.alt = 'magician'
            magician.classList.add('insideMagicBox')

            hatBox.style = 'display: flex; flex-direction: column'

            hat.src = '/imgs/hat.jpg'
            hat.alt = 'hat'
            hat.classList.add('insideHatBox')

            rabbitOrBird.src = '/imgs/rabbit.jpg'
            rabbitOrBird.id = 'rabbit'
            rabbitOrBird.classList.add('insideHatBox')
            rabbitOrBird.addEventListener('click',(e)=>{doMagic(e)})
            hatBox.appendChild(rabbitOrBird)
            hatBox.appendChild(hat)

            magicianBlock.appendChild(magician) 
            magicianBlock.appendChild(hatBox)
            container.appendChild(magicianBlock)
            

            lamp.addEventListener('click',(e)=>{
                console.log('lam clicked')
                if (magicianBlock.style.display == 'none')
                    {magicianBlock.style.display = 'flex'
                    lamp.src = '/imgs/3.1.jpg'
                    }
                else {magicianBlock.style.display ='none'
                    lamp.src = '/imgs/3.jpg'
                    }
                yellowLight.classList.toggle('yellowLight')

            })
            }
        )
        
})

function doMagic(e){
    var currentState = e.target.id
    switch(currentState){
        case('bird'):
            e.target.src = '/imgs/rabbit.jpg'
            e.target.alt = 'rabbit'
            e.target.id = 'rabbit'
            break
        case('rabbit'):
            e.target.src = '/imgs/bird.png'
            e.target.alt = 'bird'
            e.target.id = 'bird'
            break
    }
    
}
function closeCurtain(e){
    e.target.style.transform = 'translateY(-100%)'
    return new Promise((resolve,reject)=>{resolve()})
}
container.appendChild(curtain)


