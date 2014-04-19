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
namespace zs.Web.Tbl_Video
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		zs.BLL.Tbl_Video bll=new zs.BLL.Tbl_Video();
		zs.Model.Tbl_Video model=bll.GetModel();
		this.lblid.Text=model.id.ToString();
		this.lbltitle.Text=model.title;
		this.lblthumb.Text=model.thumb;
		this.lblconts.Text=model.conts;
		this.lbladdtime.Text=model.addtime.ToString();
		this.lblauthor.Text=model.author;
		this.lblleiid.Text=model.leiid.ToString();

	}


    }
}
