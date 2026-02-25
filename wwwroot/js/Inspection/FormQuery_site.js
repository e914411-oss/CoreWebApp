// ========================================
// 稽查狀態 全選控制（支援動態載入）
// PMDS 專用版本
// ========================================

// 使用 document 委派，避免 partial view reload 失效
$(document)

    //------------------------------------
    // 點擊「全選」
    //------------------------------------
    .on('change',
        '#ctl00_ContentPlaceHolder1_ckb1',
        function () {

            const isChecked = this.checked;

            // 找到同一區塊內所有 checkbox（排除自己）
            const $container = $(this).closest('td');

            $container
                .find('input[type="checkbox"]')
                .not(this)
                .prop('checked', isChecked);

        })


    //------------------------------------
    // 點擊個別 checkbox
    //------------------------------------
    .on('change',
        '#ctl00_ContentPlaceHolder1_ckb2, \
         #ctl00_ContentPlaceHolder1_ckb3, \
         #ctl00_ContentPlaceHolder1_ckb4, \
         #ctl00_ContentPlaceHolder1_ckb5, \
         #ctl00_ContentPlaceHolder1_ckb6, \
         #ctl00_ContentPlaceHolder1_ckb7',
        function () {

            const $container = $(this).closest('td');

            const $checkAll =
                $container.find('#ctl00_ContentPlaceHolder1_ckb1');

            const $items =
                $container
                    .find('input[type="checkbox"]')
                    .not($checkAll);

            const total = $items.length;
            const checked = $items.filter(':checked').length;

            $checkAll.prop('checked', total === checked);

        });