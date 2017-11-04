//一键删除
$(".newlist1 input").keyup(function () {
    
    if ($(this).val().length > 1) {
        $(this).parent().find("img").fadeIn(0)
    }
})
$(".newlist1 img").tap(function () {
    $(this).parent().find("input").val("");
    $(this).fadeOut(100)
})
$(".newlist1 input").blur(function () {
    $(this).parent().find("img").fadeOut(100)
})

//键盘遮挡
$("#txt_BankAccount").focus(function () {
    $("form").css("margin-top","-.5rem")
}).blur(function () {
    $("form").css("margin-top", "0")
})
//无内容隐藏
$(".dlist textarea").each(function () {
   
    if ($(this).val()=="") {
        $(this).closest("li").remove()
    }
})




