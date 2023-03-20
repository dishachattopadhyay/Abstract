const ChngBGColor = () => {
    document.body.firstElementChild.style.background ="red"
}

// alert("wassssuppp")
// prompt(" yoo hoo")
// confirm("yes/no")

let b = document.body
console.log("First Child of b is :", b.firstChild)
console.log("First Element Child of b is :", b.firstElementChild)

let t = document.body.firstElementChild.nextElementSibling.firstElementChild
console.log(t)
console.log(t.rows)
console.log(t.caption)
console.log(t.tHead)
console.log(t.tHead.firstElementChild)
//console.log(t[0].cellIndex)

//change the card title to red

let ctitle = document.getElementById("title") //this will retuen single thing
ctitle.style.color="red"

let  cards = document.querySelectorAll(".card")
console.log(cards)
cards[0].style.color = "blue"
cards[1].style.color = "red"
cards[2].style.color = "green"

let a = document.querySelector(".card-body").style.color = "violet"

console.log(document.getElementsByTagName("a"))

// console.log("#cardnew.innerHTML")
let c = ctitle.getAttribute("class")
console.log(c)

let d = document.getElementById("cardnew")
console.log(d)
// let f = cardnew.getAttribute("class")
// console.log(f)
let e = d.hasAttribute("class")
console.log(e)

let f = document.getElementById("insert")
console.log(f)
f.innerHTML = f.innerHTML + '<h1> Inner HTML insertion </h1>'


let g = document.createElement("div")
g.innerHTML = "<h3> Another inner HTML <h3>"
f.appendChild(g)

// f.append(g)
// f.prepend(g)
// f.before(g)
//f.after(g)

//f.replaceWith(g)

                  // -----Alert Prompt----////

// let i = setTimeout(function(){
//     alert("Inside function alert")
// },5000)

// let h = prompt("Do you want to run this set timeout" )
// if(h=='n'){
//     clearTimeout(i)
// }


                      // -----EVENTS----- //
let j = document.getElementById("btn2").addEventListener('click' , Alert)
console.log("This is btn2" +j)

function Alert() {
    alert('W')
}


let x = function () {
    alert('!st Listner')
}

let y = function () {
    alert('2st Listner')
}

btn3.addEventListener('click', x)

btn3.addEventListener('click', y)

let z = prompt("Choose B/w 1 & 2")
if( z == "2"){
    console.log(z);
    btn3.removeEventListener('click' , x)
}

// btn2.addEventListner('click' , function ( e ) {
//     alert('rrt ')
// })
// btn2.addEventListner('click', function () {
//     alert('You Choose 1')
// })


//call back
function  loadscript(src , callback) {
    var script = document.createElement("script");
    script.src = src;
    script.onload = function(){
    console.log("Loaded" + src);
    callback(src);
    }
    document.body.appendChild(script)
}

function hola(src) {
    alert('Hola  '+src)
    
}

loadscript("https://www.google.com/ ", hola )


//----Promise----
let p = new Promise ((resolve , reject) => {
    setTimeout(()=>{
        resolve(5);
    }, 3*1000);
}) ;

p.then((result)=>{
    console.log(result);
    return (result*2);
}).then((result)=>{
    console.log(result);
    return (result*5);
}).then((result)=>{
    console.log(result)
    return 10;
}).then((result)=>{
    console.log(result)
})


//----Multiple Handler for Promise----
console.log("Multiple Handler for Promise")

let p1=new Promise((resolve , reject)=>{
    setTimeout(() => {
        resolve(5)
    }, 5000);
})

p1.then((result)=>{
    console.log(result)
    return (result*2)
})

p1.then((result)=>{
    console.log(result)
    return (result*3)
})

p1.then((result)=>{
    console.log(result)
    return (result*4)
})

//___Returning a Promise _____
console.log("Returning Promise")

function fun (num) {
    return new Promise((resolve , reject)=> {
        setTimeout(()=>{
            resolve(num)
        }, 3*1000);
    })   
}

fun(342).then((result)=>{
    console.log(result)
    return fun(result*2)
}).then((result)=>{
    console.log(result)
    return fun*5
})
