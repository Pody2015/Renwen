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
namespace zs.Web.Sys_Function
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
		zs.BLL.Sys_Function bll=new zs.BLL.Sys_Function();
		zs.Model.Sys_Function model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblFunctionName.Text=model.FunctionName;
		this.lblFunctionDescription.Text=model.FunctionDescription;
		this.lblType.Text=model.Type;
		this.lblAssembly.Text=model.Assembly;
		this.lblValidateDate.Text=model.ValidateDate.ToString();

	}


    }
}
