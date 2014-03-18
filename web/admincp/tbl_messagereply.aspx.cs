using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_tbl_messagereply : System.Web.UI.Page
{
    public string name = "";
    public string mail = "";
    public string tel = "";
    public string title = "";
    public string conts = "";
    public string asktime = "";
    public string id = "";
    public zs.BLL.Tbl_Message bll = new zs.BLL.Tbl_Message();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["userId"] == null || Request.Cookies["userId"].Value == "")
            Response.Redirect("./Login.aspx");
        BindData();
    }

    private void BindData()
    {
        if (Request.QueryString["id"] != null)
        {
            zs.Model.Tbl_Message model = bll.GetModel(int.Parse(Request.QueryString["id"].ToString()));
            name = model.name;
            mail = model.mail;
            tel = model.tel;
            title = model.title;
            conts = model.conts;
            id = model.id.ToString();
            asktime = model.askTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        zs.Model.Tbl_Message model = bll.GetModel(int.Parse(Request.QueryString["id"].ToString()));
        model.reply = this.TextBox1.Text.Trim();
        model.replyTime = DateTime.Now;
        model.isShow = 1;
        bll.Update(model);
        string content = "<p>亲爱的" + name + "同学:</p><p style='text-indent:2em;'>您好！</p><p style='text-indent:2em;'>您于[" + asktime + "]在浙江树人大学招生网留言咨询：“" + conts + "”。</p><p style='text-indent:2em;'>我们的答复是：“" + this.TextBox1.Text.Trim() + "”。</p><p style='text-indent:2em;'>感谢您的咨询，愿我们的答案能让您满意！在此祝您生活幸福，学业有成！</p><p style='text-indent:2em;color:red'>（此邮件由zs.zjsru.edu.cn自动发送，请勿回复！）</p>";
        this.Label1.Text = "回复成功！";
        this.Label1.Text += ApplicationMethod.send_mail(mail, "浙江树人大学招生网留言回复", content, "");
    }
}