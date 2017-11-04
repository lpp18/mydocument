/**
 * Created by wuzhenjie on 2017/9/26 0026.
 */

var myDocument = {
    isfade:true,
    init: function(){
        myDocument.mydocument_infor.listener();
    },
    mydocument_infor: {
        listener: function(){
            $(document).on('touchend','.mydocument_infor_btn',function(e){
                e.stopPropagation();
                e.preventDefault();
                $(this).hide(200);
                $(".tab-content-1").animate({  
                    scrollTop: $("#footer_do").offset().top  
                }, 400); 
            });
            $(document).on('click','.report_up',function(){
                var _this = this;
                myDocument.mydocument_infor.select(_this);
            });
            $(document).on('click','.ask_advice',function(){
                var _this = this;
                myDocument.mydocument_infor.select(_this);
            });
            $(document).on('click','.transfer_others',function(){
                var _this = this;
                myDocument.mydocument_infor.select(_this);
            });
       
            //当页面高度达到一定高度时出现底部处理按钮
     
             if ($(".mydocument_infor_footer").length) {
                 if ($("body").height() - $(".mydocument_infor_deal")[0].offsetTop < 50) {
                     console.log(50)
                                 var isscroll = true;
                            $(".tab-content-1").scroll(function(){
                                if (isscroll) {
                                   // console.log(2222)
                                    $(".mydocument_infor_btn").fadeIn(100)
                                }
                                isscroll = false;
                            })

                            $(".tab-content-1").scroll(function(){

                //		    	setInterval(function(){
                //		    		console.log(1)
                //		    		$(".mydocument_infor_btn").css("bottom",0)
                //		    	},30)
                                //console.log($(".mydocument_infor").height() - $(".swiper-wrapper").height())
		    	                if($(this).scrollTop()==0){
		    		
		    	                    $(".mydocument_infor_btn").fadeIn(100)
                    
		    	                } else if ($(this).scrollTop() >= $(".mydocument_infor").height() - $(".swiper-wrapper").height() - 50) {
		    	                    //console.log(111)
		    	                    //console.log($(this).scrollTop(), $(".swiper-wrapper").height())
		    		                $(".mydocument_infor_btn").fadeOut(100)
		    	                }
		    	
		                    })
                 } else {
              
                    myDocument.isfade = false;
                    
                 }
             }

            //图片放大
             var start = true;
             var astart = true;
             $("#DocumentBody img").on("click", function () {
                 if (start && astart) {
                     $(this).css("width", "150%")
                     start = false;
                 }
                 else if (!start && astart) {
                     $(this).css("width", "200%")
                     astart = false;
                 } else {
                     $(this).css("width", "100%")
                     start = true;
                     astart = true;
                 }

             });

             var u = navigator.userAgent;
             var isAndroid = u.indexOf('Android') > -1 || u.indexOf('Adr') > -1; //android终端
             var isiOS = !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/); //ios终端
            //输入框遮挡
             //if (isAndroid) {
                 $("textarea").on("click", function () {
                     console.log(1111)
                     $(".areawrap").fadeIn(0)
                     $(this).css({ "position":"fixed","top": "5rem", "z-index": 10001 })
                     
                 })
                 $(".areawrap").on("click", function () {
                     $(this).fadeOut(100)
                     $("textarea").css({ "position":"absolute","top": "initial", "z-index": 0 })
                 })
                     //$(document).on('click', "body", function (e) {
                     //    var e = e || window.event; //浏览器兼容性
                     //    var elem = e.target || e.srcElement;
                     //    while (elem) { //循环判断至跟节点，防止点击的是div子元素
                     //        if (elem.id && elem.id == 'ApprovalOpinion') {
                     //            return;
                     //        }
                     //        elem = elem.parentNode;
                     //    }
                     //    $("textarea").css({ "margin-top": 0, "z-index": 0 })
                     //    $(".areawrap").fadeOut(100)
                     //    ; //点击的不是div或其子元素
                     //});
            // }
            
           
        },
        select:function(_this){//选中事件
            if($(_this).attr('checked')){
                $(_this).removeAttr('checked');
                console.log("移除")
            }else {
                $(_this).attr('checked',true);
                console.log("选中")
            }
        }

    }
}