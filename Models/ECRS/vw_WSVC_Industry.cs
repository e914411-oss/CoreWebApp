using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_WSVC_Industry
{
    public int Industry_ID { get; set; }

    public int TPEPK { get; set; }

    public string? FLAG { get; set; }

    public string? BUSNO { get; set; }

    public string ORG { get; set; } = null!;

    public string COUNTRY { get; set; } = null!;

    public string TOWN { get; set; } = null!;

    public string ADDRESS { get; set; } = null!;

    public string PUBLISHNAME { get; set; } = null!;

    public string REGNAME { get; set; } = null!;

    public string PLICENSENO { get; set; } = null!;

    public string BLICENSENO { get; set; } = null!;

    public string FLICENSENO { get; set; } = null!;

    public string TELPHONE { get; set; } = null!;

    public string FAX { get; set; } = null!;

    public string STATUS { get; set; } = null!;

    public string AUTHNUM { get; set; } = null!;

    public string WORKERNUM { get; set; } = null!;

    public string HACCP { get; set; } = null!;

    public string GMP { get; set; } = null!;

    public string GSP { get; set; } = null!;

    public string CAS { get; set; } = null!;

    public string OTHERIDEN { get; set; } = null!;

    public string C { get; set; } = null!;

    public string B { get; set; } = null!;

    public string BOSS { get; set; } = null!;

    public string? BIRTHDAY { get; set; }

    public string MPHONE { get; set; } = null!;

    public string EMAIL { get; set; } = null!;

    public string? IDNO { get; set; }

    public string BOSSADDR { get; set; } = null!;

    public string CONADDR { get; set; } = null!;

    public string MAGMAN { get; set; } = null!;

    public string RESMAN { get; set; } = null!;

    public string RMK { get; set; } = null!;

    public string? BMT_NO { get; set; }

    public string? BDT_NO { get; set; }

    public string? FMT_NO { get; set; }

    public string? FDT_NO { get; set; }

    public string? FDDT_NO { get; set; }

    public string WSR_NO { get; set; } = null!;

    public string WAADDR { get; set; } = null!;

    public string WAVADATE { get; set; } = null!;

    public string WNAME { get; set; } = null!;

    public string? NCHKDATE { get; set; }

    public string? DELFLAG { get; set; }

    public string? CRTDATE { get; set; }

    public string CRTORG { get; set; } = null!;

    public string? MODDATE { get; set; }

    public string MODUSERID { get; set; } = null!;

    public string MODUSERNAME { get; set; } = null!;

    public string? SORG { get; set; }
}
