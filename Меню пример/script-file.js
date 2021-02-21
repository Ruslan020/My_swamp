

window.onload = function()
{
    elem=document.getElementById("last_p");
    for(i=0; i<15; i++)
    {
        elem.innerHTML += i+" ";
    }
}
/*document.addEventListener("click", function(){elem=document.getElementById("last_p");
    for(i=0; i<15; i++)
    {
        elem.innerHTML += i+" ";
    }
    let arr = document.querySelectorAll('li');
    for(i=0;i<arr.length;i++)
    {
        arr[i].innerHTML = "Опа, все пропало!";
    }
    
    });*/

let item_main=document.getElementById("main-content");
let item=document.getElementById("main-content_div");
for(let i=1; i<=7; i++)
{
    let elem = document.getElementById("club_"+i);
    elem.addEventListener("click", function(){
        item.style.background= 'url(img/club_'+i+'.svg.png)  center no-repeat';
        item.style.backgroundHeigh='200px';
        
        item_main.style.background= 'url(img/club_fon_'+i+'.jpg) center no-repeat';
        item_main.style.backgroundWidth='100%';
    })
}

let img = document.getElementById("img180");
img.addEventListener("click", function() {
    img.classList.add("rotate");
    })
    
img.addEventListener("transitionend", function() {
     img.classList.remove("rotate");
    })
    

let angle = 1;

let img2 = document.getElementById("img180_2");    
setInterval(function() 
    {
        img2.style.transform = "rotate("+angle+"deg)";
        angle += 1;
    }, 10);

let pot = 0;
let left =0;
let flag_corner = false;
let k = +1;
let end = 600;
/*setInterval(function()
    { 
        if(pot != end)
        {
            pot += k*5;
            img2.style.top = pot+"px";
        }
        else if(left != end)
        {
            left += k*5;
            img2.style.left = left+"px";
        }
        if(pot == end && left == end)
        {
            k = -1; end = 0;
        }
        if(pot == end && left == end)
        {
            end = 150;
            k = 1;
        } 
    }, 50);*/
let inter = setInterval(function()
    { 
        if(pot != end)
        {
            pot += k*5;
            left = (Math.sqrt(90000-(pot-300)**2)+300);
            if(k == -1) left = -(Math.sqrt(90000-(300-pot)**2)-300);
            img2.style.left = left+"px";
            img2.style.top = pot+"px";
        }
        if(pot == end)
        {
            end==600? end=0:end=600;
            k==1? k=-1:k=1;
            console.log(k);
        } 
    }, 25);






















    