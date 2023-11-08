const json = {
    data1521 : [3,0,4,3,6,0,3,1],
    data1535: {
        0:2,
        1:2,
        2:1,
        3:1,
        4:2,
        5:4,
    }
}
//1521
var count = json.data1521.length
document.querySelector('#sub1521').innerHTML = count
var html = json.data1521.join(', ')
var sortData = json.data1521.sort(compareNumbers)
var statistic = {}
var filter = []
sortData.forEach(function(element){
    if(filter.includes(element)) {
        statistic[element]++
    }
    else {
        statistic[element] = 1
        filter.push(element)
    }
})
document.querySelector('#p1521').innerHTML += html + `<br>`
html = 'Упорядоченный: ' +sortData.join(',')
document.querySelector('#p1521').innerHTML += html +
 `<br> Размах: ${sortData[7] - sortData[0]} Медиан: ${(sortData[4] + sortData[3])/2}`

html= `0 когда x<0 <br>`
document.querySelector('#functionFx').innerHTML += html
const keys = Object.keys(statistic)

for(var i = 0;i<keys.length;i++){
    if (i==keys.length-1){
        html= `1 когда x > ${keys[i]}<br>`
    }
    else html= `${statistic[keys[i]]/count} когда ${keys[i]} <=x< ${keys[i+1]}<br>`
    document.querySelector('#functionFx').innerHTML += html
}

//1535
const chartLine1535 = document.querySelector('#chart1535-line') 
const chartBar1535 = document.querySelector('#chart1535-bar') 
const text1535 = document.querySelector('#text1535')
const labels1535 = Object.keys(json.data1535)
const data1535 = labels1535.map(function(key){
    return json.data1521[key]
})
buildLineChart(chartLine1535,labels1535,data1535,'Frequent',text1535)
buildBarChart(chartBar1535,labels1535,data1535,'Frequent',text1535)

function buildLineChart(canvas,labels,data,labelName,textArea){
    textArea.innerHTML = `Полигон частот и Гистограм <br>a: ${labels.join(' ')}<br>v: ${data.join(' ')}`
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
function buildBarChart(canvas,labels,data,labelName,textArea){
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


function compareNumbers(a, b) {
    return a - b;
}