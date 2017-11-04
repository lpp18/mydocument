requirejs.config({  
    baseUrl: '../js/libs',
    shim:{  
        "swiper.jquery.min":{  
              deps:["jquery"],  
              exports: 'Swiper'  
        }
       }
});  
  
  
require(["jquery","layer","swiper.jquery.min"], function($,layer,Swiper) { 
  $(function () {
      var mySwiper = new Swiper('.swiper-container', {
          resistanceRatio: 0.3,
          freeMode: false,
            onSlideChangeEnd: function (swiper) {
                var j=mySwiper.activeIndex;
                $('.maple-tab li, .maple-tab2 li').removeClass('active').eq(j).addClass('active');
            }
        })
        /*列表切换*/
        $('.maple-tab li, .maple-tab2 li').on('click', function (e) {
            e.preventDefault();
            //得到当前索引
            var i=$(this).index();
            $('.maple-tab li, .maple-tab2 li').removeClass('active').eq(i).addClass('active');
            mySwiper.slideTo(i,500,false);
        });
    });
})