using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_WSVC_CHKLAB
{
    public int? Check_List_ID { get; set; }

    public int 物品稽查編號 { get; set; }

    public int? TPEPK { get; set; }

    public string? FLAG { get; set; }

    public string? ORG { get; set; }

    public string? CHKNO { get; set; }

    public string? BUSNO { get; set; }

    public string BMT_NO { get; set; } = null!;

    public string? PJNO { get; set; }

    public string? DAYLINE { get; set; }

    public string? CHKDATE { get; set; }

    public string? CHKSCR { get; set; }

    public string? CHKEDMAN { get; set; }

    public string? COMMAN { get; set; }

    public string? TEXTNO { get; set; }

    public string? LABFLAG { get; set; }

    public string? FACTORYLAB { get; set; }

    public string? PAYMONEY { get; set; }

    public string? PAYDATE { get; set; }

    public string? CHKGENSRC { get; set; }

    public string? DELFLAG { get; set; }

    public string? CRTDATE { get; set; }

    public string? MODDATE { get; set; }

    public string? MODUSERID { get; set; }

    public string MODUSERNAME { get; set; } = null!;

    public string? 物品編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? Z_NO { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? NUM { get; set; }

    public string? MEDBUSNO { get; set; }

    public string? MEDORG { get; set; }

    public string? VALIDDATE { get; set; }

    public string? TRANSFLAG { get; set; }

    public string? LAWRANG { get; set; }

    public string? RESULT { get; set; }

    public string? 處理情形_限期改善日期 { get; set; }

    public string? 處理情形_飭其收回重製 { get; set; }

    public string? 處理情形_禁止出售或沒收 { get; set; }

    public string? 處理情形_廢棄重量_公斤 { get; set; }

    public string? 處理情形_罰款金額 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 移外縣市編號 { get; set; }

    public string? INCOUNTRY { get; set; }

    public string? FMS備註 { get; set; }

    public string? 違規情節描述 { get; set; }

    public string? FMS處理情形 { get; set; }

    public string? SEND_DATE { get; set; }

    public string? SEND_TEXTNO { get; set; }

    public string? RECEIVE_DATE { get; set; }

    public string? RECEIVE_TEXTNO { get; set; }

    public string? BACKFLAG { get; set; }

    public string? BACKSRC { get; set; }

    public string? CHKMAN { get; set; }

    public string? FMAN { get; set; }

    public string? AUDMAN { get; set; }

    public string? 作業階段 { get; set; }

    public string? OPID { get; set; }

    public string? FINISHED { get; set; }

    public string? FDATE { get; set; }

    public string? LABM_NO { get; set; }

    public string? LABD_NO { get; set; }

    public string? LABDD_NO { get; set; }

    public string? RVALUE { get; set; }

    public string? LEGAL { get; set; }

    public string? SORG { get; set; }
}
