using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_sysAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        zs.BLL.Tbl_User bll = new zs.BLL.Tbl_User();
        this.Repeater1.DataSource = bll.GetAllList();
        this.Repeater1.DataBind();
        createData();
    }

    private void createData()
    {
        zs.BLL.Sys_Role bllr=new zs.BLL.Sys_Role();
        zs.BLL.Sys_UserRole bllur = new zs.BLL.Sys_UserRole();
        zs.Model.Sys_UserRole model = new zs.Model.Sys_UserRole();
        foreach (RepeaterItem ri in Repeater1.Items)
        {
            (ri.FindControl("ddl_role") as DropDownList).DataSource = bllr.GetModelList("");
            (ri.FindControl("ddl_role") as DropDownList).DataTextField = "RoleName";
            (ri.FindControl("ddl_role") as DropDownList).DataValueField = "ID";
            (ri.FindControl("ddl_role") as DropDownList).DataBind();
            //(ri.FindControl("ddl_role") as DropDownList).SelectedValue = 
            string userId = (ri.FindControl("HiddenField1") as HiddenField).Value;
            if (bllur.GetModelList("UserID=" + userId).Count > 0)
            {
                model = bllur.GetModelList("UserID=" + userId)[0];
                (ri.FindControl("ddl_role") as DropDownList).SelectedValue = model.RoleID.Value.ToString();
            }
            
        }
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        
    }
    protected void btn_Add_Click(object sender, EventArgs e)
    {

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            zs.BLL.Tbl_User bll = new zs.BLL.Tbl_User();
            bll.Delete(int.Parse(e.CommandArgument.ToString()));
            BindData();
        }
    }
}