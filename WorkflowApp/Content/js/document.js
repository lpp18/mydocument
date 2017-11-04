requirejs.config({  
    baseUrl: '../Content/js/libs',  
    shim:{  
        "swiper.jquery.min":{  
              deps:["jquery"],  
              exports: 'Swiper'  
        },
        "my_document":{
        	deps:["jquery","layer"],  
            exports: 'myDocument'
        }
    }  
});  
  
  
require(["jquery","layer","swiper.jquery.min","my_document"], function($,layer,Swiper,myDocument) {  
    $(function () {
        myDocument.init();
        $(".swiper-wrapper").children("div:not(:first)").fadeOut(0)
        $(".nav_tab li").on("click", function () {
          
            $(".nav_tab li").removeClass("active")
            $(this).addClass("active")
            var index = $(this).index();
            $(".swiper-wrapper").children("div").fadeOut(100)
            $(".swiper-wrapper").children("div").eq(index).fadeIn(100);
        })
       
       
    })
    //$(function () {
      
  
    //	var mySwiper = new Swiper('.swiper-container', {
    //	    freeMode: false,
    //	    resistanceRatio: 0.3,
    //	    touchRatio: 0.4,
    //        onSlideChangeEnd: function (swiper) {
    //            var j = mySwiper.activeIndex;
    //            console.log(myDocument.isfade)
    //            if (myDocument.isfade) {
    //                console.log(11)
    //                if (j != 0) {
    //                    $(".mydocument_infor_btn").fadeOut(0)
    //                } else if ($(".tab-content-1").scrollTop() <= 50) {
    //                    $(".mydocument_infor_btn").fadeIn(100)
    //                }
    //            } 
                
    //            $('.maple-tab li, .maple-tab2 li').removeClass('active').eq(j).addClass('active');
    //        }
    //    })
    //    /*列表切换*/
    //    $('.maple-tab li, .maple-tab2 li').on('click', function (e) {
    //        e.preventDefault();
    //        //得到当前索引
    //        var i = $(this).index();
    //        if (myDocument.isfade) {
    //            if (i != 0) {
    //                $(".mydocument_infor_btn").fadeOut(0)
    //            } else if ($(".tab-content-1").scrollTop() <= 50) {
    //                $(".mydocument_infor_btn").fadeIn(100)
    //            }
    //        }
           
    //        $('.maple-tab li, .maple-tab2 li').removeClass('active').eq(i).addClass('active');
    //        mySwiper.slideTo(i,500,false);
    //    });
    //});
    
   
    
});