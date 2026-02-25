using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_FTR_Place
{
    public DateTime? DataDate { get; set; }

    public decimal Id { get; set; }

    public string? APPL_NO { get; set; }

    public string? GOODS_ST_CITY { get; set; }

    public string? GOODS_ST_CITY_Name { get; set; }

    public string? GOODS_ST_ADDR { get; set; }

    public decimal? AMT { get; set; }

    public string? AMT_UNIT { get; set; }

    public string? RETURN_DATE { get; set; }

    public string? RETURN_RESULT { get; set; }

    public string? RETURN_RESULT_Name { get; set; }

    public string? NOTIFY_DATE { get; set; }

    public string? REMARK { get; set; }

    public string? RETURN_DATE_Show { get; set; }

    public string? NOTIFY_DATE_Show { get; set; }

    public string? RETURN_DATE_Idx { get; set; }

    public string? NOTIFY_DATE_Idx { get; set; }

    public string? CONTACT_MAN { get; set; }
}
