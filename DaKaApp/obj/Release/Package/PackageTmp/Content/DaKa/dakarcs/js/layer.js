
//弹框组件
function pops(opt){
    var speed = 1;
    var otime=opt.time||5;
    var timer = null;
    var alpha=0;
    var target=100;
    var flag=true;
    var fade=opt.fade
    tips.style.display="block";
    var Style={
        style1:function(){
            clearInterval(timer);
            timer = setInterval(function(){
                if((target >= alpha)&&flag){
                    if(alpha==target){
                        flag=false;
                    }
                    speed = 5;
                }
                if(!flag){
                    speed = -1;
                    if(alpha==0){
                        speed=0
                        clearInterval(timer)
                        tips.style.display="none";
                    }
                }
                alpha = alpha + speed;
                tips.style.filter = 'alpha(opacity='+alpha+')';
                tips.style.opacity = alpha/100;
            },20)
        },
        style2:function(){
            clearInterval(timer);
            timer = setInterval(function(){
                speed = 5;
                if(alpha==100){
                    speed=0
                    clearInterval(timer)
                }
                alpha = alpha + speed;
                tips.style.filter = 'alpha(opacity='+alpha+')';
                tips.style.opacity = alpha/100;
                6
            },20)
        },
        style3:function(){
            clearInterval(timer);
            timer = setInterval(function(){
                speed = -10;
                if(alpha==0){
                    speed=0
                    clearInterval(timer)
                    tips.style.display="none";
                }
                alpha = alpha + speed;
                tips.style.filter = 'alpha(opacity='+alpha+')';
                tips.style.opacity = alpha/100;
            },20)
        }
    }
    //确认是否有相关按钮
    var Html=opt.html||"";
    var Close=opt.close||false;
    var Cancel=opt.cancelBtn||false;
    var Confirm=opt.conformBtn||false;
    var content="";
    if(Close){
        //console.log(1)
        content+="<div id='cBtn'>×</div>"
    }
    content+="<p>"+Html+"</p>";
    if(Cancel){
        //console.log(2)
        content+="<div id='cancelBtn'>取消</div>"
    }
    if(Confirm){
        content+="<div id='conBtn'>确认</div>"
    }
    mytip.innerHTML=content;
    var cBtn=document.getElementById("cBtn")?document.getElementById("cBtn"):0;
    var cancelBtn=document.getElementById("cancelBtn")?document.getElementById("cancelBtn"):0;
    var conBtn=document.getElementById("conBtn")?document.getElementById("conBtn"):0;
    //console.log(cBtn,cancelBtn,conBtn)
    //让按钮居中显示及弹框如何出现

    if(cancelBtn==0&&conBtn!=0){
        conBtn.style.margin="auto";
    }
    if(conBtn==0&&cancelBtn!=0){
        cancelBtn.style.margin="auto";
    }
    if(cancelBtn!=0&&conBtn!=0){
        //console.log(1)
        cancelBtn.style.float="left";
    }
    if(cancelBtn==0&&conBtn==0&&cBtn==0&&!fade){
        Style.style2()
    }else if(cancelBtn==0&&conBtn==0&&cBtn==0){
        Style.style1()
    }else{
        Style.style2()
        if(cBtn){
            cBtn.onclick=function(){
                Style.style3()
            }
            closeBtn1.onclick=function(){
                Style.style3()
            }
        }
        if(cancelBtn){
             cancelBtn.onclick=function(){
                Style.style3()
            }
        }
        if(conBtn){
            conBtn.onclick=function(){
                Style.style3()
            }
        }
    }

}

//rem自适应
(function(win) {
        var doc = win.document;
        var docEl = doc.documentElement;
        var tid;
        function refreshRem() {
                var width = docEl.getBoundingClientRect().width;
                if (width > 750) { // 最大宽度
                        width =750;
                }
                var rem = width / 10; // 将屏幕宽度分成10份， 1份为1rem
                docEl.style.fontSize = rem + 'px';
                ///rem用font-size:75px来进行换算
        }
        win.addEventListener('resize', function() {
                clearTimeout(tid);
                tid = setTimeout(refreshRem, 1);
        }, false);
        win.addEventListener('pageshow', function(e) {
                if (e.persisted) {
                        clearTimeout(tid);
                        tid = setTimeout(refreshRem, 1);
                }
        }, false);
        refreshRem();
})(window);




