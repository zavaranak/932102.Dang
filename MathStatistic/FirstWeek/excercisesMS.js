const json = {
    data1521 : [3,0,4,3,6,0,3,1],
    data1535: {
        0:2,
        1:2,
        2:1,
        3:1,
        4:2,
        5:4,
    },
    data1553: [
        0.01,0.29,0.70,1.01,1.50,2.46,0.01,0.42,0.72,1.01,1.52,2.50,0.04,0.46,
        0.76,1.02,1.54,3.73,0.17,0.47,0.78,1.03,1.59,4.07,0.18,0.47,0.83,1.05,
        1.71,6.03,0.22,0.56,0.85,1.32,1.90,0.22,0.59,0.87,1.34,2.10,0.25,0.67,
        0.93,1.37,2.35,0.25,0.68,1.00,1.47,2.46]
    ,
    p1566: [0.25,0.5,0.75]
 }
const excercises = document.querySelectorAll('.excercise')
//1521
    var html = json.data1521.join(', ')
    var sortData1521 = json.data1521.sort(compareNumbers)
    var labels1521 = sortData1521.filter((value, index, self) => self.indexOf(value) === index);
    var data1521 = []
    empireFunction(sortData1521,labels1521,data1521,excercises[0])
//1535
    const chartLine1535 = document.createElement('canvas')
    const chartBar1535 = document.createElement('canvas')
    const labels1535 = Object.keys(json.data1535)
    const n1535 = labels1535.length
    const data1535 = labels1535.map(function(key){
        return (json.data1521[key]/n1535).toFixed(2)
    })
    buildLineChart(chartLine1535,labels1535,data1535,'f(x)',excercises[1]) 
    excercises[1].appendChild(chartLine1535)
    buildBarChart(chartBar1535,labels1535,data1535,'f(x)',excercises[1])
    excercises[1].appendChild(chartBar1535)
    merchBarandLine(labels1535,data1535,excercises[1])
    
//1550
////n=50
    var n50 = document.createElement('h3')
    n50.innerHTML = '###n=50'
    var n1550 = 50 
    excercises[2].appendChild(n50)
    var rawData1550 = []
    for (var i = 0; i<50;i++){
        var random = Math.random()*0.999
        rawData1550.push(random)
    }
    var sortData1550 = rawData1550.sort(compareNumbers)
    var labels1550 = []
    for (var r = 1; r<=10; r++){
        labels1550.push(r/10)
    }
    var temp = 0
    const data1550 = labels1550.map(function(label){
        var value =0
        for(i=temp; i<sortData1550.length; i++){
            if(sortData1550[i]<label) value++
            else {
                temp = i           
                return value / n1550
            }
        }
    })
    const chartLine1550 = document.createElement('canvas')
    buildLineChart(chartLine1550,labels1550,data1550,'f(x)',excercises[2])
    excercises[2].appendChild(chartLine1550)
    const chartBar1550 = document.createElement('canvas')
    buildBarChart(chartBar1550,labels1550,data1550,'f(x)',excercises[2])
    excercises[2].appendChild(chartBar1550)
    merchBarandLine(labels1550,data1550,excercises[2])
//////n=80
    var n80 = document.createElement('h3')
    n80.innerHTML = '###n=80'
    var n15501 = 80
    excercises[2].appendChild(n80)
    var rawData15501 = []
    for (var i = 0; i<80;i++){
        var random = Math.random()*0.999
        rawData15501.push(random)
    }
    var sortData15501 = rawData15501.sort(compareNumbers)
    var labels15501 = []
    for (var r = 1; r<=10; r++){
        labels15501.push(r/10)
    }
    var temp = 0
    const data15501 = labels15501.map(function(label){
        var value =0
        for(i=temp; i<sortData15501.length; i++){
            if(sortData15501[i]<label) value++
            else {
                temp = i           
                return value/n15501
            }
        }
    })
    const chartLine15501 = document.createElement('canvas')
    buildLineChart(chartLine15501,labels15501,data15501,'f(x)',excercises[2])
    excercises[2].appendChild(chartLine15501)
    const chartBar15501 = document.createElement('canvas')
    buildBarChart(chartBar15501,labels15501,data15501,'f(x)',excercises[2])
    excercises[2].appendChild(chartBar15501)
    merchBarandLine(labels15501,data15501,excercises[2])
////n=100
    var n100 = document.createElement('h3')
    n100.innerHTML = '###n=100'
    var n15502 = 100
    excercises[2].appendChild(n100)
    var rawData15502 = []
    for (var i = 0; i<100;i++){
        var random = Math.random()*0.999
        rawData15502.push(random)
    }
    var sortData15502 = rawData15502.sort(compareNumbers)
    var labels15502 = []
    for (var r = 1; r<=10; r++){
        labels15502.push(r/10)
    }
    var temp = 0
    const data15502 = labels15502.map(function(label){
        var value =0
        for(i=temp; i<sortData15502.length; i++){
            if(sortData15502[i]<label) value++
            else {
                temp = i           
                return value / n15502
            }
        }
    })
    const chartLine15502 = document.createElement('canvas')
    buildLineChart(chartLine15502,labels15502,data15502,'f(x)',excercises[2])
    excercises[2].appendChild(chartLine15502)
    const chartBar15502 = document.createElement('canvas')
    buildBarChart(chartBar15502,labels15502,data15502,'f(x)',excercises[2])
    excercises[2].appendChild(chartBar15502)
    merchBarandLine(labels15502,data15502,excercises[2])
