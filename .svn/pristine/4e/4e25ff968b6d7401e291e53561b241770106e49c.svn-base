var GaoDeAddress = "";//定位地址


$(function () {
    selecDakaJlu();
    rcsOptimizeReady();
})
var timer6 = null;
var nss = 0;
timer6 = setInterval(function () {
    if (nss == 3) {
        clearInterval(timer6)
        document.getElementById("spinwrap").style.zIndex = -1;
    }
    nss++
}, 1000)


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
var street;
var timer5 = null;
var ns = 0;
var mylatitude, mylongitude;

//获取GPS坐标
function getLocation(param) {
    var param = JSON.parse(param);
    mylatitude = param.latitude;
    mylongitude = param.longitude;

    //getaddr()
    //调用高德定位
    ShowGaoDeMap(mylongitude, mylatitude);
}
//获取GPS坐标
function getLocationBrows(p) {
    ShowGaoDeMap(p.coords.longitude, p.coords.latitude);
    //alert("1经度：" + p.coords.longitude + "纬度：" + p.coords.latitude);
}

function getDate(backId, dateStr) {
    alert(backId + '_' + dateStr)
}
function sendmsg(backId, status) {
    alert(backId + '_' + status);
}
function getgroup(backId, status, groupArrai) {
    alert('group:' + backId + '_' + status);
}
function relocate() {
    rcsOptimizeReady()
}
//获取定位参数
function rcsOptimizeReady() {
    try {
        //获取RCS 定位 经纬度
        if (window.WebContainer) {
            window.WebContainer.rcsGetCurrentLocation("{ 'backId': 'aspire', 'backFunc': 'getLocation' }");
        }
            //获取浏览器定位 经纬度
        else if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(getLocationBrows);
        }
        else {
            alert("navigator，window.WebContainer Is null");
        }

    }
    catch (error) {
        alert(error);
    }

}


var reloca = document.getElementById("relocate");
reloca.onclick = function () {
    window.location.reload()
};



//获取当前具体时间显示到打卡中
var time = document.getElementById("time");
var timer = null;

