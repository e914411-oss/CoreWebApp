using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_DataForCitys_TestItem
{
    public string LABM_ID { get; set; } = null!;

    public string LABM_Name { get; set; } = null!;

    public string LABD_ID { get; set; } = null!;

    public string LABD_Name { get; set; } = null!;

    public string LABDD_ID { get; set; } = null!;

    public string LABDD_Name { get; set; } = null!;

    public DateTime? LABM_MODDATE { get; set; }

    public DateTime? LABD_MODDTAE { get; set; }

    public DateTime? LABDD_MODDATE { get; set; }
}
