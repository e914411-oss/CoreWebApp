using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_gsp登入LOG紀錄
{
    public int 主鍵 { get; set; }

    public string 帳號 { get; set; } = null!;

    public string 姓名 { get; set; } = null!;

    public DateTime 登入時間 { get; set; }

    public int 綁定方式_代碼 { get; set; }

    public string 綁定方式_內容 { get; set; } = null!;

    public string 登入TOKEN存取 { get; set; } = null!;

    public string 登入狀態 { get; set; } = null!;
}
