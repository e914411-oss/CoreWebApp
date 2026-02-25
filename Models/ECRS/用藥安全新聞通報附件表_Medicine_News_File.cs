using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 用藥安全新聞通報附件表_Medicine_News_File
{
    public int News_File_ID { get; set; }

    public int? DC_News_Id { get; set; }

    public string? File_Name { get; set; }

    public string? ContentType { get; set; }

    public long? File_size { get; set; }

    public byte[]? File_Data { get; set; }

    public DateTime? AddDate { get; set; }

    public string? AddUser { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModUser { get; set; }
}
