// wwwroot/js/FormManage/formadd_note.js
window.FormAddNote = (function () {

    function getAntiForgeryToken() {
        const el = document.querySelector('input[name="__RequestVerificationToken"]');
        return el ? el.value : '';
    }

    function open() {
        $('#noteOverlay').show();
        setTimeout(() => $('#noteText').trigger('focus'), 0);
    }

    function close() {
        $('#noteOverlay').hide();
    }

    function saveNoteToApi(noteText) {
        const url = '/Api/FormManage/SaveNote'; // TODO: 之後換成你的 API
        const token = getAntiForgeryToken();

        return fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'RequestVerificationToken': token,
                'X-Requested-With': 'XMLHttpRequest'
            },
            body: JSON.stringify({ note: noteText })
        }).then(resp => {
            if (!resp.ok) throw new Error('API error: ' + resp.status);
            return resp.json().catch(() => ({}));
        });
    }

    // ⭐ 重點：每次 FormAdd 被塞進 DOM 後，都要呼叫 init 重新綁事件
    function init() {
        // 避免重複綁定：先解除再綁
        $(document)
            .off('click', '#FormAdd_Note, [data-note-open="1"]')
            .on('click', '#FormAdd_Note, [data-note-open="1"]', function () { open(); });

        $(document)
            .off('click', '#noteCancelBtn')
            .on('click', '#noteCancelBtn', function () { close(); });

        $(document)
            .off('click', '#noteOkBtn')
            .on('click', '#noteOkBtn', function () {
                const noteText = $('#noteText').val() || '';
                close(); // 你要「按了就消失」就先關

                // 備用 API 呼叫（不阻塞 UI）
                saveNoteToApi(noteText).catch(console.error);
            });

        $(document).off('keydown.formaddnote').on('keydown.formaddnote', function (e) {
            if (e.key === 'Escape' && $('#noteOverlay').is(':visible')) close();
        });
    }

    return { init, open, close, saveNoteToApi };
})();



// ✅ SetItem 遮罩（編輯浮動欄位）- 不干擾 FormAddNote
window.FormAddSetItem = (function () {

    function open() {
        $('#SetItemOverlay').show();
    }

    function close() {
        $('#SetItemOverlay').hide();
    }

    function init() {
        // 1) 點「設定」(id=btnSetItem) 才顯示遮罩
        $(document)
            .off('click.formaddsetitem', '#btnSetItem')
            .on('click.formaddsetitem', '#btnSetItem', function (e) {
                e.preventDefault();
                open();
            });

        // 2) 點「取消/確定」關閉遮罩（你頁面上 id 是：btn浮動欄位取消 / btn浮動欄位確定）
        $(document)
            .off('click.formaddsetitem', '#btn浮動欄位取消, #btn浮動欄位確定')
            .on('click.formaddsetitem', '#btn浮動欄位取消, #btn浮動欄位確定', function (e) {
                e.preventDefault();
                close();
            });

        // 3) ESC 關閉（只在 SetItemOverlay 顯示時生效）
        $(document)
            .off('keydown.formaddsetitem')
            .on('keydown.formaddsetitem', function (e) {
                if (e.key === 'Escape' && $('#SetItemOverlay').is(':visible')) close();
            });

        // 4) 點遮罩空白處關閉（避免點到內容區也觸發：用 closest 判斷）
        $(document)
            .off('click.formaddsetitem', '#SetItemOverlay')
            .on('click.formaddsetitem', '#SetItemOverlay', function (e) {
                if ($(e.target).closest('#SetItemMak').length === 0) close();
            });

        // ✅ 保險：進入頁面先確保它是隱藏（避免你未加 style=display:none 時閃一下）
        close();
    }

    return { init, open, close };
})();



// 在檔案最底部加上這段（或 IIFE 內最後），這是點了新增表單後正常導頁完要做的
(function autoInit() {
    function runInit() {
        if (window.FormAddNote && typeof window.FormAddNote.init === 'function') {
            window.FormAddNote.init();
        }
        if (window.FormAddSetItem && typeof window.FormAddSetItem.init === 'function') {
            window.FormAddSetItem.init();
        }
    }

    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', runInit);
    } else {
        runInit();
    }
})();

//(function autoInit() {
//    // DOM Ready 就先 init 一次：涵蓋「整頁導頁到 FormAdd」情境
//    if (document.readyState === 'loading') {
//        document.addEventListener('DOMContentLoaded', function () {
//            if (window.FormAddNote && typeof window.FormAddNote.init === 'function') {
//                window.FormAddNote.init();
//            }
//        });
//    } else {
//        if (window.FormAddNote && typeof window.FormAddNote.init === 'function') {
//            window.FormAddNote.init();
//        }
//    }
//})();