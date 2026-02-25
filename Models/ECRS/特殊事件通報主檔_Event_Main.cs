using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件通報主檔_Event_Main
{
    public int Event_Main_Id { get; set; }

    public DateTime? Create_Date { get; set; }

    public string? Subject { get; set; }

    public string? Contact { get; set; }

    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public DateTime? Deadline { get; set; }

    public string? Attachment { get; set; }

    public string? Reported_Frequency_Type { get; set; }

    public string? Reported_Frequency_Day { get; set; }

    public DateTime? Reported_Frequency_Start { get; set; }

    public string? Illustrate { get; set; }

    public string? Open { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModUser { get; set; }

    public DateTime? Alert1 { get; set; }

    public DateTime? Alert2 { get; set; }

    public string? TPEPK { get; set; }
}
