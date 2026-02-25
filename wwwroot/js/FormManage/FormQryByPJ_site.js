function qry_clear() {
    $("#FormName").val("");
    $("#PJName").val("");
}

function loadForm() {
    const formName = document.getElementById("FormName").value;
    const url = document.getElementById("btnLoadForm").dataset.url;

    const token = document.querySelector('input[name="__RequestVerificationToken"]')?.value;

    fetch(url, {
        method: 'POST',
        headers: {
            'X-Requested-With': 'XMLHttpRequest',
            'Content-Type': 'application/x-www-form-urlencoded',
            'RequestVerificationToken': token
        },
        body: 'FormName=' + encodeURIComponent(formName)
    })
        .then(r => {
            if (!r.ok) throw new Error(`HTTP ${r.status} ${r.statusText}`);
            return r.text();
        })
        .then(html => {
            const host = document.getElementById('formAddHost');
            if (!host) throw new Error("找不到 #formAddHost");
            host.innerHTML = html;

            // ⭐⭐ 重點：HTML 塞完後，手動初始化事件綁定
            if (window.FormAddNote && typeof window.FormAddNote.init === 'function') {
                window.FormAddNote.init();
            }
        })
        .catch(err => console.error(err));
}


document.addEventListener('DOMContentLoaded', function () {

    function toggleButtonBySelfSet() {
        const checked = document.querySelector('input[name="IsSelfSet"]:checked');
        const btn = document.getElementById('btnSetItem');

        if (!checked || !btn) return;

        const isYes = (checked.value === 'Y');

        // ✅ 正確控制可否點擊
        btn.disabled = !isYes;

        // （可選）讓 UI 更像「不可點」
        if (!isYes) {
            btn.classList.add('disabled');
            btn.setAttribute('aria-disabled', 'true');
        } else {
            btn.classList.remove('disabled');
            btn.removeAttribute('aria-disabled');
        }
    }


    // radio 變更 delegated 的 change 綁定（避免 DOM 被換掉後失效）
    document.addEventListener('change', function (e) {
        if (e.target && e.target.name === 'IsSelfSet') {
            toggleButtonBySelfSet();
        }
    });

    //「載入後先套一次狀態」（避免初始狀態不一致）
    document.addEventListener('DOMContentLoaded', function () {
        toggleButtonBySelfSet();
    });

    // 初始狀態，有「重新載入 Partial / innerHTML」的流程的話這裡就再補呼叫一次
    toggleButtonBySelfSet();

});


//document.querySelectorAll('input[type="radio"][name="groupType"]').forEach(r => {
//    r.addEventListener('change', () => {
//        if (!r.checked) return;
//        document.querySelectorAll('input[type="radio"][name="groupType"]').forEach(x => {
//            if (x !== r) x.checked = false;
//        });
//    });
//});

//document.querySelectorAll('input[type="radio"][name="IsSelfSet"]').forEach(r => {
//    r.addEventListener('change', () => {
//        if (!r.checked) return;
//        document.querySelectorAll('input[type="radio"][name="IsSelfSet"]').forEach(x => {
//            if (x !== r) x.checked = false;
//        });
//    });
//});



