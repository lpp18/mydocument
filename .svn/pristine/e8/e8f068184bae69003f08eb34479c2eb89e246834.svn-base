//判断android和ios
var u = navigator.userAgent;
var isAndroid = u.indexOf('Android') > -1 || u.indexOf('Adr') > -1; //android终端
var isiOS = !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/); //ios终端
$(function () {
    selecDakaJlu();
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
var map = new BMap.Map("allmap");
map.centerAndZoom(new BMap.Point(116.331398, 39.897445), 18);
map.enableScrollWheelZoom(true);

function getLocation(param) {
    var param = JSON.parse(param);
    mylatitude = param.latitude;
    mylongitude = param.longitude;
    getaddr();
}
function getLocationBrowser(p) {
    mylatitude = p.latitude;
    mylongitude = p.longitude;
    getaddr();
}
function getaddr() {
    var url = "";
    if (isAndroid) {
        url = "http://api.map.baidu.com/geoconv/v1/?coords=" + mylatitude + "," + mylongitude + "&from=3&to=5&ak=iUhodcsUKCPdzqmnKnkgZWO7Qk1vhq5b";
        $.ajax({
            type: "get",
            url: url,
            cache: false,
            dataType: "jsonp",
            success: function (data) {
                mylongitude = data.result[0].x;
                mylatitude = data.result[0].y;
                ajaxaddr();
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {

            }
        });
    } else if (isiOS) {
        //url="http://api.map.baidu.com/geoconv/v1/?coords="+mylatitude+","+mylongitude+"&from=3&to=5&ak=iUhodcsUKCPdzqmnKnkgZWO7Qk1vhq5b";
        //url="http://api.map.baidu.com/ag/coord/convert?from=2&to=4&x="+mylongitude+"&y="+mylatitude";
        $.ajax({
            type: "get",
            url: "http://restapi.amap.com/v3/assistant/coordinate/convert?key=841ccc39e327dc1480b5eae3d459c913&locations=" + mylongitude + "," + mylatitude + "&coordsys=gps",
            cache: false,
            datatype: "jsonp",
            success: function (data) {
                var datarr = data.locations.split(",");
                mylongitude = datarr[0];
                mylatitude = datarr[1];
                $.ajax({
                    type: "get",
                    url: "http://api.map.baidu.com/geoconv/v1/?coords=" + mylatitude + "," + mylongitude + "&from=3&to=5&ak=iUhodcsUKCPdzqmnKnkgZWO7Qk1vhq5b",
                    async: true,
                    dataType: "jsonp",
                    success: function (data) {
                        console.log(data)
                        mylongitude = data.result[0].x;
                        mylatitude = data.result[0].y;
                        ajaxaddr();
                    }
                });
            },
            error: function (data) {
                console.log(data)
            }
        });
       
    }

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

function rcsOptimizeReady() {
    if (window.WebContainer != null) {
        if (window.WebContainer.rcsGetCurrentLocation == null) {
            //alert('rcsGetCurrentLocation is null');
        }
        //获取浏览器定位 经纬度
        else  if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(getLocationBrowser);
        }
        else {

            try {
                window.WebContainer.rcsGetCurrentLocation("{ 'backId': 'aspire', 'backFunc': 'getLocation' }");
                navigator.geolocation.getCurrentPosition
            }
            catch (error) {
                alert(error);
            }
        }
        
    }
    else {
        try {
            navigator.WebContainer.rcsGetCurrentLocation("{ \"backId\": \"aspire\", \"backFunc\": \"getLocation\" }");

        }
        catch (error) {
            navigator.geolocation.getCurrentPosition(getLocationBrowser);
            //alert(error);
        }
    }
   
}
var reloca = document.getElementById("relocate");
reloca.onclick = function () {
    window.location.reload();
};
//地址解析函数
function ajaxaddr() {
    $.ajax({
        type: "get",
        url: "http://api.map.baidu.com/geocoder/v2/?callback=renderReverse&location=" + mylongitude + "," + mylatitude + "&output=json&pois=1&ak=iUhodcsUKCPdzqmnKnkgZWO7Qk1vhq5b",
        async: true,
        cache: false,
        dataType: "jsonp",
        success: function (data) {
            var data1 = data.result.addressComponent;
            var data2 = data.result.pois[0].addr;
            //var addr=data1.city+data1.district+data1.street+data1.street_number;
            var addr = data1.city + data1.district + data2;
            address.value = addr;
            document.getElementById("spinwrap").style.zIndex = -1;
        }, error: function () {
            alert("error")
        }
    });
    // 用经纬度设置地图中心点
    map.clearOverlays();
    var new_point = new BMap.Point(mylatitude, mylongitude);
    var marker = new BMap.Marker(new_point);  // 创建标注
    map.addOverlay(marker);              // 将标注添加到地图中
    map.panTo(new_point);
}
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
            var succ = '<div><p class="cloimg" id="closeBtn1"><img src="../Content/DaKa/daka/img/close.png"></p><p class="dakasucc">打卡失败,请选择网络较好的地方或在建筑物外打卡！</p></div>';
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
    // clearInterval(timer1)
    // clearInterval(timer2)
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
                url: '../DaKaHome/DaKaRcsA',
                async: true,
                data: data,
                success: function (message) {
                    if (message == "OK:001") {
                        var succ = '<div><p class="cloimg" id="closeBtn1"><img src="../Content/DaKa/daka/img/close.png"></p><p class="dakasucc">打卡成功!</p><button class="dakatime">' + sysTime().Time2 + '</button><p class="locinfo"></p></div>';
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
                                "<p class='fl'><img src='../Content/DaKa/daka/img/dot1.png'></p>" +
                                "<p class='dakainfo info1'>" + sysID3 + "</p>" +
                                "<p class='dakainfo info2'>" + address.value + "</p></div>";

                        } else {

                            records.innerHTML += "<div class='recordmar' id='" + aID + "'>" +
                                "<p><span id='" + sysID + "' class='timeBtn'>" + sysID + "</span></p>" +
                                "<div class='backf'><p class='fl'>" +
                                "<img src='../Content/DaKa/daka/img/dot1.png'>" +
                                "</p>" +
                                "<p class='dakainfo info1'>" + sysID3 + "</p>" +
                                "<p class='dakainfo info2'>" + address.value + "</p>" +
                                "</div>";
                        }
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
//最新修改

var loimg = locate.getElementsByTagName("img")[0];
var stimg = stat.getElementsByTagName("img")[0];
locate.onclick = function () {
    records.style.display = "none";
    mappage.style.display = "flex";
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
    loimg.src = "../Content/DaKa/daka/img/loacteh.png";
    stimg.src = "../Content/DaKa/daka/img/stat.png";

}


function selecDakaJlu() {
    $.ajax({
        type: 'post',
        url: '../DaKaHome/selectDaKaJiLuRcs',
        cache: false,
        dataType: "json", //返回数据形式为json
        data: '',
        beforeSend: function () { },
        success: function (mes) {
            var len = mes.length < 30 ? mes.length : 30;
            var str = "";
            for (var i = 0; i < len; i++) {
                var timenum = parseInt(mes[i].dakashijian.replace("/Date(", "").replace(")/", ""))
                var atime = sysTime(timenum)
                var aID = 'recordmar' + atime.Time1;
                if (document.getElementById(atime.Time1)) {
                    var aID = document.getElementById(aID);
                    aID.innerHTML += "<div class='backf'>" +
                        "<p class='fl'><img src='../Content/DaKa/daka/img/dot1.png'></p>" +
                        "<p class='dakainfo info1'>" + atime.Time3 + "</p>" +
                        "<p class='dakainfo info2'>" + mes[i].zwAddress + "</p></div>"
                } else {
                    records.innerHTML += "<div class='recordmar' id='" + aID + "'>" +
                        "<p><span id='" + atime.Time1 + "' class='timeBtn'>" + atime.Time1 + "</span></p>" +
                        "<div class='backf'><p class='fl'>" +
                        "<img src='../Content/DaKa/daka/img/dot1.png'>" +
                        "</p>" +
                        "<p class='dakainfo info1'>" + atime.Time3 + "</p>" +
                        "<p class='dakainfo info2'>" + mes[i].zwAddress + "</p>" +
                        "</div>";
                }
            }

        },
        error: function () {

        }
    });
}

function getLocalTime(nS) {
    return new Date(parseInt(nS)).toLocaleString();
}



