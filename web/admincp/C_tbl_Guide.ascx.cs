using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_C_tbl_Guide : System.Web.UI.UserControl
{
    zs.BLL.Tbl_Guide bll = new zs.BLL.Tbl_Guide();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        this.ASPxGridView1.DataSource = bll.GetModelList("pid=0");
        this.ASPxGridView1.DataBind();

    }
    protected void ASPxGridView2_DataBinding(object sender, EventArgs e)
    {
        DevExpress.Web.ASPxGridView.ASPxGridView grid = sender as DevExpress.Web.ASPxGridView.ASPxGridView;

        if (grid != null)
        {
            int i = (int)grid.GetMasterRowKeyValue();/*取主表记录的Key，主表grid必须设定KeyFieldName*/

            if (i >= 0)
            {
                grid.DataSource = bll.GetModelList("pid=" + i);//通过Key定位数据，指定子表数据源            
            }
        }
    }
    protected void ASPxGridView3_DataBinding(object sender, EventArgs e)
    {
        DevExpress.Web.ASPxGridView.ASPxGridView grid = sender as DevExpress.Web.ASPxGridView.ASPxGridView;

        if (grid != null)
        {
            int i = (int)grid.GetMasterRowKeyValue();/*取主表记录的Key，主表grid必须设定KeyFieldName*/

            if (i >= 0)
            {
                grid.DataSource = bll.GetModelList("pid=" + i);//通过Key定位数据，指定子表数据源            
            }
        }
    }
    protected void ASPxGridView1_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        string id = e.Keys[0].ToString();
        bll.Delete(int.Parse(id));
        e.Cancel = true;
    }
    protected void ASPxGridView1_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //取值 用e.NewValues[索引]
        string pid = e.NewValues[1].ToString();
        string name = e.NewValues[2].ToString();
        string url = e.NewValues[3].ToString();
        string sortid = e.NewValues[4].ToString();
        string type = e.NewValues[5].ToString();
        zs.Model.Tbl_Guide model = new zs.Model.Tbl_Guide();
        model.pid = int.Parse(pid);
        model.name = name;
        model.sortid = int.Parse(sortid);
        model.type = type;
        model.url = url;
        bll.Add(model);
        e.Cancel = true;
        ASPxGridView1.CancelEdit();//结束编辑状态
    }
    protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        string id = e.NewValues[0].ToString();
        string pid = e.NewValues[1].ToString();
        string name = e.NewValues[2].ToString();
        string url = e.NewValues[3].ToString();
        string sortid = e.NewValues[4].ToString();
        string type = e.NewValues[5].ToString();
        zs.Model.Tbl_Guide model = bll.GetModel(int.Parse(id));
        model.pid = int.Parse(pid);
        model.name = name;
        model.sortid = int.Parse(sortid);
        model.type = type;
        model.url = url;
        bll.Update(model);
        e.Cancel = true;
        ASPxGridView1.CancelEdit();//结束编辑状态
    }
}