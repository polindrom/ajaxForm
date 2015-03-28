(function () {
    $('form').ajaxForm({
        success: function (report) {
            alert(report);
        }
    });
})();

