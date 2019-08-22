$(window).on("load",function(){
    $(".loadingAnima").hide()
})

var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
  acc[i].addEventListener("click", function() {
    this.classList.toggle("active");
    var panel = this.nextElementSibling;
    if (panel.style.display === "block") {
      panel.style.display = "none";
    } else {
      panel.style.display = "block";
    }
  });
}
$(".two-menu").click(function(){
    $(".menu-vertical").toggleClass("open");
});

/****/
$(window).scroll(function(){
    if ($(window).scrollTop() >= 100) {
        $('.main-nav').addClass('fixed-header');
        $('nav div').addClass('visible-title');
    }
    else {
        $('.main-nav').removeClass('fixed-header');
        $('nav div').removeClass('visible-title');
    }
});