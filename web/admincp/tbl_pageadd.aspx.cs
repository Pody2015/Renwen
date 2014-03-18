using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_tbl_pageadd : System.Web.UI.Page
{
    zs.BLL.Tbl_Page bll = new zs.BLL.Tbl_Page();
    public string cont = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["userId"] == null || Request.Cookies["userId"].Value == "")
            Response.Redirect("./Login.aspx");
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_Page model = bll.GetModel(int.Parse(ids));
                this.tb_name.Text = model.name;
                this.tb_tags.Text = model.metatags;
                this.tb_metadesc.Text = model.metadescription;
                cont = model.conts;
                this.btn_add.Text = "修改";
            }
        }
    }

    protected void btn_add_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_Page model = bll.GetModel(int.Parse(ids));
                model.name = this.tb_name.Text.Trim();
                model.metatags = this.tb_tags.Text.Trim();
                model.metadescription = ApplicationMethod.NoHtmlCode(this.tb_metadesc.Text.Trim(),80);
                model.conts = Request.Form["myValue"].ToString();
                bll.Update(model);
                BindData();
            }
            else
            {
                zs.Model.Tbl_Page model = new zs.Model.Tbl_Page();
                model.name = this.tb_name.Text.Trim();
                model.metatags = this.tb_tags.Text.Trim();
                model.metadescription = ApplicationMethod.NoHtmlCode(this.tb_metadesc.Text.Trim(),80);
                model.conts = Request.Form["myValue"].ToString();
                bll.Add(model);
            }
        }
    }
}