using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShopDetail : System.Web.UI.Page
{
    public static Page page { get { return HttpContext.Current.CurrentHandler as Page; } }
    protected void Page_Load(object sender, EventArgs e)
    {
        HFD_MID.Value = GetQueryString("MID");

        Dictionary<string, object> dict = new Dictionary<string, object>();

        string strSql = @" select Name as  [商品名稱] ,
                                  Price as [商品價格]
                           from Merchandise
                           where ID = @ID
                         ";
        dict.Add("ID", HFD_MID.Value);
        DataTable dtLogin = DBConn.GetDataTableS(strSql, dict);
        DataRow drLogin = dtLogin.Rows[0];
        lblName.Text = drLogin["商品名稱"].ToString();
    }

    public static string GetQueryString(string ItemName)
    {
        string retString = "";
        try
        {
            retString = page.Request.QueryString[ItemName].ToString();
        }
        catch
        {
            retString = "";

        }
        return retString;
    }
}