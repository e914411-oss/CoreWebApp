using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核上傳查核紀錄表
{
    public int 查核紀錄表流水號 { get; set; }

    public int 登錄查核系統編號 { get; set; }

    public string? 查核內容主類編號 { get; set; }

    public string? 查核內容次類編號 { get; set; }

    public byte[]? 檔案內容 { get; set; }
}
