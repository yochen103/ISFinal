using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Login : System.Web.UI.Page
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
                           where Account = @Account
                           and Password = @Password 
                         ";
        dict.Add("Account", txtAccount.Text.Trim());
        dict.Add("Password", txtPassword.Text.Trim());

        DataTable dtLogin = DBConn.GetDataTableS(strSql, dict);
        
        if (dtLogin.Rows.Count > 0)
        {
            Response.Write("<script>alert('登入成功！')</script>");
            Response.Redirect("ShopList.aspx");
        }
        else
        {
            Response.Write("<script>alert('登入失敗！')</script>");
        }
    }

    
}