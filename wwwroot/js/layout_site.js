// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

console.log("site.js loaded");


//這段是以AJAX的方式做導頁

(function () {
    const content = document.getElementById('mainContent');
    if (!content) return;

    async function loadIntoMain(url, { push = true } = {}) {
        // 取得 partial
        const res = await fetch(url, {
            headers: { "X-Requested-With": "XMLHttpRequest" }
        });

        if (!res.ok) {
            // 失敗就退回整頁導頁
            window.location.href = url;
            return;
        }

        const html = await res.text();
        content.innerHTML = html;

        // 更新網址（看起來像導頁）
        if (push) history.pushState({ url }, "", url);

        // 更新側邊欄 active 樣式（簡易版：以 href 比對）
        document.querySelectorAll("a.ajax-link").forEach(a => {
            const isActive = a.href === location.href;
            a.classList.toggle("active", isActive);
            a.classList.toggle("fw-bold", isActive);
        });
    }

    // 攔截側邊欄第二層連結
    document.addEventListener("click", function (e) {
        const a = e.target.closest("a.ajax-link");
        if (!a) return;

        // 保留新分頁行為
        if (e.ctrlKey || e.metaKey || e.shiftKey || e.button !== 0) return;

        e.preventDefault();
        loadIntoMain(a.href, { push: true });
    }, true);

    // 處理瀏覽器上一頁/下一頁
    window.addEventListener("popstate", function (e) {
        const url = (e.state && e.state.url) ? e.state.url : location.href;
        loadIntoMain(url, { push: false });
    });
})();
