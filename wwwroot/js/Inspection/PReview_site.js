function openModal() {
    document.getElementById("modal").style.display = "flex";
    var response = " 不夠詳細 ";
    $("#modal div.modal-content").html(response);
}

function closeModal() {
    document.getElementById("modal").style.display = "none";
}

function openModalRec() {
    document.getElementById("modalRec").style.display = "flex";
    // var response = " 不夠詳細 ";
    // $("#modal div.modal-content").html(response);
}

function closeModalRec() {
    document.getElementById("modalRec").style.display = "none";
}
