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
        

    }
    
}