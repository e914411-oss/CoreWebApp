using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統_排程更新代碼檔紀錄
{
    public Guid 更新編號 { get; set; }

    public DateTime 更新時間 { get; set; }

    /// <summary>
    /// [PMDS的表名]
    /// </summary>
    public string 更新名稱 { get; set; } = null!;

    /// <summary>
    /// 成功、失敗
    /// </summary>
    public string 更新狀態 { get; set; } = null!;

    /// <summary>
    /// 失敗時寫入失敗原因
    /// </summary>
    public string? 更新說明 { get; set; }
}
