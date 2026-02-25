using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件允許填報衛生局清單_Event_Operator_City
{
    public int Event_OperatorCity_Id { get; set; }

    public int? Event_Main_Id { get; set; }

    public string? OperatorCity { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModUser { get; set; }
}
