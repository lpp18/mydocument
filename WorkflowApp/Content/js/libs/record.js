﻿var record = {
    isshow:0,
    init: function (mySwiper2) {
        this.tabcord()
        this.onload(mySwiper2)
    },
    tabcord: function () {

        $(document).on("click", ".list-group-item", function () {
            var a = $(this).closest(".swiper-wrapper").find($(this).parent()).index()
            var index = $(this).closest(".swiper-wrapper").attr("class").split(" ")[1];
            sessionStorage.setItem(index,a)
        })
        $(".tab .otab").on("click", function () {
            var a = $(this).index()
            var index = $(".swiper-container2").children("div").attr("class").split(" ")[1];
            sessionStorage.setItem(index, a)
        })
    },
    onload: function (mySwiper2) {
            var olist = $("#olist").attr("class").split(" ")[1]
            var index = sessionStorage.getItem(olist);
            console.log(index)
            this.isshow = index;
           // alert(index)
            if (typeof index == "string") {

                $(".tab a").removeClass("active")
                $(".tab a").eq(index).addClass("active")
                $("."+olist+"div").removeClass("swiper-slide-active")
                $("."+olist).children("div").eq(index).addClass("swiper-slide-active")
                mySwiper2.slideTo(index, 0, false)
                $('.swiper-container2 .swiper-slide-active').css('height', 'auto').siblings('.swiper-slide').css('height', '0px');
                mySwiper2.update();
            }
    }
        
}


