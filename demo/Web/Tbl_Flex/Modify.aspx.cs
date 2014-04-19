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
namespace zs.Web.Tbl_Flex
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
		zs.BLL.Tbl_Flex bll=new zs.BLL.Tbl_Flex();
		zs.Model.Tbl_Flex model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtkeyName.Text=model.keyName;
		this.txtkeyValue.Text=model.keyValue;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtkeyName.Text.Trim().Length==0)
			{
				strErr+="keyName不能为空！\\n";	
			}
			if(this.txtkeyValue.Text.Trim().Length==0)
			{
				strErr+="keyValue不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string keyName=this.txtkeyName.Text;
			string keyValue=this.txtkeyValue.Text;


			zs.Model.Tbl_Flex model=new zs.Model.Tbl_Flex();
			model.id=id;
			model.keyName=keyName;
			model.keyValue=keyValue;

			zs.BLL.Tbl_Flex bll=new zs.BLL.Tbl_Flex();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
