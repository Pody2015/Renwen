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
namespace zs.Web.Tbl_Message
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
		zs.BLL.Tbl_Message bll=new zs.BLL.Tbl_Message();
		zs.Model.Tbl_Message model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblmail.Text=model.mail;
		this.lbltel.Text=model.tel;
		this.lblconts.Text=model.conts;
		this.lblaskTime.Text=model.askTime.ToString();
		this.lblreply.Text=model.reply;
		this.lblreplyTime.Text=model.replyTime.ToString();
		this.lblisShow.Text=model.isShow.ToString();

	}


    }
}
