using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Trans_FTR_Main
{
    public string APPL_NO { get; set; } = null!;

    public string? APPL_REGCNAME { get; set; }

    public string? APPL_NAME { get; set; }

    public string? BRAND { get; set; }

    public string? APPL_DATE { get; set; }

    public string? IMP_DATE { get; set; }

    public string? Accept_Date { get; set; }

    public string? INSP_DATE { get; set; }

    public string? INSP_RESULT { get; set; }

    public string? INSP_RESULT_Name { get; set; }

    public string APPLNO_CUST { get; set; } = null!;

    public string? SUBMIT_Reason { get; set; }

    public string? SUBMIT_DATE { get; set; }

    public string? GOODS_ST_DATE { get; set; }

    public string? GOODS_GO_DATE { get; set; }

    public string? GOODS_IN_DATE { get; set; }

    public string? SUBMIT_PS_CODE { get; set; }

    public string? SUBMIT_PS_CODE_Name { get; set; }

    public string? USER_ID { get; set; }

    public string? MOD_DATE { get; set; }

    public DateTime? DataDate { get; set; }

    public int Expr2 { get; set; }

    public string? REMARK { get; set; }

    public string? MOD_TIME { get; set; }

    public string? GOODSNAME { get; set; }

    public string? GOODSNAME_E { get; set; }

    public string? SPEC { get; set; }

    public string? PRODUCTCOUNTRYName { get; set; }

    public string? PRODUCTCOUNTRY { get; set; }

    public decimal? DECLQUANTITY { get; set; }

    public string? IN_AMT_UNIT { get; set; }

    public double? IN_AMT { get; set; }

    public string? COMM_AMT_UNIT { get; set; }

    public string? GOODS_ST_CITY { get; set; }

    public string? GOODS_ST_CITY_Name { get; set; }

    public decimal? AMT { get; set; }

    public string? AMT_UNIT { get; set; }

    public string? GOODS_ST_ADDR { get; set; }

    public string? RETURN_DATE { get; set; }

    public string? NOTIFY_DATE { get; set; }

    public int? CN_Len { get; set; }

    public string? PLACE_REMARK { get; set; }

    public decimal PLACE_ID { get; set; }

    public string? RETURN_RESULT { get; set; }

    public string? RETURN_RESULT_Name { get; set; }

    public string CCCCODE { get; set; } = null!;
}
