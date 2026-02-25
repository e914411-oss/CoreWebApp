using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 訂席_外燴定型化契約稽查現場描述上傳檔案
{
    public int 檔案編號 { get; set; }

    public int 現場描述ID { get; set; }

    public string 檔案名稱 { get; set; } = null!;

    public byte[] 檔案內容 { get; set; } = null!;

    public string 檔案說明 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;
}
