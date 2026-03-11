$("#txtFormSearch").on("keyup", function () {

    let keyword = $(this).val().toLowerCase();

    $(".form-check").each(function () {

        let text = $(this).text().toLowerCase();

        if (text.indexOf(keyword) > -1) {
            $(this).show();
        } else {
            $(this).hide();
        }

    });

});