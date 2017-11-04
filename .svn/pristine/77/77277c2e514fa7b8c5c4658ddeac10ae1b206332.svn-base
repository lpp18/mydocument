
var timer6 = null;
var nss = 0;
timer6 = setInterval(function () {
    if (nss == 3) {
        clearInterval(timer6)
        document.getElementById("spinwrap").style.zIndex = -1;
    }
    nss++

}, 1000)
$(function () {
    selecDakaJlu();
})

//获取系统时间
function sysTime() {
    var ftime = function getServerDate() {
        return new Date($.ajax({ async: false }).getResponseHeader("Date"));
    }()
    ftime = Date.parse(ftime)
    var ctime = arguments[0] ? arguments[0] : ftime;
    ctime = new Date(ctime)
    var year = ctime.getFullYear();
    var month = ctime.getMonth() + 1;
    var day = ctime.getDate();
    var hour = ctime.getHours() < 10 ? "0" + ctime.getHours() : ctime.getHours(); //获取系统时，
    var minu = ctime.getMinutes() < 10 ? "0" + ctime.getMinutes() : ctime.getMinutes() //分
    var sec = ctime.getSeconds() < 10 ? "0" + ctime.getSeconds() : ctime.getSeconds();
    var week = ctime.getDay();
    var moon = "";
    if (hour < 12) {
        moon = "上午"
    } else {
        moon = "下午"
    }
    var weekday = new Array(7);
    weekday[0] = "星期天";
    weekday[1] = "星期一";
    weekday[2] = "星期二";
    weekday[3] = "星期三";
    weekday[4] = "星期四";
    weekday[5] = "星期五";
    weekday[6] = "星期六";
    var Time = weekday[week] + "&nbsp;" + year + '.' + month + '.' + day
    var Time1 = year + '/' + month + '/' + day;
    var Time2 = hour + ":" + minu + ":" + sec;
    var Time3 = moon + Time2;
    return {
        Time: Time,
        Time1: Time1,
        Time2: Time2,
        Time3: Time3
    }
}
var tday = document.getElementById("tday");
tday.innerHTML = sysTime().Time;
// 百度地图API功能
var mylatitude, mylongitude;
var street;
var timer5 = null;
var ns = 0;
function relocate() {
    var As = document.getElementById("as");
    var address = document.getElementById("address");
    var map = new BMap.Map("allmap");
    var point = new BMap.Point(116.30107, 39.828328);
    map.centerAndZoom(point, 15);
    var opts = { offset: new BMap.Size(10, 90) }
    map.addControl(new BMap.GeolocationControl(opts));
    var geolocation = "geolocation" + Math.random(10).toFixed(2);
    var geolocation = new BMap.Geolocation();
    geolocation.getCurrentPosition(function (r) {
        if (this.getStatus() == BMAP_STATUS_SUCCESS) {
            var mk = new BMap.Marker(r.point);
            map.addOverlay(mk);
            map.panTo(r.point);
            mylatitude = r.point.lat;
            mylongitude = r.point.lng;
            point = new BMap.Point(mylongitude, mylatitude);
            map.centerAndZoom(point, 16);
            As.value = mylatitude + ',' + mylongitude;
            // 百度地图API功能
            var gc = new BMap.Geocoder();
            gc.getLocation(point, function (rs) {
                // alert(rs.sematic_description);
                var addComp = rs.addressComponents;
                var addpois = rs.surroundingPois;
                var mapAddress = addComp.city + addComp.district
                    + addpois[0].address;
                console.log(addComp)
                address.value = mapAddress;
                street = addComp.street;
                document.getElementById("spinwrap").style.zIndex = -1;
            });
        }
        else {
            alert('failed' + this.getStatus());
        }
    },
        { enableHighAccuracy: true })
}
relocate();
var reloca = document.getElementById("relocate");
reloca.onclick = function () {
    window.location.reload()
}

//获取当前具体时间显示到打卡中
var time = document.getElementById("time")
var timer = null;
timer = setInterval(function () {
    time.innerHTML = sysTime().Time2;
}, 1000)
//判断是否应该打卡
var tips = document.getElementById("tips")
var mytip = document.getElementById("mytip")
var record = document.getElementById("record");
var up = document.getElementById("up");
var down = document.getElementById("down");
var card = document.getElementById("card");
var locate = document.getElementById("locate");
var stat = document.getElementById("stat");
var records = document.getElementById("records");
var cont = document.getElementById("cont");


//最新修改
var vtime = document.getElementById("vtime");
var timer1 = null;
var timer2 = null;
var flag = true;
var n = 10;
var timer4 = null;
var timer5 = null;

record.onclick = function () {

