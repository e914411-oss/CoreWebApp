using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_IFI縣市代碼對應PMDS縣市代碼
{
    public string? PMDS縣市名 { get; set; }

    public string PMDS縣市編號 { get; set; } = null!;

    public string? IFI縣市名 { get; set; }

    public string? IFI縣市編號 { get; set; }
}
