using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件允許瀏覽人員清單_Event_Operator_Person
{
    public int Event_OperatorPerson_Id { get; set; }

    public int? Event_Main_Id { get; set; }

    public string? OperatorPerson { get; set; }

    public string? Type { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModUser { get; set; }

    public string? ORG { get; set; }
}
