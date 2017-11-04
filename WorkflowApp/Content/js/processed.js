requirejs.config({  
    baseUrl: '../Content/js/libs',  
    shim:{  
        "swiper.jquery.min":{  
              deps:["jquery"],  
              exports: 'Swiper'  
        },
        "record": {
            deps: ["jquery"],
            exports: 'record'
        }
    }  
});  
  
  
require(["jquery","swiper.jquery.min","record"], function($,Swiper,record) {  
    var loadFlag = true;
    var oi = 0;
    var fade1 = true;
	var mySwiper = new Swiper('.swiper-container', {
		direction: 'vertical',
		scrollbar: '.swiper-scrollbar',
		slidesPerView: 'auto',
		mousewheelControl: true,
		freeMode: true,
		onTouchMove: function(swiper){		//手动滑动中触发
			var _viewHeight = document.getElementsByClassName('swiper-wrapper')[0].offsetHeight;
            var _contentHeight = document.getElementsByClassName('swiper-slide')[0].offsetHeight;
            
            
            if(mySwiper.translate < 50 && mySwiper.translate > 0) {
				$(".init-loading").html('下拉刷新...').show();
			}else if(mySwiper.translate > 50 ){
				$(".init-loading").html('释放刷新...').show();
			}
		},
		onTouchEnd: function (swiper) {

		    if (mySwiper2.activeIndex == 1) {//选项卡切换为公文
		        TabPosition = 1; 
		        if (!$("#DocumentInfo").attr("num")) {
		            $("#DocumentInfo").attr("num", 1)
		            if (!$("#DocumentInfo .list-group-item").length && fade1) {
		                $(".spinner-wrap").fadeIn(100);
		                setInterval(function () {
		                    if ($("#DocumentInfo .list-group-item").length) {
		                        $(".spinner-wrap").fadeOut(100);
		                    }
		                }, 50)
		            }
		        }

		    };
			var _viewHeight = document.getElementsByClassName('swiper-wrapper')[0].offsetHeight;
            var _contentHeight = document.getElementsByClassName('swiper-slide')[0].offsetHeight;
             // 上拉加载
            if(mySwiper.translate <= _viewHeight - _contentHeight - 50 && mySwiper.translate < 0) {
                // console.log("已经到达底部！");
               
                if(loadFlag){
                	$(".loadtip").html('正在加载...');
                }else{
                	$(".loadtip").html('没有更多啦！');
                }
                if(mySwiper2.activeIndex==0){
                	
                    countIndex1 += 5;
                    WorkflowProcess_Processed(countIndex1);
                }else if(mySwiper2.activeIndex==1){
                	
                    countIndex2 += 5;
                    DocumentProcess_Processed(countIndex2);
                }
              
                   
                     $(".loadtip").html('上拉加载更多...');
                    mySwiper.update(); // 重新计算高度;
               
            }
            
            // 下拉刷新
            if(mySwiper.translate >= 50) {
                $(".init-loading").html('正在刷新...').show();
                $(".loadtip").html('上拉加载更多');
                loadFlag = true;
                WorkflowProcess_Processed(countIndex1);
                DocumentProcess_Processed(countIndex2);
                setTimeout(function() {
                    $(".refreshtip").show(0);
                    $(".init-loading").html('刷新成功！');

                    $(".init-loading").html('').hide(200);
                    $(".loadtip").show(0);
                    
                    //刷新操作
                    mySwiper.update(); // 重新计算高度;
                }, 1000);
            }else if(mySwiper.translate >= 0 && mySwiper.translate < 50){
            	$(".init-loading").html('').hide();
            }
            return false;
		}
	});
	var mySwiper2 = new Swiper('.swiper-container2', {
	    paginationClickable: true,
	    resistanceRatio: 0.3,
	    freeMode: false,
		onTransitionEnd: function(swiper){
			
			$('.w').css('transform', 'translate3d(0px, 0px, 0px)')
			$('.swiper-container2 .swiper-slide-active').css('height','auto').siblings('.swiper-slide').css('height','0px');
			mySwiper.update();
			
			$('.tab a').eq(mySwiper2.activeIndex).addClass('active').siblings('a').removeClass('active');
		}
		
	});
	$('.tab a').click(function(){
		
	    if (mySwiper2.activeIndex == 0) {
	        TabPosition = 1;   //选项卡切换为公文
	        $("#Search").attr("placeholder", "请输入关键字");
	        $("#Search").next().val("");
	        if (!$("#DocumentInfo").attr("num")) {
	            $("#DocumentInfo").attr("num", 1)
	            if (!$("#DocumentInfo .list-group-item").length && fade1) {
	                $(".spinner-wrap").fadeIn(100);
	                setInterval(function () {
	                    if ($("#DocumentInfo .list-group-item").length) {
	                        $(".spinner-wrap").fadeOut(100);
	                    }
	                }, 50)
	            }
	        }
	    };

		$(this).addClass('active').siblings('a').removeClass('active');
		mySwiper2.slideTo($(this).index(), 500, false)
		
		$('.w').css('transform', 'translate3d(0px, 0px, 0px)')
		$('.swiper-container2 .swiper-slide-active').css('height','auto').siblings('.swiper-slide').css('height','0px');
		mySwiper.update();
		
	});

    //首次加载进入原列表
	record.init(mySwiper2)
	
	//$("#Search").on("focus", function () {
	//    //QueryProcessAssemble();
	//    if ($(this).val() == "") {
	//        $(".sfind").show("swing");
	//    }
	//}).on("blur", function () {
	//    $(".sfind").hide("swing");

    //});

	$("#Search").keydown(function (e) {
	    if (e.keyCode == 13) {

	        if ($(this).val() != "") {
	            //$(".sfind").hide("swing");
	            Name = $(this).val();
	            QueryProcessByName(countIndex1, Name);
	            QueryDocumentProcessByName(countIndex2, Name);
	        }
	    }
	    else {
	        WorkflowProcess_Processed(countIndex1);
	        DocumentProcess_Processed(countIndex2);
	    }
	});
	$("#isearch").on("click", function () {
	        if ($("#Search").val() != "") {
	           // $(".sfind").hide("swing");
	            Name = $("#Search").val();
               
	            QueryProcessByName(countIndex1, Name);
	            QueryDocumentProcessByName(countIndex2, Name);
	        } else {
	            WorkflowProcess_Processed(countIndex1);
	            DocumentProcess_Processed(countIndex2);
	        }
	    
	})
	$(".idelete").on("click", function () {
	    $("#Search").val("")
	    WorkflowProcess_Processed(countIndex1);
	    DocumentProcess_Processed(countIndex2);
	})
	//$("#Search").keyup(function () {
	//    if ($(this).val() != "") {
	//        $(".sfind").hide("swing");
	//        Name = $(this).val();
	//        QueryProcessByName(countIndex1, Name);
	//        QueryDocumentProcessByName(countIndex2, Name);
	//    }
	//    //else {
	//    //    $(".sfind").show("swing");
	//    //}
	//});
	var Name = "";  //搜索名称
	var page = 1;
	var countIndex1 = 10;  //每页加载数量
	var countIndex2 = 10;
	$(function () {

	    WorkflowProcess_Processed(countIndex1);
	    DocumentProcess_Processed(countIndex2);
	    

	});

	var TotalCount = 0;
    //加载流程信息
	function WorkflowProcess_Processed(count) {
	    $.ajax({
	        type: 'post',
	        url: '../Home/WorkflowProcess_Processed',
	        cache: false,
	        dataType: "json",
	        data: {
	            page: page,
	            count: count
	        },
	        success: function (mes) {
	            var HtmlStr = "";
	            if (mes.length == 0) {
	                HtmlStr += "<div class=\"nowrap\"><img class=\"tit nodata\" src=\"../content/img/nodata.png\"><p class=\"notext\">暂无数据</p><div>";
	            } else {
	                
	                //流程名称
	                for (var i = 0; i < mes.length; i++) {
	                    try {
	                        //20171010
	                        //去掉字符串回车换行符
	                        //mes[i].ProcessData = mes[i].ProcessData.replace(/[\r\n]/g, "");
	                        //var processDatajson = $.parseJSON(mes[i].ProcessData);
	                        var ModelId = mes[i].ModelId != null ? mes[i].ModelId : "";
	                        var BillNO = mes[i].BillNo.toString();
	                        var Status = mes[i].Status ? "1" : "0";
	                        var ProcessName = GetProcessName(ModelId);  //流程名称
	                        var Applicant = mes[i].BillEmpName != null ? mes[i].BillEmpName : "";  //申请人
	                        var Title = mes[i].BillTitle != null ? mes[i].BillTitle : "";  //标题
	                        var CreateTime = mes[i].BillTime != null ? timeConvert(mes[i].BillTime, false) : "";
	                        HtmlStr += "<div class=\"list-group-item\" onclick=\"ProcessDetails('" + BillNO + "','" + ModelId + "','" + Status + "')\" >  <div>";
	                        HtmlStr += "<p class=\"tit\">" + ProcessName + "-" + Applicant + "</p>";
	                        HtmlStr += "<p class=\"cont\">事项 : " + Title + "</p>";
	                        HtmlStr += "<p class=\"mydate\">提交日期 : " + CreateTime + "</p>";
	                        HtmlStr += "</div><p class=\"arrow\"><img src=\"../Content/img/arrow.png\" /></p></div>";

	                    } catch (e) {
	                        //异常
	                        console.log(e);
	                    }
	                }
	               
	                //TotalCount = mes.length;
	                //MsgAlert("测试使用,待办 流程" + TotalCount + "条", 2);
	            };
	            document.getElementById("DbInfo").innerHTML = HtmlStr;
	            mySwiper.update()
	            $(".spinner-wrap").fadeOut(100)
	        }
	    });
	};
    //根据
	function GetProcessName(ModelId) {
	    var ProcessName = "";
	    var url = "";
	    switch (ModelId) {
	        case "38926":
	            ProcessName = "发票申请";
	            url = "";
	            break;
	        case "7281":
	            ProcessName = "报销申请";
	            url = "";
	            break;
	        case "332373":
	            ProcessName = "印章申请";
	            break;
	        case "7559":
	            ProcessName = "请假申请";
	            break;
	        case "183443":
	            ProcessName = "外出申请";
	            break;
	        case "181382":
	            ProcessName = "考勤申请";
	            break;
	        case "7575":
	            ProcessName = "名片申请";
	            break;
	        case "183445":
	            ProcessName = "加班申请";
	            break;
	        case "7573":
	            ProcessName = "出差申请";
	            break;
	        case "184002":
	            ProcessName = "工卡申请";
	            break;
	        case "374334":
	            ProcessName = "会议申请";
	            break;
	        case "22283":
	            ProcessName = "培训申请";
	            break;
	        case "164584":
	            ProcessName = "工会活动申请";
	            break;
	        case "35876":
	            ProcessName = "机票变更申请";
	            break;
	        case "364244":
	            ProcessName = "弹性考勤申请";
	            break;
	        case "343373":
	            ProcessName = "外包变更申请";
	            break;
	        case "239336":
	            ProcessName = "外包到场申请";
	            break;
	        case "243670":
	            ProcessName = "外包离场申请";
	            break;
	        case "163755":
	            ProcessName = "合同评审申请";
	            break;
	        case "266961":
	            ProcessName = "采购申请";
	            break;
	        case "181943":
	            ProcessName = "薪酬申请";
	            break;
	        case "9597":
	            ProcessName = "员工变动申请";
	            break;
	        case "10788":
	            ProcessName = "员工离职申请";
	            break;
	        case "10767":
	            ProcessName = "员工入职申请";
	            break;
	        case "41556":
	            ProcessName = "员工转正申请";
	            break;
	        case "181603":
	            ProcessName = "招聘需求申请";
	            break;
	        case "411557":
	            ProcessName = "卓学平台资源申请";
	            break;
	        case "270494":
	            ProcessName = "方案决策申请";
	            break;
	        case "270497":
	            ProcessName = "结果确认申请";
	            break;
	        case "181846":
	            ProcessName = "内容发布申请";
	            break;
	        case "19788":
	            ProcessName = "公司用车申请";
	            break;
	        case "326448":
	            ProcessName = "通知发布申请";
	            break;
	        case "11058":
	            ProcessName = "因公出国申请";
	            break;
	        case "205944":
	            ProcessName = "领导信息评审申请";
	            break;
	        case "37931":
	            ProcessName = "租车申请";
	            break;
	        case "62487":
	            ProcessName = "虚拟申请";
	            break;
	        case "27195":
	            ProcessName = "劳动合同申请";
	            break;
	        case "23966":
	            ProcessName = "采购预审申请";
	            break;
	        case "7542":
	            ProcessName = "办公用品申请";
	            break;
	        case "129472":
	            ProcessName = "网路资源申请";
	            break;
	        case "661089":
	            ProcessName = "报备收入申请";
	            break;
	        case "661091":
	            ProcessName = "报备支出申请";
	            break;
	        case "661086":
	            ProcessName = "报备非收支申请";
	            break;
	        default:
	            ProcessName = "未知流程";
	            break;
	    }
	    return ProcessName;
	};
    //加载公文流程
	function DocumentProcess_Processed(count) {
	    $.ajax({
	        type: 'post',
	        url: '../Home/DocumentProcess_Processed',
	        cache: false,
	        dataType: "json",
	        data: {
	            page: page,
	            count: count
	        },
	        success: function (mes) {
	            var HtmlStr = "";
	            if (mes.length == 0) {
	                fade1 = false;
	                HtmlStr += "<div class=\"nowrap\"><img class=\"tit nodata\" src=\"../content/img/nodata.png\"><p class=\"notext\">暂无数据</p><div>";
	            } else {
	               fade1=true
	                //流程名称
	                for (var i = 0; i < mes.length; i++) {
	                    try {
	                        //20171010
	                        //去掉字符串回车换行符
	                        //mes[i].ProcessData = mes[i].ProcessData.replace(/[\r\n]/g, "");
	                        //var processDatajson = $.parseJSON(mes[i].ProcessData);
	                        var ModelId = mes[i].ModelId != null ? mes[i].ModelId : "";
	                        var BillNO = mes[i].BillNo.toString();
	                        var Status = mes[i].Status ? "1" : "0";
	                        var IsTips = mes[i].IsTips ? "1" : "0";
	                        ProcessName = IsTips != "1" ? "公文签报" : "公文待阅";  //流程名称
	                        var Applicant = mes[i].BillEmpName != null ? mes[i].BillEmpName : "";  //申请人
	                        var Title = mes[i].BillTitle != null ? mes[i].BillTitle : "";  //标题
	                        var CreateTime = mes[i].BillTime != null ? timeConvert(mes[i].BillTime, false) : "";
	                        HtmlStr += "<div class=\"list-group-item\" onclick=\"ProcessDetails('" + BillNO + "','" + ModelId + "','" + Status + "','" + IsTips + "')\" >  <div>";
	                        HtmlStr += "<p class=\"tit\">" + ProcessName + "-" + Applicant + "</p>";
	                        HtmlStr += "<p class=\"cont\">事项 : " + Title + "</p>";
	                        HtmlStr += "<p class=\"mydate\">提交日期 : " + CreateTime + "</p>";
	                        HtmlStr += "</div><p class=\"arrow\"><img src=\"../Content/img/arrow.png\" /></p></div>";

	                    } catch (e) {
	                        //异常
	                        console.log(e);
	                    }
	                }
	               

	            };
	            document.getElementById("DocumentInfo").innerHTML = HtmlStr;
	            mySwiper.update()
	        }
	    });
	}
    //时间格式化
	function timeConvert(obj, IsMi) {
	    var correcttime1 = eval('( new ' + obj.replace(new RegExp("\/", "gm"), "") + ')');
	    var myDate = correcttime1;
	    var year = myDate.getFullYear();
	    var month = ("0" + (myDate.getMonth() + 1)).slice(-2);
	    var day = ("0" + myDate.getDate()).slice(-2);
	    var h = ("0" + myDate.getHours()).slice(-2);
	    var m = ("0" + myDate.getMinutes()).slice(-2);
	    var s = ("0" + myDate.getSeconds()).slice(-2);
	    var mi = ("00" + myDate.getMilliseconds()).slice(-3);
	    if (IsMi == false) {
	        return year + "-" + month + "-" + day + " " + h + ":" + m + ":" + s;
	    }
	    else {
	        return year + "-" + month + "-" + day + " " + h + ":" + m + ":" + s + " " + mi;
	    }
	}
    ////搜索栏快速查询
	//function QueryProcessAssemble() {
	//    $.ajax({
	//        url: "../Home/QueryProcessAssemble_Processed",
	//        type: "post",
	//        dataType: "json",
	//        cache: false,
	//        success: function (data) {
	//            if (data.length > 0) {
	//                var HtmlStr = "<p>点击下方流程标题，可进行快捷筛选</p>";
	//                for (var item in data) {
	//                    var Total = data[item].Total;
	//                    var ModelId = data[item].ModelId;
	//                    var ProcessName = GetProcessName(ModelId);
	//                    HtmlStr += "<p class=\"gcolor\">" + ProcessName + "，" + Total + "条</p>";
	//                    HtmlStr += "<input type='hidden' value='" + ModelId + "'>";
	//                    HtmlStr += "<input type='hidden' value='" + Total + "'>";
	//                };

	//            } else {
	//                HtmlStr = "<p>流程数据为空！</p>";
	//            };
	//            $("#QuickLook").html(HtmlStr);
	//            $("#QuickLook p").on("click", function (e) {
	//                var ModelId = $(this).next().val();
	//                var Total = $(this).next().next().val();
	//                QueryProcessByModelId(Total, ModelId)
	//            });
	//        }
	//    });
	//};
    ////根据ModelId查询
	//function QueryProcessByModelId(count, ModelId) {
	//    $.ajax({
	//        type: 'post',
	//        url: '../Home/QueryProcessByModelId_Processed',
	//        cache: false,
	//        dataType: "json",
	//        data: {
	//            page: page,
	//            count: count,
	//            ModelId: ModelId
	//        },
	//        success: function (mes) {
	//            if (mes.length == 0) {

	//            } else {
	//                var HtmlStr = "";
	//                //流程名称
	//                var count = 0;
	//                for (var i = 0; i < mes.length; i++) {
	//                    try {
	//                        //20171010
	//                        //去掉字符串回车换行符
	//                        mes[i].ProcessData = mes[i].ProcessData.replace(/[\r\n]/g, "");
	//                        var processDatajson = $.parseJSON(mes[i].ProcessData);
	//                        var ModelId = mes[i].ModelId != null ? mes[i].ModelId : "";
	//                        var BillNO = mes[i].BillNo.toString();
	//                        var Status = mes[i].Status ? "1" : "0";
	//                        var ProcessName = GetProcessName(ModelId);  //流程名称
	//                        var Applicant = mes[i].BillEmpName != null ? mes[i].BillEmpName : "";  //申请人
	//                        var Title = processDatajson.billTitle != null ? processDatajson.billTitle : "";  //标题
	//                        var CreateTime = processDatajson.billDate != null ? processDatajson.billDate : "";  //创建时间
	//                        //test();
	//                        HtmlStr += "<div class=\"list-group-item\" onclick=\"ProcessDetails('" + BillNO + "','" + ModelId + "','" + Status + "')\" >  <div>";
	//                        //HtmlStr += "<input type='hidden' value='' /><div>";
	//                        HtmlStr += "<p class=\"tit\">" + ProcessName + "-" + Applicant + "</p>";
	//                        HtmlStr += "<p class=\"cont\">事项 : " + Title + "</p>";
	//                        HtmlStr += "<p class=\"mydate\">提交日期 : " + CreateTime + "</p>";
	//                        HtmlStr += "</div><p class=\"arrow\"><img src=\"../Content/img/arrow.png\" /></p></div>";
	//                        count++;
	//                    } catch (e) {
	//                        //异常
	//                        console.log(count + e);
	//                    }
	//                }
	//                document.getElementById("DbInfo").innerHTML = HtmlStr;
	//            };
	//        }
	//    });
	//};
    //根据标题或申请人查询待办流程
	function QueryProcessByName(count, Name) {
	    $.ajax({
	        type: 'post',
	        url: '../Home/QueryProcessByName_Processed',
	        cache: false,
	        dataType: "json",
	        data: {
	            page: page,
	            count: count,
	            Name: Name
	        },
	        success: function (mes) {
	            var HtmlStr = "";
	            var count = 0;
	            if (mes.length > 0) {
	                fade1 = true;
	                //流程名称
	                for (var i = 0; i < mes.length; i++) {
	                    try {
	                        //20171010
	                        //去掉字符串回车换行符
	                       // mes[i].ProcessData = mes[i].ProcessData.replace(/[\r\n]/g, "");
	                       // var processDatajson = $.parseJSON(mes[i].ProcessData);
	                        var ModelId = mes[i].ModelId != null ? mes[i].ModelId : "";
	                        var BillNO = mes[i].BillNo.toString();
	                        var Status = mes[i].Status ? "1" : "0";
	                        var ProcessName = GetProcessName(ModelId);  //流程名称
	                        var Applicant = mes[i].BillEmpName != null ? mes[i].BillEmpName : "";  //申请人
	                        var Title = mes[i].BillTitle != null ? mes[i].BillTitle : "";  //标题
	                        var CreateTime = mes[i].BillTime != null ? timeConvert(mes[i].BillTime, false) : "";
	                        HtmlStr += "<div class=\"list-group-item\" onclick=\"ProcessDetails('" + BillNO + "','" + ModelId + "','" + Status + "')\" >  <div>";
	                        //HtmlStr += "<input type='hidden' value='' /><div>";
	                        HtmlStr += "<p class=\"tit\">" + ProcessName + "-" + Applicant + "</p>";
	                        HtmlStr += "<p class=\"cont\">事项 : " + Title + "</p>";
	                        HtmlStr += "<p class=\"mydate\">提交日期 : " + CreateTime + "</p>";
	                        HtmlStr += "</div><p class=\"arrow\"><img src=\"../Content/img/arrow.png\" /></p></div>";
	                        count++;
	                    } catch (e) {
	                        //异常
	                        console.log(count + e);
	                    }
	                }
	            } else {
	                fade1 = false;
	                HtmlStr += "<div class=\"nowrap\"><img class=\"tit nodata\" src=\"../content/img/nodata.png\"><p class=\"notext\">暂无数据</p><div>";
	            };
	            document.getElementById("DbInfo").innerHTML = HtmlStr;
	        }
	    });
	};
    //根据标题或申请人查询公文流程
	function QueryDocumentProcessByName(count, Name) {
	    $.ajax({
	        type: 'post',
	        url: '../Home/QueryDocumentProcessByName_Processed',
	        cache: false,
	        dataType: "json",
	        data: {
	            page: page,
	            count: count,
	            Name: Name
	        },
	        success: function (mes) {
	            var HtmlStr = "";
	            var count = 0;
	            if (mes.length > 0) {
	                fade1 = true;
	                //流程名称
	                for (var i = 0; i < mes.length; i++) {
	                    try {
	                        //20171010
	                        //去掉字符串回车换行符
	                        //mes[i].ProcessData = mes[i].ProcessData.replace(/[\r\n]/g, "");
	                        //var processDatajson = $.parseJSON(mes[i].ProcessData);
	                        var ModelId = mes[i].ModelId != null ? mes[i].ModelId : "";
	                        var BillNO = mes[i].BillNo.toString();
	                        var Status = mes[i].Status ? "1" : "0";
	                        var IsTips = mes[i].IsTips ? "1" : "0";
	                        var ProcessName = "公文签报";  //流程名称
	                        var Applicant = mes[i].BillEmpName != null ? mes[i].BillEmpName : "";  //申请人
	                        var Applicant = mes[i].BillEmpName != null ? mes[i].BillEmpName : "";  //申请人
	                        var Title = mes[i].BillTitle != null ? mes[i].BillTitle : "";  //标题
	                        var CreateTime = mes[i].BillTime != null ? timeConvert(mes[i].BillTime, false) : "";
	                        HtmlStr += "<div class=\"list-group-item\" onclick=\"ProcessDetails('" + BillNO + "','" + ModelId + "','" + Status + "','" + IsTips + "')\" >  <div>";
	                        //HtmlStr += "<input type='hidden' value='' /><div>";
	                        HtmlStr += "<p class=\"tit\">" + ProcessName + "-" + Applicant + "</p>";
	                        HtmlStr += "<p class=\"cont\">事项 : " + Title + "</p>";
	                        HtmlStr += "<p class=\"mydate\">提交日期 : " + CreateTime + "</p>";
	                        HtmlStr += "</div><p class=\"arrow\"><img src=\"../Content/img/arrow.png\" /></p></div>";

	                    } catch (e) {
	                        //异常
	                        console.log(e);
	                    }
	                }
	            } else {
	                fade1 = false;
	                HtmlStr += "<div class=\"nowrap\"><img class=\"tit nodata\" src=\"../content/img/nodata.png\"><p class=\"notext\">暂无数据</p><div>";
	            };
	            document.getElementById("DocumentInfo").innerHTML = HtmlStr;
	        }
	    });
	};
});