timer = setInterval(function () {
    time.innerHTML = sysTime().Time2;
}, 500);
//判断是否应该打卡
var tips = document.getElementById("tips");
var mytip = document.getElementById("mytip");
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

    clearInterval(timer4);
    var ns = 0;
    timer5 = setInterval(function () {
        if (ns == 3) {
            clearInterval(timer5);
            document.getElementById("spinwrap").style.zIndex = -1;
            var succ = '<div><p class="cloimg" id="closeBtn1"><img src="/Content/DaKa/daka/img/close.png"></p><p class="dakasucc">打卡失败,请选择网络较好的地方或在建筑物外打卡！</p></div>';
            pops({
                html: succ,
                close: 1
            });
            clearInterval(timer4)
        }
        if (address.value == "") {
            ns++;
        }
    }, 1000);
    //重新定位
    address.value = "";
    document.getElementById("spinwrap").style.zIndex = 131;
    relocate()
 
    timer4 = setInterval(function () {
        if (!(address.value == "")) {
            clearInterval(timer5);
            var data = {
                time: time.innerHTML,
                address: address.value,
                jingdu: mylatitude,
                weidu: mylongitude
            };
            $.ajax({
                method: 'post',
                url: '/DaKaHome/DaKaRcsA',
                async: true,
                data: data,
                success: function (message) {
                    if (message == "OK:001") {
                        var succ = '<div><p class="cloimg" id="closeBtn1"><img src="/Content/DaKa/daka/img/close.png"></p><p class="dakasucc">打卡成功!</p><button class="dakatime">' + sysTime().Time2 + '</button><p class="locinfo"></p></div>';
                        pops({
                            html: succ,
                            close: 1
                        });
                        var sysID = sysTime().Time1;
                        var sysID3 = sysTime().Time3;
                        var aID = 'recordmar' + sysID;
                        if (document.getElementById(sysID)) {
                            var aID = document.getElementById(aID);

                            aID.innerHTML +=
                                "<div class='backf'>" +
                                "<p class='fl'><img src='/Content/DaKa/daka/img/dot1.png'></p>" +
                                "<p class='dakainfo info1'>" + sysID3 + "</p>" +
                                "<p class='dakainfo info2'>" + address.value + "</p></div>";

                        } else {

                            records.innerHTML += "<div class='recordmar' id='" + aID + "'>" +
                                "<p><span id='" + sysID + "' class='timeBtn'>" + sysID + "</span></p>" +
                                "<div class='backf'><p class='fl'>" +
                                "<img src='/Content/DaKa/daka/img/dot1.png'>" +
                                "</p>" +
                                "<p class='dakainfo info1'>" + sysID3 + "</p>" +
                                "<p class='dakainfo info2'>" + address.value + "</p>" +
                                "</div>";
                        }
                    } else if (message == "OK:002") {
                        var succ = '<div><p class="cloimg" id="closeBtn1"><img src="/Content/DaKa/daka/img/close.png"></p><p class="dakasucc">超出打卡范围,请移动后点击重新定位</p></div>';
                        pops({
                            html: succ,
                            close: 1
                        });
                    } else if (message == "OK:003") {
                        var succ = '<div><p class="cloimg" id="closeBtn1"><img src="/Content/DaKa/daka/img/close.png"></p><p class="dakasucc">您没有权限使用外出打卡功能,如需使用，请向人力资源部申请</p></div>';
                        pops({
                            html: succ,
                            close: 1
                        });
                    } else {
                        var succ = '<div><p class="dakasucc">打卡失败,程序异常。请打开GPS，重新定位后再试！</p><p class="cloimg" id="closeBtn1"><img src="/Content/DaKa/daka/img/close.png"></p></div>';
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
//最新修改

var loimg = locate.getElementsByTagName("img")[0];
var stimg = stat.getElementsByTagName("img")[0];
locate.onclick = function () {
    records.style.display = "none";
    mappage.style.display = "flex";
    locatespan.style.color = "#1f9e83";
    statspan.style.color = "#999";
    loimg.src = "/Content/DaKa/daka/img/locate.png";
    stimg.src = "/Content/DaKa/daka/img/stath.png";
}
stat.onclick = function () {
    records.style.display = "block";
    mappage.style.display = "none";
    statspan.style.color = "#1f9383";
    locatespan.style.color = "#999";
    loimg.src = "/Content/DaKa/daka/img/loacteh.png";
    stimg.src = "/Content/DaKa/daka/img/stat.png";

}


function selecDakaJlu() {
    $.ajax({
        type: 'post',
        url: '/DaKaHome/selectDaKaJiLuRcs',
        cache: false,
        dataType: "json", //返回数据形式为json
        data: '',
        beforeSend: function () { },
        success: function (mes) {
            var len = mes.length < 30 ? mes.length : 30;
            var str = "";
            for (var i = 0; i < len; i++) {
                //var atime = getLocalTime(mes[i].dakashijian.replace("/Date(", "").replace(")/", "")).split(" ");
                //alert(typeof mes[i].dakashijian.replace("/Date(", "").replace(")/", ""))
                var timenum = parseInt(mes[i].dakashijian.replace("/Date(", "").replace(")/", ""))
                var atime = sysTime(timenum)
                var aID = 'recordmar' + atime.Time1;
                if (document.getElementById(atime.Time1)) {
                    var aID = document.getElementById(aID);
                    aID.innerHTML += "<div class='backf'>" +
                        "<p class='fl'><img src='/Content/DaKa/daka/img/dot1.png'></p>" +
                        "<p class='dakainfo info1'>" + atime.Time3 + "</p>" +
                        "<p class='dakainfo info2'>" + mes[i].zwAddress + "</p></div>"
                } else {
                    records.innerHTML += "<div class='recordmar' id='" + aID + "'>" +
                        "<p><span id='" + atime.Time1 + "' class='timeBtn'>" + atime.Time1 + "</span></p>" +
                        "<div class='backf'><p class='fl'>" +
                        "<img src='/Content/DaKa/daka/img/dot1.png'>" +
                        "</p>" +
                        "<p class='dakainfo info1'>" + atime.Time3 + "</p>" +
                        "<p class='dakainfo info2'>" + mes[i].zwAddress + "</p>" +
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

//调用高德定位 ，x：经度，y：纬度
function ShowGaoDeMap(x, y) {

    var map = new AMap.Map('allmap');
    map.setZoom(15);
    map.setCenter([x, y]);

    var marker = new AMap.Marker({
        position: [x, y]
    });
    marker.setMap(map);
    var circle = new AMap.Circle({
        center: [x, y],
        radius: 100,
        fillOpacity: 0.2,
        strokeWeight: 1
    })
    circle.setMap(map);
    map.setFitView();
    //查询地址
    AMap.service('AMap.Geocoder', function () {//回调函数
        //实例化Geocoder
        geocoder = new AMap.Geocoder({
            city: "010"//城市，默认：“全国”
        });
        //TODO: 使用geocoder 对象完成相关功能
        var lnglatXY = [x, y];//地图上所标点的坐标
        geocoder.getAddress(lnglatXY, function (status, result) {
            if (status === 'complete' && result.info === 'OK') {
                //获得了有效的地址信息:
                GaoDeAddress = result.regeocode.formattedAddress;
                document.getElementById("spinwrap").style.zIndex = -1;
                address.value = GaoDeAddress;
                //alert(GaoDeAddress);
                //var info = new AMap.InfoWindow({
                //    //content: GaoDeAddress,
                //    offset: new AMap.Pixel(0, -28)
                //})
                //info.open(map, marker.getPosition())
                //即，result.regeocode.formattedAddress
            } else {
                //获取地址失败
            }
        });
    })

}

