using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_參數設定檔
{
    /// <summary>
    /// 密碼期限(月)
    /// </summary>
    public int 有效生命週期 { get; set; }

    /// <summary>
    /// 幾日前提示更改
    /// </summary>
    public int 到期警示天數 { get; set; }

    public int 設定編號 { get; set; }

    public int? 登出倒數分鐘數 { get; set; }

    public int 密碼不得與前幾次相同 { get; set; }

    public int? 帳號有效期限 { get; set; }
}
