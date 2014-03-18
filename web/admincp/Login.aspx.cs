using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Login_Click(object sender, EventArgs e)
    {
        zs.BLL.Tbl_User blluser = new zs.BLL.Tbl_User();
        string userName = CheckInput(this.tb_userName.Text.Trim());
        string userPSW = CheckInput(this.tb_password.Text.Trim());
        if (blluser.Exists(userName))
        {//存在用户名
            if (blluser.GetModel(userName).userPsw == ApplicationMethod.encript(userPSW))
            {//密码正确
                Response.Cookies["userId"].Value = blluser.GetModel(userName).id.ToString();
                Response.Cookies["userName"].Value = blluser.GetModel(userName).userName;
                Response.Redirect("./Default.aspx");
            }
            else
            {//密码错误
                ClientScript.RegisterClientScriptBlock(this.GetType(), "showPError", "<script>alert('用户名密码不正确，请确认！')</script>");
            }
        }
        else
        {//用户名不存在
            ClientScript.RegisterClientScriptBlock(this.GetType(), "showUError", "<script>alert('用户名密码不正确，请确认！')</script>");
        }
    }
    public string CheckInput(string input)
    {
        input=input.Replace("-","").Replace(" ","").Replace("\\","").Replace("/","").Replace("'","");
        return input;
    }
}