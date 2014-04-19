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
namespace zs.Web.Sys_Function
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
		zs.BLL.Sys_Function bll=new zs.BLL.Sys_Function();
		zs.Model.Sys_Function model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtFunctionName.Text=model.FunctionName;
		this.txtFunctionDescription.Text=model.FunctionDescription;
		this.txtType.Text=model.Type;
		this.txtAssembly.Text=model.Assembly;
		this.txtValidateDate.Text=model.ValidateDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFunctionName.Text.Trim().Length==0)
			{
				strErr+="FunctionName不能为空！\\n";	
			}
			if(this.txtFunctionDescription.Text.Trim().Length==0)
			{
				strErr+="FunctionDescription不能为空！\\n";	
			}
			if(this.txtType.Text.Trim().Length==0)
			{
				strErr+="Type不能为空！\\n";	
			}
			if(this.txtAssembly.Text.Trim().Length==0)
			{
				strErr+="Assembly不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtValidateDate.Text))
			{
				strErr+="ValidateDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string FunctionName=this.txtFunctionName.Text;
			string FunctionDescription=this.txtFunctionDescription.Text;
			string Type=this.txtType.Text;
			string Assembly=this.txtAssembly.Text;
			DateTime ValidateDate=DateTime.Parse(this.txtValidateDate.Text);


			zs.Model.Sys_Function model=new zs.Model.Sys_Function();
			model.ID=ID;
			model.FunctionName=FunctionName;
			model.FunctionDescription=FunctionDescription;
			model.Type=Type;
			model.Assembly=Assembly;
			model.ValidateDate=ValidateDate;

			zs.BLL.Sys_Function bll=new zs.BLL.Sys_Function();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
