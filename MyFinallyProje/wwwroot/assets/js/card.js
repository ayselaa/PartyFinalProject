searchForm = document.querySelector('.search-form');

//document.querySelector('#search-btn').onclick = () =>{
//  searchForm.classList.toggle('active');
//}



window.onscroll = () =>{

  searchForm.classList.remove('active');

  if(window.scrollY > 80){
    document.querySelector('.header .header-2').classList.add('active');
  }else{
    document.querySelector('.header .header-2').classList.remove('active');
  }

}

window.onload = () =>{

  if(window.scrollY > 80){
    document.querySelector('.header .header-2').classList.add('active');
  }else{
    document.querySelector('.header .header-2').classList.remove('active');
  }

  fadeOut();

}

function loader(){
  document.querySelector('.loader-container').classList.add('active');
}

function fadeOut(){
  setTimeout(loader, 2000);
}

var myInp = document.querySelectorAll(".inp-num .inp-value");
  var increaseBtn = document.querySelectorAll(".inp-num .up");
  var decreaseBtn = document.querySelectorAll(".inp-num .down");
  for(let elem of decreaseBtn){
    
    elem.addEventListener("click",function(e){
      e.preventDefault()
      countst=this.nextElementSibling.innerText
      countstn=Number(countst)

      if(countstn > 1){
        count=this.nextElementSibling.innerText
      countn=Number(count)
       countn-=1;
      this.nextElementSibling.innerText=countn;
      }
    })
  }
  for(let elem of increaseBtn){
    
    elem.addEventListener("click",function(e){
      e.preventDefault()
      count=this.previousElementSibling.innerText
      countn=Number(count)
       countn+=1;
      this.previousElementSibling.innerText=countn;
      
      
    })
  }
  

    function openNav() {
      document.getElementById("mySidenav").style.width = "400px";
    }
    
    function closeNav() {
      document.getElementById("mySidenav").style.width = "0";
}


toastr.options = {
    "closeButton": true,
    "debug": false,
    "newestOnTop": false,
    "progressBar": false,
    "positionClass": "toast-top-center",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "25",
    "hideDuration": "1000",
    "timeOut": "5000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
}

//$(document).ready(function () {

//    $(document).on("click", ".addtobasket", function (e) {
//        e.preventDefault();

//        let url = (this).attr("href");
//      /*  let quantity = $(".quantity").val();*/

//        fetch(url).then(res => {

//            console.log(res.json())

//            alert("Sebete elave olundu")
//        })

//    })
//})

const addBasketBtn = document.querySelectorAll(".addtobasket");

for (var i = 0; i < addBasketBtn.length; i++)
{
    addBasketBtn[i].addEventListener('click', async function () {
        const id = this.nextElementSibling.value;
        const request = await fetch(`/shop/addtobasket/${id}`, {
            method: "POST"
        })
        toastr.warning("Product added to cart!");
    });
}