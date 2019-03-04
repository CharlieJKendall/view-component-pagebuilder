window.onload = function() {
    var select = $("[data-purchase-id]");

    if(select){
        var ids = [];

        select.each(function(index){
            ids.push(this.getAttribute("data-purchase-id"));
        });

        for(var index = 0; index < ids.length; index++){
            var timer = $("[data-purchase-id=" + ids[index] + "]");
            var format = timer.data("timer-format"),
                layout = timer.data("timer-layout"),
                significant = timer.data("timer-significant");

            timer.countdown('destroy');
            timer.countdown({
                until: timer.data("time-difference"),
                format: format,
                padZeros: true,
                significant: significant,
                layout: layout
            });
        }
    }
};