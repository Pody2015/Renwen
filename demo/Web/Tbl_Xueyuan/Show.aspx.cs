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
namespace zs.Web.Tbl_Xueyuan
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
		zs.BLL.Tbl_Xueyuan bll=new zs.BLL.Tbl_Xueyuan();
		zs.Model.Tbl_Xueyuan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblnameen.Text=model.nameen;
		this.lbllogo.Text=model.logo;
		this.lblimage1.Text=model.image1;
		this.lblimage2.Text=model.image2;
		this.lblimage3.Text=model.image3;
		this.lblyuanzhang.Text=model.yuanzhang;
		this.lblconts.Text=model.conts;

	}


    }
}
