using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_tbl_page : System.Web.UI.Page
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
        zs.BLL.Tbl_Page bll = new zs.BLL.Tbl_Page();
        this.Repeater1.DataSource = bll.GetAllList();
        this.Repeater1.DataBind();
    }
}