requirejs.config({  
    baseUrl: '../js/libs' 
});  
  
  
require(["jquery","layer"], function($,layer) { 
//公文退回
            $(".iconfir").on("click",function(){
		    	var index=layer.open({
					    content: '您确定要退回吗？',
					    shade: 'background-color: rgba(0,0,0,.5)' 
					    ,btn: ['取消', '退回']
					    ,yes: function(index){
					      layer.close(index);
		            },no:function(index){
					      //退回操作
					      layer.close(index);
					      var index1=layer.open({
					      	    shade: 'background-color: rgba(0,0,0,.5)' ,
								type: 2,
								content: '加载中'
								});
								
							setTimeout(function(){
								layer.close(index1)
							},1000)
						      $.ajax({
						      	type:"get",
						      	url:"",
						      	async:true
						      });
						      
					      //处理完成
					    var html='<div class="over">'+
							    	'<p><img src="../img/succ1.png" alt="" /></p>'+
							    	'<p>处理完成！</p>'+
							    	'</div>'	  
					      setTimeout(function(){
					      	 var index2=layer.open({
								  style: 'font-size:.4rem;width:70%;border:none; background-color:#fff; color:#555;text-align:center;',
								  content:html
						   })
					      },1100)
					   
					      setTimeout(function(){
					      	layer.closeAll()
					      },2000)
		              }
		    	  })
		       })
              //选择人员完成
		    $(".ifinished").on("click",function(){
		    	$(".manlist").animate({bottom:"-100%"},200,"swing")
		    	var len=$(".manlist").find("input:checked").length
		        var html="";
		    	len==0?$(".sel span").html("请选择(必选)"):$(".sel span").html("共"+len+"人")
		    })
		    
            //选择人员
             $(".sel").on("click",function(){
		    	$(".manlist").animate({bottom:0},200,"swing")
		    })
            //选择人员完成
              
		    $(".finished").on("click",function(){
		    	$(".manlist").animate({bottom:"-100%"},200,"swing")
		    	var len=$(".manlist").find("input:checked").length
		        var html="";
		    	len==0?$(".sel span").html("请选择(必选)"):$(".sel span").html("共"+len+"人")
		    })
		    
             $(".ireturn").on("click",function(){
             	location.href="document待办.html"
             })
})