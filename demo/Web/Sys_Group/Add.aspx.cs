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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string Type=this.txtType.Text;
			string GroupName=this.txtGroupName.Text;
			int PID=int.Parse(this.txtPID.Text);
			string IDPath=this.txtIDPath.Text;
			string NamePath=this.txtNamePath.Text;

			zs.Model.Sys_Group model=new zs.Model.Sys_Group();
			model.Type=Type;
			model.GroupName=GroupName;
			model.PID=PID;
			model.IDPath=IDPath;
			model.NamePath=NamePath;

			zs.BLL.Sys_Group bll=new zs.BLL.Sys_Group();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
