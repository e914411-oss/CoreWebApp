function openModal() {
    document.getElementById("modal").style.display = "flex";
    var response = " 不夠詳細. ";
    //$("#modal div.modal-content").html(response);
    document.querySelector("#modal .modal-content").innerHTML = response;

    //var myModal = new bootstrap.Modal(document.getElementById('modal'));
    //myModal.show();
}

function closeModal() {
    document.getElementById("modal").style.display = "none";
}

function openModalRec() {
    document.getElementById("modalRec").style.display = "flex";
    // var response = " 不夠詳細 ";
    // $("#modalRec div.modal-content").html(response);
}

function closeModalRec() {
    document.getElementById("modalRec").style.display = "none";
}

function openModalF() {
    document.getElementById("modal").style.display = "flex";
    
}

function preSearch() {
    var Company = $("#txtCompany_Name").val();
    //alert(Company);
    var supplier1 = {
        Id: null,
        業者編號: null,
        業者名稱: Company,
        食品登錄字號: null,
        統一編號: null,
        電話號碼: null,
        業者地址: null,
        案件建立日期: null,
    };

    //window.location.href = '/Inspection/Fquery?' + $.param(supplier1);


    $.ajax({
        url: '/Inspection/Fquery',
        type: 'GET',
        cache: false, 
        data: supplier1,
        success: function (result) {
            //alert("後端傳回的長度是：" + result.length);
            $("#resultDiv").html(result);

            var totalPages = $("#totalPages").val();
            var currentPage = $("#currentPage").val();

            if ($.fn.DataTable.isDataTable('#supplierTable')) {
                $('#supplierTable').DataTable().destroy();
                $("#resultDiv").html(result);
            }

            $('#supplierTable').DataTable({
                pageLength: 10,
                language: {
                    lengthMenu: "顯示 _MENU_ 筆資料",
                    zeroRecords: "沒有符合的資料",
                    info: "顯示第 _START_ 到 _END_ 筆，共 _TOTAL_ 筆",
                    infoEmpty: "沒有資料",
                    infoFiltered: "(從 _MAX_ 筆資料中篩選)",
                    search: "搜尋:",
                    paginate: {
                        first: "首頁",
                        last: "末頁",
                        next: "下一頁",
                        previous: "上一頁"
                    }
                }
            });

            //window.location.href = '/Inspection/Fquery?' + $.param(supplier1);

            // 如果使用 bootstrap-select
            //areaSelect.selectpicker('refresh');
        }
    });
}


$(document).ready(function () {

    $('#checkRecTable').DataTable({
        pageLength: 10,
        language: {
            lengthMenu: "顯示 _MENU_ 筆資料",
            zeroRecords: "沒有符合的資料",
            info: "顯示第 _START_ 到 _END_ 筆，共 _TOTAL_ 筆",
            infoEmpty: "沒有資料",
            infoFiltered: "(從 _MAX_ 筆資料中篩選)",
            search: "搜尋:",
            paginate: {
                first: "首頁",
                last: "末頁",
                next: "下一頁",
                previous: "上一頁"
            }
        }
    });

    document.getElementById("btn_FExcel").addEventListener("click", function () {

        var Company = $("#txtCompany_Name").val();
        //alert(Company);
        var supplier1 = {
            Id: null,
            業者編號: null,
            業者名稱: Company,
            食品登錄字號: null,
            統一編號: null,
            電話號碼: null,
            業者地址: null,
            案件建立日期: null,
        };

        window.location.href = '/Inspection/ExportExcelF?' + $.param(supplier1);

    });
 
    $("#citySelect").change(function () {

        var cityId = $(this).val();

        $.ajax({
            url: '/Inspection/GetAreaByCity',
            type: 'GET',
            data: { cityId: cityId },
            success: function (data) {

                var areaSelect = $("#areaSelect");
                areaSelect.empty();

                areaSelect.append('<option value="">全部</option>');

                $.each(data, function (i, item) {
                    areaSelect.append(
                        '<option value="' + item.鄉鎮區代碼 + '">' + item.機構縣市鄉鎮市區 + '</option>'
                    );
                });

                // 如果使用 bootstrap-select
                //areaSelect.selectpicker('refresh');
            }
        });

    });

});
