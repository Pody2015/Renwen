using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_tbl_newsadd : System.Web.UI.Page
{
    zs.BLL.Tbl_News bll = new zs.BLL.Tbl_News();
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
        zs.BLL.Tbl_Guide bllg = new zs.BLL.Tbl_Guide();
        this.ddl_leiid.DataSource = bllg.GetModelList("type='news'");
        this.ddl_leiid.DataTextField = "name";
        this.ddl_leiid.DataValueField = "id";
        this.ddl_leiid.DataBind();
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_News model = bll.GetModel(int.Parse(ids));
                this.tb_title.Text = model.title;
                this.tb_author.Text = model.author;
                this.ddl_leiid.SelectedItem.Value = model.leiid.Value.ToString();
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
                zs.Model.Tbl_News model = bll.GetModel(int.Parse(ids));
                model.title = this.tb_title.Text.Trim();
                model.author = this.tb_author.Text.Trim();
                model.leiid = int.Parse(this.ddl_leiid.SelectedValue);
                model.addtime = DateTime.Now;
                model.conts = Request.Form["myValue"].ToString();
                bll.Update(model);
                BindData();
            }
            else
            {
                zs.Model.Tbl_News model = new zs.Model.Tbl_News();
                model.title = this.tb_title.Text.Trim();
                model.author = this.tb_author.Text.Trim();
                model.leiid = int.Parse(this.ddl_leiid.SelectedValue);
                model.addtime = DateTime.Now;
                model.conts = Request.Form["myValue"].ToString();
                bll.Add(model);
            }
        }
    }
}