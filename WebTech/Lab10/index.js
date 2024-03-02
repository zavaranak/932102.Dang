const express = require('express')
const path = require('path')
const port = 3000
const app = express()

app.use(express.static(path.join(__dirname,'public')))
app.set('views', path.join(__dirname,'views'))
app.set('view engine', 'pug')


app.get('/',(req,res)=>{
    res.render('magic')
})

app.listen(port)
