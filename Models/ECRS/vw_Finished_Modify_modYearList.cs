using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Finished_Modify_modYearList
{
    public long? ROWID { get; set; }

    public int Finish_ID { get; set; }

    public DateTime? MODDATE { get; set; }

    public string? TYPE { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public DateTime? CHKDATE { get; set; }
}
