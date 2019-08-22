// $(".btnParent").on("click", function(){
//     $(this).next(".target").slideUp()
//      $(this).next(".target").slideDown(300);   
//   })

$(function() {
  $('.btnParent').click(function(){
    var incomeDiv = $(this).next('div');
    $(incomeDiv).toggle();        
    $('div[id^=target]').not(incomeDiv).hide();
 });
});





  $(".btnPro").on("click",function(){
    $(this).parents(".group").find("div[data-foldable-role='target']").slideUp(300);
      $(this).parents(".group").next().find("div[data-foldable-role='target']").slideDown(300);
  })