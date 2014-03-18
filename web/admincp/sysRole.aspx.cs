using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_sysRole : System.Web.UI.Page
{
    zs.BLL.Sys_Role bll = new zs.BLL.Sys_Role();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        gridView.DataSource = bll.GetList("1=1");
        gridView.DataBind();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string RoleName = this.txtRoleName.Text;
        string Description = this.txtDescription.Text;

        zs.Model.Sys_Role model = new zs.Model.Sys_Role();
        model.RoleName = RoleName;
        model.Description = Description;
        bll.Add(model);
        BindData();
    }

    private string GetSelIDlist()
    {
        string idlist = "";
        bool BxsChkd = false;
        for (int i = 0; i < gridView.Rows.Count; i++)
        {
            CheckBox ChkBxItem = (CheckBox)gridView.Rows[i].FindControl("DeleteThis");
            if (ChkBxItem != null && ChkBxItem.Checked)
            {
                BxsChkd = true;
                //#warning 代码生成警告：请检查确认Cells的列索引是否正确
                if (gridView.DataKeys[i].Value != null)
                {
                    idlist += gridView.DataKeys[i].Value.ToString() + ",";
                }
            }
        }
        if (BxsChkd)
        {
            idlist = idlist.Substring(0, idlist.LastIndexOf(","));
        }
        return idlist;
    }

    protected void gridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.gridView.EditIndex = -1;
        BindData();
    }
    protected void gridView_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.gridView.EditIndex = e.NewEditIndex;
        //((TextBox)this.GridView1.Rows[e.NewEditIndex].Cells[0].Controls[0]).Enabled = false;
        BindData();
    }
    protected void gridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id = gridView.DataKeys[e.RowIndex].Values[0].ToString();
        //string Sxh=GridView1.Rows[e.RowIndex].Cells[0].Text.Trim();
        string name = ((TextBox)gridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text.Trim();
        string desc = ((TextBox)gridView.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim();
        zs.Model.Sys_Role model = bll.GetModel(int.Parse(id));
        model.Description = desc;
        model.RoleName = name;
        bll.Update(model);
        gridView.EditIndex = -1;
        BindData();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string idlist = GetSelIDlist();
        if (idlist.Trim().Length == 0)
            return;
        bll.DeleteList(idlist);
        BindData();
    }
}