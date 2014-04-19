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
namespace zs.Web.Tbl_Guide
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
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		zs.BLL.Tbl_Guide bll=new zs.BLL.Tbl_Guide();
		zs.Model.Tbl_Guide model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblpid.Text=model.pid.ToString();
		this.lblname.Text=model.name;
		this.lblurl.Text=model.url;
		this.lblsortid.Text=model.sortid.ToString();
		this.lbltype.Text=model.type;

	}


    }
}
