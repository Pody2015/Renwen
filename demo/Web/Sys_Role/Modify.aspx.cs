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
namespace zs.Web.Sys_Role
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
		zs.BLL.Sys_Role bll=new zs.BLL.Sys_Role();
		zs.Model.Sys_Role model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtRoleName.Text=model.RoleName;
		this.txtDescription.Text=model.Description;
		this.txtvalidateDate.Text=model.validateDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRoleName.Text.Trim().Length==0)
			{
				strErr+="RoleName不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtvalidateDate.Text))
			{
				strErr+="validateDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string RoleName=this.txtRoleName.Text;
			string Description=this.txtDescription.Text;
			DateTime validateDate=DateTime.Parse(this.txtvalidateDate.Text);


			zs.Model.Sys_Role model=new zs.Model.Sys_Role();
			model.ID=ID;
			model.RoleName=RoleName;
			model.Description=Description;
			model.validateDate=validateDate;

			zs.BLL.Sys_Role bll=new zs.BLL.Sys_Role();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
