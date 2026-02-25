using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_gsp資料綁定log
{
    public int 主鍵 { get; set; }

    public string 帳號 { get; set; } = null!;

    public string 姓名 { get; set; } = null!;

    public DateTime 綁定時間 { get; set; }

    public int 綁定方式_代碼 { get; set; }

    public string 綁定方式_內容 { get; set; } = null!;

    public string 綁定TOKEN存取 { get; set; } = null!;

    public string 寫入狀態 { get; set; } = null!;

    public string 寫入內容 { get; set; } = null!;
}
