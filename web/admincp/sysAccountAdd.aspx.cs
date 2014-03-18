using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_sysAccountAdd : System.Web.UI.Page
{
    zs.BLL.Tbl_User bll = new zs.BLL.Tbl_User();
    zs.BLL.Sys_UserRole bllur = new zs.BLL.Sys_UserRole();
    zs.BLL.Sys_Role bllr = new zs.BLL.Sys_Role();
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
        this.ddl_role.DataSource = bllr.GetModelList("");
        this.ddl_role.DataTextField = "RoleName";
        this.ddl_role.DataValueField = "ID";
        this.ddl_role.DataBind();
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_User model = bll.GetModel(int.Parse(ids));
                this.tb_name.Text = model.userName;
                this.tb_Psw.Text = model.userPsw;
                this.ddl_role.SelectedValue = bllur.GetModelList("UserID="+ids)[0].RoleID.ToString();
                this.Button1.Text = "修改";
                ViewState["userid"] = ids;
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_User model = bll.GetModel(int.Parse(ids));
                model.userName = this.tb_name.Text.Trim();
                model.userPsw = ApplicationMethod.encript(this.tb_Psw.Text.Trim());
                bll.Update(model);
                ViewState["userid"] = ids;
            }
            else
            {
                zs.Model.Tbl_User model = new zs.Model.Tbl_User();
                model.userName = this.tb_name.Text.Trim();
                model.userPsw = ApplicationMethod.encript(this.tb_Psw.Text.Trim());
                bll.Add(model);
                ViewState["userid"] = bll.GetModelList("userName='" + this.tb_name.Text.Trim()+"'")[0].id;
            }
        }
    }
    protected void ddl_role_SelectedIndexChanged(object sender, EventArgs e)
    {
        zs.Model.Sys_UserRole model = new zs.Model.Sys_UserRole();
        string userId = ViewState["userid"].ToString();
        if (bllur.GetModelList("UserID=" + userId).Count > 0)
        {
            model = bllur.GetModelList("UserID=" + userId)[0];
            model.UserID = int.Parse(userId);
            model.RoleID = int.Parse(this.ddl_role.SelectedItem.Value);
            bllur.Update(model);
        }
        else
        {
            model.UserID = int.Parse(userId);
            model.RoleID = int.Parse(this.ddl_role.SelectedItem.Value);
            bllur.Add(model);
        }
    }
}