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
namespace zs.Web.Sys_RoleFunction
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		zs.BLL.Sys_RoleFunction bll=new zs.BLL.Sys_RoleFunction();
		zs.Model.Sys_RoleFunction model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtRoleID.Text=model.RoleID.ToString();
		this.txtFunctionID.Text=model.FunctionID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtRoleID.Text))
			{
				strErr+="RoleID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFunctionID.Text))
			{
				strErr+="FunctionID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int RoleID=int.Parse(this.txtRoleID.Text);
			int FunctionID=int.Parse(this.txtFunctionID.Text);


			zs.Model.Sys_RoleFunction model=new zs.Model.Sys_RoleFunction();
			model.ID=ID;
			model.RoleID=RoleID;
			model.FunctionID=FunctionID;

			zs.BLL.Sys_RoleFunction bll=new zs.BLL.Sys_RoleFunction();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
