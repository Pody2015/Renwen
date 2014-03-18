using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_sysRoleFunction : System.Web.UI.Page
{
    zs.BLL.Sys_Function bllf = new zs.BLL.Sys_Function();
    zs.BLL.Sys_RoleFunction bll = new zs.BLL.Sys_RoleFunction();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.ddl_Function.DataSource = bllf.GetModelList("1=1");
            this.ddl_Function.DataTextField = "FunctionDescription";
            this.ddl_Function.DataValueField = "ID";
            this.ddl_Function.DataBind();
            BindData();
        }
    }

    private void BindData()
    {
        this.Repeater1.DataSource = bll.GetModelList("RoleID=" + Request.QueryString["role"].ToString());
        this.Repeater1.DataBind();
        createData();
    }

    private void createData()
    {
        foreach (RepeaterItem ri in Repeater1.Items)
        {
            string Fid = (ri.FindControl("HiddenField1") as HiddenField).Value;

            (ri.FindControl("lb_FunctionName1") as Label).Text = bllf.GetModel(int.Parse(Fid)).FunctionDescription;
        }
    }

    protected void btn_AddFunction_Click(object sender, EventArgs e)
    {
        zs.Model.Sys_RoleFunction model = new zs.Model.Sys_RoleFunction();
        model.RoleID = int.Parse(Request.QueryString["role"].ToString());
        model.FunctionID = int.Parse(this.ddl_Function.SelectedItem.Value);
        bll.Add(model);
        BindData();
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            bll.Delete(int.Parse(e.CommandArgument.ToString()));
            BindData();
        }
    }
}