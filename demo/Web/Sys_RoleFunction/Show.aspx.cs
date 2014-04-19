using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace zs.Web.Sys_RoleFunction
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		zs.BLL.Sys_RoleFunction bll=new zs.BLL.Sys_RoleFunction();
		zs.Model.Sys_RoleFunction model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblRoleID.Text=model.RoleID.ToString();
		this.lblFunctionID.Text=model.FunctionID.ToString();

	}


    }
}
