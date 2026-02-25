$(document).ready(function() {
    load_html();
    checkall();
    addmyfav();
    viewport();
    header_search();
    contentHeight();
    toggle_blue();
    side_memu_toggle();
    link_owl();
    date_picker_fun();
    radio_toggle();
    file_upload();
    $('[data-toggle="tooltip"]').tooltip();
    $('.selectpicker').selectpicker('refresh');

    setTimeout(function () {
        $("#side-menu-1").siblings().removeClass("active in");
        $("#side-menu-1").addClass("active in");
    }, 500);

    setTimeout(function () {
        $(".tsb-5").removeClass("collapsed");
        $("#side-menu-1").siblings().removeClass("active in");
        $("#side-menu-1").addClass("active in");
    }, 500);
    $('select[name=selValue]').on('change', function () {
        var selected = $(this).find("option:selected").val();
        if (selected == "pop") {
            $('.modal-detail').modal('show');
        }
    });

    setTimeout(function() {
        // drag_sidemenu_to_tab();
    }, 500);
});
$(window).resize(function() {
    viewport();
});
// $.getScript('../../inc/js/material.js', function() {
//     $.material.init();
// });

function toggle_blue() {
    $('.toggle-blue').click(function() {
        $('link[href="../../inc/css/cf-layout.css"]').attr('href', '../../inc/css/cf-layout-blue.css');
    });
}

function viewport() {
    var viewportWidth = $(window).width();
    if (viewportWidth > 992) {
        // $(".main-container").removeClass("side-menu-close");
    } else {
        $(".main-container").addClass("side-menu-close");
    }
}


function header_search() {
    $(".header-seach").click(function() {
        $(this).addClass("active").find("input").focus();
    });
    $(".header-seach input").on('blur', function() {
        $(".header-seach").removeClass("active");
    });
}

function print_popup_content() {
    document.getElementById("Print").onclick = function() {
        printElement(document.getElementById("printThis"));
    };

    function printElement(elem) {
        var domClone = elem.cloneNode(true);

        var $printSection = document.getElementById("printSection");

        if (!$printSection) {
            var $printSection = document.createElement("div");
            $printSection.id = "printSection";
            document.body.appendChild($printSection);
        }

        $printSection.innerHTML = "";
        $printSection.appendChild(domClone);
        window.print();
    }
}

function checkall() {
    $('.demo-checkall').click(function() {
        var state = $(this).find("input").is(':checked');
        if (state) {
            $(".tb-multi tbody .checkbox input").prop("checked", true);
        } else {
            $(".tb-multi tbody .checkbox input").prop("checked", false);
        }
    });



    $('.adress-check').click(function() {
        var state = $(this).find("input").is(':checked');
        if (state) {
            $(this).next('.adress-check-show').addClass("hide");
        } else {
            $(this).next('.adress-check-show').removeClass("hide");
        }
    });

}

function radio_toggle() {
    $(".check-collapse-all").click(function() {
        $(".panel-group-check .panel a").removeClass("collapsed");
        $(".panel-group-check .panel .collapse").addClass("in");
    });
    $(".check-collapse-all-none").click(function() {
        $(".panel-group-check .panel a").addClass("collapsed");
        $(".panel-group-check .panel .collapse").removeClass("in");
    });
    $(".radio-toggle-link1").click(function() {
        $(".demo-radio-toggle").removeClass("in");
    });
    $(".radio-toggle-link2").click(function() {
        $(".demo-radio-toggle").addClass("in");
    });
    $(".radio-hide").click(function() {
        $(".demo-date").addClass("hide");
    });
    $(".radio-show").click(function() {
        $(".demo-date").removeClass("hide");
    });
    $(".radio-hide2").click(function() {
        $(".demo-date2").addClass("hide");
    });
    $(".radio-show2").click(function() {
        $(".demo-date2").removeClass("hide");
    });
    $(".radio-hide3").click(function() {
        $(".demo-date3").addClass("hide");
    });
    $(".radio-show3").click(function() {
        $(".demo-date3").removeClass("hide");
    });
    $(".radio-toggle-input").click(function() {
        // $(".radio-toggle-input input").prop('disabled', true);
        $(".radio-toggle-input").parent().parent().find("input").prop('disabled', true);
        $(this).parent().parent().find("input").prop('disabled', false);
    });
    $(".disabled-all").click(function() {
        $(".radio-toggle-input").parent().parent().find("input").prop('disabled', true);
    });
    $(".other-toggle").click(function() {
        $(".other-input").prop('disabled', false);
    });
    $(".other-toggle-disaled").click(function() {
        $(".other-input").prop('disabled', true);
    });
}

function file_upload() {
    // $('.btn-file input[type="file"]').change(function(e) {
    //     var fileName = e.target.files[0].name;
    //     $(this).parent().prev(".btn-add-file").removeClass("hide").find("span").text(fileName);
    // });
    $('.btn-file.add input[type="file"]').on('change', function(e) {
        var fileName = e.target.files[0].name;
        // $(this).prev("span").text(fileName);
        $(this).parent().parent().parent().prepend('<div class="input-group btn-add-file"><input class="form-control" type="text" value="' + fileName + '" disabled><span class="input-group-btn"><button type="button" class="btn btn-default"><i class="icon-cross"></i></button></span></div>').on('click', '.btn-add-file .btn', function() {
            $(this).parent().parent().remove();
        });
    });

}

function add_member() {
    $('.add-member').on('click', function(e) {
        $(this).parent().prepend('<div class="input-group input-group-sm btn-add-member"><input class="form-control" type="text" value=""><span class="input-group-btn"><button type="button" class="btn btn-default"><i class="icon-cross"></i></button></span></div>').on('click', '.btn-add-member .btn', function() {
            $(this).parent().parent().remove();
        });
    });

}

