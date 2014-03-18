using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webpart_C_LastNews : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        InitData();
    }

    private void InitData()
    {
        zs.BLL.Tbl_News bll = new zs.BLL.Tbl_News();
        this.Repeater1.DataSource = bll.GetModelList("1=1",5,"id desc");
        this.Repeater1.DataBind();
    }
}