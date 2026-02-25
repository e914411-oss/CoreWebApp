using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Poisoned_CaseSuspFood_List
{
    public int Id { get; set; }

    public string? FoodCode { get; set; }

    public string? FoodName { get; set; }

    public string? FoodType { get; set; }

    public string? Del_MK { get; set; }

    public DateTime? Create_Time { get; set; }

    public string? Create_UserID { get; set; }

    public DateTime? Upd_Time { get; set; }

    public string? Upd_UserID { get; set; }

    public int? DataStatus { get; set; }

    public string IsActive { get; set; } = null!;

    public int SortIndex { get; set; }
}
