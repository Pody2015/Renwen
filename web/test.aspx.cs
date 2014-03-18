using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.Label1.Text= ApplicationMethod.send_mail("184460075@qq.com", "ceshi", "ceshi", "heixue2010@qq.com");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.Label1.Text = ApplicationMethod.encript(this.TextBox1.Text.Trim());
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = ApplicationMethod.decript(this.Label1.Text.Trim());
    }
}