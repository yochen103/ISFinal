using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShopList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();

        string strSql = @" select Name as 商品名稱,
                                  Price as 商品價格
                           from Merchandise
                           where Name like @Name
                         ";
        dict.Add("Name", "%" + txtSearch.Text.Trim() + "%");
        DataTable dtLogin = DBConn.GetDataTableS(strSql, dict);

        GVShopList.DataSource = dtLogin;
        GVShopList.DataBind();
    }

    protected void GVShopList_SelectedIndexChanged(object sender, EventArgs e)
    {
        int MID = GVShopList.SelectedIndex + 1;
        Response.Redirect("ShopDetail.aspx?MID=" + MID);
    }
}