///1553 excercises[3]
    const rawData1553 = json.data1553
    const sortData1553 = rawData1553.sort(compareNumbers)
    const r1553 = Math.ceil(sortData1553[sortData1553.length-1])
    const labels1553 = []
    for(var i = 0 ; i<=r1553; i++){
        labels1553.push(i)
    }
    const data1553 = []
    empireFunction(sortData1553,labels1553,data1553,excercises[3])
    console.log(data1553)
    //chart
    const chartLine1553 = document.createElement('canvas')
    buildLineChart(chartLine1553,labels1553,data1553,"Frequency",excercises[3])
    excercises[3].appendChild(chartLine1553)
    const chartBar1553 = document.createElement('canvas')
    buildBarChart(chartBar1553,labels1553,data1553,"Frequency",excercises[3])
    excercises[3].appendChild(chartBar1553)
    merchBarandLine(labels1553,data1553,excercises[3])
////1566
    showCharacter(sortData1553,excercises[4])
    const text1566 = document.createElement('p')
    excercises[4].appendChild(text1566)
    
    text1566.innerHTML = `Уравнение F(x) = ${json.p1566.join('  |  ')}`
    merchBarandLine(labels1553,data1553,excercises[4])
/////////////////////////////////////
function buildLineChart(canvas,labels,data,labelName,excercise){
    text = document.createElement('p')
    excercise.appendChild(text)
    text.innerHTML = `Полигон частот <br>a: ${labels.join(' ')}<br>v: ${data.join(' ')}`
    new Chart( canvas, {
        type:'line',
        data:{
            labels: labels,
            datasets:[{
                label:labelName,
                data: data
            }]
        }
})}
function buildBarChart(canvas,labels,data,labelName,excercise){
    text = document.createElement('p')
    excercise.appendChild(text)
    text.innerHTML = `Гистограм <br>a: ${labels.join(' ')}<br>v: ${data.join(' ')}`
    new Chart( canvas, {
        type:'bar',
        data:{       
            labels: labels,
            datasets:[{
                barPercentage:1,
                categoryPercentage:1,
                label:labelName,
                data: data
            }], 
        } ,
})}

function merchBarandLine(labels,data,excercise){
    var chart = document.createElement('canvas')
    new Chart(chart,{
        type:'bar',
        data:{
        labels:labels,
        datasets:[
            {
            label:"Bar",
            data:data,
            type:'bar',
            order:1,
            barPercentage:1,
            categoryPercentage:1,
                  
            },
            {
            label:"Line",
            data:data,
            type:'line',
            order:0,
            
            },
        ]}
   
            
    })
    excercise.appendChild(chart)
}

function showCharacter(data,excercise){
    var average = getAverage(data)
    var dispersion = getDispersion(average,data)

    var text = document.createElement('p')
    text.innerHTML = `Выборки: ${data}<br>Выборочное среднее: ${average}<br>Дисперсия: ${dispersion} <br>`
    excercise.appendChild(text)
}
function getDispersion(average,data){
    return data.reduce(function(previous,current){
        return previous + (average - current)**2
    },0)/data.length
}
function getAverage(data){
    return data.reduce(function(previous,current){return previous+current},0)/data.length
}

function empireFunction(sortdata,labels,newdata,excercise){
    var temp =0
    var n = sortdata.length
    var copydata = sortdata.slice(0)
    var tempdata = labels.map(label=>{
        var result = copydata.filter(value=>value<label).length
        if (result>0) copydata = copydata.slice(result)
        return result/n
    })
    newdata.push(...tempdata)
    //display
    var text = document.createElement('p')
    text.innerHTML = `
    Упорядоченный: ${sortdata}<br>
    Размах: ${sortdata[sortdata.length-1]} Медиан: ${(sortdata[(sortdata.length)/2]+sortdata[(sortdata.length)/2-1])/2}
    <br>F<sub>${sortdata.length}</sub>(x) =<br>
    0 когда x<${labels[0]} <br>`
    
    for (var i = 1; i<labels.length;i++){
        text.innerHTML += `${newdata[i]} когда ${labels[i-1]} < x < ${labels[i]}`
        text.innerHTML += `<br>`
    }
    text.innerHTML += `1 когда x>${labels[labels.length-1]}`

    
    excercise.appendChild(text)
    
}
function compareNumbers(a, b) {
    return a - b;
}