using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Poisoned_Food_Supply
{
    public int Poisoned_Food_Supply_ID { get; set; }

    public string? External_Key { get; set; }

    public int? Case_ID { get; set; }

    public string? Food_Supply_Name { get; set; }

    public string? Food_Supply_Responsible_Person { get; set; }

    public string? Food_Supply_Responsible_ID { get; set; }

    public string? Food_Supply_City { get; set; }

    public string? Food_Supply_Address { get; set; }

    public string? Food_Supply_Tel { get; set; }

    public string? Food_Supply_Ext { get; set; }

    public string? Food_Supply_Place_Class { get; set; }

    public string? Food_Supply_ID { get; set; }

    public string? Accident_Place_do { get; set; }

    public string? Accident_Place_do_other { get; set; }

    public string? Teach_Date { get; set; }

    public string? Recent_Check_Date { get; set; }

    public string? Cook_Person { get; set; }

    public string? Cooker_Tech { get; set; }

    public string? Join_FoodClean_Class { get; set; }

    public string? Water { get; set; }

    public string? Kitchen { get; set; }

    public string? Toilet { get; set; }

    public string? Water_System { get; set; }

    public string? Bug { get; set; }

    public string? Staff_Health { get; set; }

    public string? Make_Survey { get; set; }

    public DateTime? Update_Time { get; set; }

    public string? ModUser { get; set; }
}