    clearInterval(timer4)
    var ns = 0;
    timer5 = setInterval(function () {
        if (ns == 5) {
            clearInterval(timer5)
            document.getElementById("spinwrap").style.zIndex = -1;
            var succ = '<div><p class="cloimg" id="closeBtn1"><img src="../Content/DaKa/daka/img/close.png"></p><p class="dakasucc">打卡失败,请稍后重试！</p></div>';
            pops({
                html: succ,
                close: 1
            });
            clearInterval(timer4)
        }
        if (address.value == "") {
            ns++;
        }
    }, 1000)
    //重新定位
    address.value = "";
    document.getElementById("spinwrap").style.zIndex = 131;
    relocate()
    // clearInterval(timer1)
    // clearInterval(timer2)
    timer4 = setInterval(function () {
        if (!(address.value == "")) {
            clearInterval(timer5);
            var data = {
                time: time.innerHTML,
                address: address.value,
                jingdu: mylongitude,
                weidu: mylatitude
            }
            
            $.ajax({
                method: 'post',
                url: '../DaKaHome/DaKa',
                async: true,
                data: data,
                success: function (message) {
                    if (message == "OK:001") {
                        var succ = '<div><p class="cloimg" id="closeBtn1"><img src="../Content/DaKa/daka/img/close.png"></p><p class="dakasucc">打卡成功!</p><button class="dakatime">' + sysTime().Time2 + '</button></div>';
                        pops({
                            html: succ,
                            close: 1
                        });

                    } else if (message == "OK:002") {
                        var succ = '<div><p class="cloimg" id="closeBtn1"><img src="../Content/DaKa/daka/img/close.png"></p><p class="dakasucc">超出打卡范围,请移动后点击重新定位</p></div>';
                        pops({
                            html: succ,
                            close: 1
                        });
                    } else if (message == "OK:003") {
                        var succ = '<div><p class="cloimg" id="closeBtn1"><img src="../Content/DaKa/daka/img/close.png"></p><p class="dakasucc">您没有权限使用外出打卡功能,如需使用，请向人力资源部申请</p></div>';
                        pops({
                            html: succ,
                            close: 1
                        });
                    } else {
                        var succ = '<div><p class="dakasucc">打卡失败,程序异常。请打开GPS，重新定位后再试！</p><p class="cloimg" id="closeBtn1"><img src="../Content/DaKa/daka/img/close.png"></p></div>';
                        pops({
                            html: succ,
                            close: 1
                        });
                    }
                }
            })
            clearInterval(timer4)
        }
    }, 10)
}


var loimg = locate.getElementsByTagName("img")[0];
var stimg = stat.getElementsByTagName("img")[0];
locate.onclick = function () {
    records.style.display = "none";
    mappage.style.display = "block";
    locatespan.style.color = "#1f9e83";
    statspan.style.color = "#999";
    loimg.src = "../Content/DaKa/daka/img/locate.png";
    stimg.src = "../Content/DaKa/daka/img/stath.png";
}
stat.onclick = function () {
    records.style.display = "block";
    mappage.style.display = "none";
    statspan.style.color = "#1f9383";
    locatespan.style.color = "#999";
    loimg.src = '../Content/DaKa/daka/img/loacteh.png';
    stimg.src = '../Content/DaKa/daka/img/stat.png';

}


function selecDakaJlu() {
    $.ajax({
        type: 'post',
        url: '../DaKaHome/selectDaKaJiLu',
        cache: false,
        dataType: "json", //返回数据形式为json
        data: '',
        beforeSend: function () { },
        success: function (mes) {
            var len = mes.length < 30 ? mes.length : 30;
            var str = "";
            for (var i = 0; i < len; i++) {
                //console.log(getLocalTime(mes[i].dakashijian.replace("/Date(", "").replace(")/", "")))
                //var atime = getLocalTime(mes[i].dakashijian.replace("/Date(", "").replace(")/", "")).split(" ");
                //console.log(atime[0])
                var timenum = parseInt(mes[i].dakashijian.replace("/Date(", "").replace(")/", ""))
                var atime = sysTime(timenum)
                var aID = 'recordmar' + atime.Time1;
                if (document.getElementById(atime.Time1)) {
                    var aID = document.getElementById(aID);
                    aID.innerHTML += "<div class='backf'><p class='fl'>" +
                        "<img src='../Content/DaKa/daka/img/dot1.png'>" +
                        "</p>" +
                        "<p class='dakainfo'><span>" + atime.Time3 + "</span>" +
                        "<span>" + mes[i].zwAddress + "</span></p></div>"
                } else {
                    console.log(22)

                    records.innerHTML += "<div class='recordmar' id='" + aID + "'>" +
                        "<p><span id='" + atime.Time1 + "' class='timeBtn'>" + atime.Time1 + "</span></p>" +
                        "<div class='backf'><p class='fl'>" +
                        "<img src='../Content/DaKa/daka/img/dot1.png'>" +
                        "</p>" +
                        "<p class='dakainfo'><span>" + atime.Time3 + "</span>" +
                        "<span>" + mes[i].zwAddress + "</span></p>" +
                        "</div>";
                }
            }

            //         str += "<div style=\"width:95%;height:60px;margin:0px auto;border:1px solid #0026ff;margin-top:10px\">";
            //        str += "<div style=\"width:100%;height:30px;float:left;border-bottom:1px solid #0094ff\">";
            //        str += "<p>" +getLocalTime(mes[i].dakashijian.replace("/Date(","").replace(")/","")) + "</p></div>";
            //         str += "<div style=\"width:100%;height:30px;float:left;\"> <p>" + mes[i].zwAddress + "</p></div></div>";
            //    };
            //    $("#records").find("div").remove();
            //     $("#records").append(str);
        },
        error: function () {

        }
    });
}

function getLocalTime(nS) {
    return new Date(parseInt(nS)).toLocaleString();
}

