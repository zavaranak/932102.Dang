const { urlencoded } = require('body-parser')
const express = require('express')
const path = require('path')
const app = express()
const basePath = __dirname
app.use(express.static(path.join(basePath,'public')))
app.use(express.json())
app.use(express.urlencoded())
app.set('views',path.join(basePath,'views'))
app.set('view engine', 'pug')

app.get('/',(req,res)=>{
    res.render('home')
})
app.get('/Calc/Manual',(req,res)=>{
    res.render('calcManual')
})
app.post('/Calc/Manual',(req,res)=>{
    const formData = req.body
    res.render('result',{formData})
})
app.listen('8000')  
