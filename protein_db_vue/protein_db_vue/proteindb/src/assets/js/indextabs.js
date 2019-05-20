$(document).ready(function(){
    var newWidget="<div class='widget-wrapper'> <ul class='tab-wrapper'></ul> <div class='new-widget'></div></div>";
    $(".widget").hide();
    $(".widget:first").before(newWidget);
    $(".widget > div").each(function(){
        $(".tab-wrapper").append("<li class='tab'>"+
        parse_tab_id(this.id) +"</li>");
        $(this).appendTo(".new-widget");
    });
    $(".tab").click(function(){
        $(".new-widget > div").hide();
        $('#'+parse_name_tab($(this).text())).show();
        $(".tab").removeClass("active-tab");
        $(this).addClass("active-tab");
    });
    $(".tab:first").click();
});

function parse_tab_id(var_str) {
    var word_arr = var_str.split("_");
    var i;
    var res="";
    for(i = 0; i < word_arr.length; i++) {
        console.log("word: ", word_arr[i]);
        if(i < word_arr.length -1)
        {   res += word_arr[i] + " ";
        }
        else
        {   res += word_arr[i];
        }
    }
    console.log("func1 res:",res);
    return res;
}

function parse_name_tab(var_name)
{   console.log("var_name: ",var_name);
    var res = var_name.replace(/ /g,"_");
    console.log("func2 res:", res);
    return res;
}
