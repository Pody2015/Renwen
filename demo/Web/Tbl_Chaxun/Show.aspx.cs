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
namespace zs.Web.Tbl_Chaxun
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
		zs.BLL.Tbl_Chaxun bll=new zs.BLL.Tbl_Chaxun();
		zs.Model.Tbl_Chaxun model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblstuno.Text=model.stuno;
		this.lblksno.Text=model.ksno;
		this.lblcardid.Text=model.cardid;
		this.lblscore.Text=model.score;
		this.lblluquxueyuan.Text=model.luquxueyuan;
		this.lblluquzhuanye.Text=model.luquzhuanye;
		this.lblkstype.Text=model.kstype;

	}


    }
}
