using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 用藥安全新聞通報主表_Medicine_News
{
    public int DC_News_Id { get; set; }

    public string? News_Name { get; set; }

    public DateTime? News_Date { get; set; }

    public string? News_Place { get; set; }

    public string? News_Activity { get; set; }

    public string? News_Title { get; set; }

    public string? News_Unit { get; set; }

    public string? Joint_Unit { get; set; }

    public string? Participant_Number { get; set; }

    public string? Pipeline { get; set; }

    public string? Pipeline_Type { get; set; }

    public string? IsMed { get; set; }

    public string? IsCos { get; set; }

    public string? IsDrg { get; set; }

    public string? IsFood { get; set; }

    public string? News_Remark { get; set; }

    public DateTime? AddDate { get; set; }

    public string? AddUser { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModUser { get; set; }
}
