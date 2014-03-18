using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_tbl_zhuanyeadd : System.Web.UI.Page
{
    zs.BLL.Tbl_Zhuanye bll = new zs.BLL.Tbl_Zhuanye();
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
        zs.BLL.Tbl_Xueyuan bllg = new zs.BLL.Tbl_Xueyuan();
        this.ddl_xueyuanid.DataSource = bllg.GetModelList("");
        this.ddl_xueyuanid.DataTextField = "name";
        this.ddl_xueyuanid.DataValueField = "id";
        this.ddl_xueyuanid.DataBind();
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_Zhuanye model = bll.GetModel(int.Parse(ids));
                this.tb_name.Text = model.name;
                this.tb_cont.Html = model.cont;
                this.ddl_xueyuanid.SelectedValue = model.xueyuanid.Value.ToString();
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
                zs.Model.Tbl_Zhuanye model = bll.GetModel(int.Parse(ids));
                model.name = this.tb_name.Text.Trim();
                model.cont = this.tb_cont.Html;
                model.xueyuanid = int.Parse(this.ddl_xueyuanid.SelectedValue);
                bll.Update(model);
                BindData();
            }
            else
            {
                zs.Model.Tbl_Zhuanye model = new zs.Model.Tbl_Zhuanye();
                model.name = this.tb_name.Text.Trim();
                model.cont = this.tb_cont.Html;
                model.xueyuanid = int.Parse(this.ddl_xueyuanid.SelectedValue);
                bll.Add(model);
            }
        }
    }
}