using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_網站地圖節點
{
    public short 主鍵 { get; set; }

    public string? 模式 { get; set; }

    public string? 標題 { get; set; }

    public string? 名稱 { get; set; }

    public short? 代碼 { get; set; }

    public short 類型 { get; set; }

    public string? 系統管理員網址 { get; set; }

    public string? 網址 { get; set; }

    public short? 排序 { get; set; }

    public int 層別 { get; set; }

    public bool 鎖定 { get; set; }

    public short 發佈到期日 { get; set; }

    public short 審核到期日 { get; set; }

    public string? 作業事項 { get; set; }

    public string? 網站筆記 { get; set; }

    public short 級別 { get; set; }

    public bool? 是否為區塊 { get; set; }

    public short? 父層目錄 { get; set; }

    public short? 置左 { get; set; }

    public short? 置右 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 修改時間 { get; set; }

    public int 提醒 { get; set; }

    public string? 路徑 { get; set; }

    public string? 階層 { get; set; }
}
