function clickEnum() {
    var elem = $(this).children("ul");
    if (elem.attr("hidden")) {
        elem.attr("hidden", false);
        elem.css("display", "inline");
        $(this).attr("title", "");
    } else {
        elem.attr("hidden", true);
        elem.css("display", "none");
        $(this).attr("title", "Click to see the list of values the enum can take");
    }
}


$(document).ready(function() {
    $("td:contains('Enum')")
        .each(function() {
            $(this).attr("title", "Click to see the list of values the enum can take");
            $(this).addClass("expandable");
            $(this).on("click", clickEnum);
        });
});