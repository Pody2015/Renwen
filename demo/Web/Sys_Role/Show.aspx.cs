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
namespace zs.Web.Sys_Role
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
		zs.BLL.Sys_Role bll=new zs.BLL.Sys_Role();
		zs.Model.Sys_Role model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblRoleName.Text=model.RoleName;
		this.lblDescription.Text=model.Description;
		this.lblvalidateDate.Text=model.validateDate.ToString();

	}


    }
}