function site_map_toggle() {
    $("ul.site-map li h3").click(function() {
        $(this).toggleClass("collapsed").next(".collapse").collapse('toggle');
    });
    $("ul.site-map li .has-sub").click(function() {
        $(this).toggleClass("collapsed").next(".sub").collapse('toggle');
    });
}

function alert_show() {
    $('.show-alert').click(function() {
        $('.pop-alert').addClass("in")
        setTimeout(function() {
            $('.pop-alert').removeClass("in")
        }, 3000);
    });
}

function codeBoxCopy_fun() {
    $('.code-box-copy').codeBoxCopy({
        tooltipText: 'Copied',
        tooltipShowTime: 1000,
        tooltipFadeInTime: 300,
        tooltipFadeOutTime: 300,
    });
}

function date_picker_fun() {
    $('.datepicker').datepicker({
    });
    //$(".datepicker-months").datepicker({ //只顯示月份
    //    format: "yyyy年mm月",
    //    viewMode: "months",
    //    minViewMode: "months"
    //});
    //$(".datepicker-years").datepicker({ //只顯示年份
    //    format: "yyyy年",
    //    viewMode: "years",
    //    minViewMode: "years"
    //});
}

function toggle_map() {
    $('.map-toggle-btn-close').click(function() {
        $(this).addClass("hide").siblings(".map-toggle-btn-open").removeClass("hide");
        $(".map-toggle").addClass("hide-right")
    });
    $('.map-toggle-btn-open').click(function() {
        $(this).addClass("hide").siblings(".map-toggle-btn-close").removeClass("hide");
        $(".map-toggle").removeClass("hide-right")
    })

}


function side_memu_toggle() { /*content 的最小高*/
    $(".side-memu-toggle").click(function() {
        $(".main-container").toggleClass("side-menu-close");
        // $(".side-bar .panel > a span").toggleClass("fadeIn animated");
    });

    $(".mobile-menu-toggle .toggle-open").click(function() {
        $(this).addClass("hide").next(".toggle-close").removeClass("hide");
        // $("ul.menu").addClass("mobile-menu-open");
        $(".main-container").removeClass("side-menu-close");
        $(".header .top-nav").addClass("show");
        $("#right-content").addClass("right-content-act");
    });

    $(".mobile-menu-toggle .toggle-close").click(function() {
        $(this).addClass("hide").prev(".toggle-open").removeClass("hide");
        // $("ul.menu").removeClass("mobile-menu-open");
        $(".main-container").addClass("side-menu-close");
        $(".header .top-nav").removeClass("show");
        $("#right-content").removeClass("right-content-act");

    });
    $(".main-container").on('click', '.right-content-act', function() {
        $(".mobile-menu-toggle .toggle-close").addClass("hide").prev(".toggle-open").removeClass("hide");
        $("#right-content").removeClass("right-content-act");
        // $("ul.menu").removeClass("mobile-menu-open");
        $(".main-container").addClass("side-menu-close");
        $(".header .top-nav").removeClass("show");
    })
}

function addmyfav() { /*content 的最小高*/
    $(".addmyfav").click(function() {
        $(this).toggleClass("active");
    });
    $("ul.menu-list li i.star,ul.menu-list li ul.sub li i.star").click(function() {
        $(this).toggleClass("active");
    });
}

function contentHeight() { /*content 的最小高*/
    var window_h = $(window).height();
    var side_h = $(".side-menu-hold").height() + (200);
    var gap = 230;
    if (side_h < window_h) {
        $("#right-content .content").css('min-height', (window_h - gap) + 'px');
    } else if (side_h > window_h) {
        $("#right-content .content").css('min-height', (side_h - gap) + 'px');
    }
    // alert(side_h);
}
// 點了placeholder消失
function input_title_show_hide() {
    $('input:text, textarea,input:password').each(function() {
        var $this = $(this);
        $this.data('placeholder', $this.attr('placeholder'))
            .focus(function() {
                $this.removeAttr('placeholder');
            })
            .blur(function() {
                $this.attr('placeholder', $this.data('placeholder'));
            });
    });
}



function load_html() {
    //$('#header').load("../../html/header.html");
    //$('#cframe').load("../../html/nav-area.html");
    //$('#footer').load("../../html/footer.html");
}



function gotop() {
    $("#topcontrol").click(function() {
        $("html,body").animate({
            scrollTop: 0
        }, 500);
    });
    $(window).scroll(function() {
        console.log($(this).scrollTop());
        if ($(this).scrollTop() > 150) {
            $('#topcontrol').addClass("fade");
            $('.search-fix-top').addClass("active");
            // $('float-bar').css('visibility','visible');
        } else {
            $('#topcontrol').removeClass("fade");
            $('.search-fix-top').removeClass("active");
            // $('#gotop').css('visibility','hidden');
        }
    });
}

function link_owl() {
    $('.link_owl').owlCarousel({
        // items:5,
        // loop:true,
        margin: 0,
        autoplay: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: true,
        navSpeed: 1000,
        nav: true,
        navText: ["<i class='icon-chevron-left'></i>", "<i class='icon-chevron-right'></i>"],
        paginationSpeed: 400,
        dots: false,
        responsive: {
            0: {
                items: 2
            },
            600: {
                items: 3
            },
            1000: {
                items: 4
            }
        }
    })
    $('.link_owl .owl-nav').removeClass('disabled');
    $('.link_owl .owl-nav').click(function(e) {
        $(this).removeClass('disabled');
    });
}