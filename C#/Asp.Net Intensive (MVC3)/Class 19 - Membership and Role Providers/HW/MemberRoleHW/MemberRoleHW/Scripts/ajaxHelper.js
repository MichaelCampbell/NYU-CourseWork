$(function () {
    var post = function (elem) {
        var form = $(elem).parents("form");
        $.post(
                $(elem).attr("href"),
                form.serialize(),
                function (html) {
                    form.replaceWith($(html));
                }
            );
    };

    $("a.postLink").live("click", function () {
        post(this);
        return false;
    });

    $("select.postSelect").live("change", function () {
        post(this);
        return false;
    });

});