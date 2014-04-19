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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace zs.Web.Tbl_User
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		zs.BLL.Tbl_User bll=new zs.BLL.Tbl_User();
		zs.Model.Tbl_User model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuserName.Text=model.userName;
		this.txtuserPsw.Text=model.userPsw;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuserName.Text.Trim().Length==0)
			{
				strErr+="userName不能为空！\\n";	
			}
			if(this.txtuserPsw.Text.Trim().Length==0)
			{
				strErr+="userPsw不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string userName=this.txtuserName.Text;
			string userPsw=this.txtuserPsw.Text;


			zs.Model.Tbl_User model=new zs.Model.Tbl_User();
			model.id=id;
			model.userName=userName;
			model.userPsw=userPsw;

			zs.BLL.Tbl_User bll=new zs.BLL.Tbl_User();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
