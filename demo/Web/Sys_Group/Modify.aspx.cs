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
namespace zs.Web.Sys_Group
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
		zs.BLL.Sys_Group bll=new zs.BLL.Sys_Group();
		zs.Model.Sys_Group model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtType.Text=model.Type;
		this.txtGroupName.Text=model.GroupName;
		this.txtPID.Text=model.PID.ToString();
		this.txtIDPath.Text=model.IDPath;
		this.txtNamePath.Text=model.NamePath;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtType.Text.Trim().Length==0)
			{
				strErr+="Type不能为空！\\n";	
			}
			if(this.txtGroupName.Text.Trim().Length==0)
			{
				strErr+="GroupName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPID.Text))
			{
				strErr+="PID格式错误！\\n";	
			}
			if(this.txtIDPath.Text.Trim().Length==0)
			{
				strErr+="IDPath不能为空！\\n";	
			}
			if(this.txtNamePath.Text.Trim().Length==0)
			{
				strErr+="NamePath不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string Type=this.txtType.Text;
			string GroupName=this.txtGroupName.Text;
			int PID=int.Parse(this.txtPID.Text);
			string IDPath=this.txtIDPath.Text;
			string NamePath=this.txtNamePath.Text;


			zs.Model.Sys_Group model=new zs.Model.Sys_Group();
			model.ID=ID;
			model.Type=Type;
			model.GroupName=GroupName;
			model.PID=PID;
			model.IDPath=IDPath;
			model.NamePath=NamePath;

			zs.BLL.Sys_Group bll=new zs.BLL.Sys_Group();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
