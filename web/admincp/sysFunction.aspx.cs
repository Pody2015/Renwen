using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_sysFunction : System.Web.UI.Page
{
    zs.BLL.Sys_Function bll = new zs.BLL.Sys_Function();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindData("1=1");
        }
    }

    private void BindData(string sqlwhere)
    {
        gridView.DataSource = bll.GetList(sqlwhere);
        gridView.DataBind();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string strErr = "";
        if (this.txtFunctionName.Text.Trim().Length == 0)
        {
            strErr += "功能名称不能为空！\\n";
        }
        if (this.txtFunctionDescription.Text.Trim().Length == 0)
        {
            strErr += "显示不能为空！\\n";
        }
        if (this.txtAssembly.Text.Trim().Length == 0)
        {
            strErr += "路径不能为空！\\n";
        }

        if (strErr != "")
        {
            return;
        }
        string FunctionName = this.txtFunctionName.Text;
        string FunctionDescription = this.txtFunctionDescription.Text;
        string Type = "web";
        string Assembly = this.txtAssembly.Text;

        zs.Model.Sys_Function model = new zs.Model.Sys_Function();
        model.FunctionName = FunctionName;
        model.FunctionDescription = FunctionDescription;
        model.Type = Type;
        model.Assembly = Assembly;

        bll.Add(model);
        BindData("1=1");
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string idlist = GetSelIDlist();
        if (idlist.Trim().Length == 0)
            return;
        bll.DeleteList(idlist);
        BindData("1=1");
    }
    protected void gridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string id = gridView.DataKeys[e.RowIndex].Values[0].ToString();
        //string Sxh=GridView1.Rows[e.RowIndex].Cells[0].Text.Trim();
        string name = ((TextBox)gridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text.Trim();
        string desc = ((TextBox)gridView.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim();
        string assem = ((TextBox)gridView.Rows[e.RowIndex].Cells[3].Controls[0]).Text.Trim();
        zs.Model.Sys_Function model = bll.GetModel(int.Parse(id));
        model.FunctionName = name;
        model.FunctionDescription = desc;
        model.Assembly = assem;
        bll.Update(model);
        gridView.EditIndex = -1;
        BindData("1=1");
    }
    protected void gridView_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.gridView.EditIndex = e.NewEditIndex;
        BindData("1=1");
    }
    protected void gridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.gridView.EditIndex = -1;
        BindData("1=1");
    }

    protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridView.PageIndex = e.NewPageIndex;
        BindData("1=1");
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
}