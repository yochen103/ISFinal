using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NoDLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginCheck();
    }
    private void LoginCheck()
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();
        string strSql = @" select * from MEMBER
                           where Account = '" + txtAccount.Text.Trim() + "'" +
                           " and Password = '" + txtPassword.Text.Trim() + "'";
        //dict.Add("Account", txtAccount.Text.Trim());
        //dict.Add("Password", txtPassword.Text.Trim());

        DataTable dtLogin = DBConn.GetDataTableS(strSql, dict);

        if (dtLogin.Rows.Count > 0)
        {
            Response.Write("<script>alert('登入成功！')</script>");
            Response.Redirect("NoDShopList.aspx");
        }
        else
        {
            Response.Write("<script>alert('登入失敗！')</script>");
        }
    }
}