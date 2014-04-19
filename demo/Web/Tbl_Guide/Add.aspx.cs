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
namespace zs.Web.Tbl_Guide
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtpid.Text))
			{
				strErr+="pid格式错误！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txturl.Text.Trim().Length==0)
			{
				strErr+="url不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsortid.Text))
			{
				strErr+="sortid格式错误！\\n";	
			}
			if(this.txttype.Text.Trim().Length==0)
			{
				strErr+="type不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int pid=int.Parse(this.txtpid.Text);
			string name=this.txtname.Text;
			string url=this.txturl.Text;
			int sortid=int.Parse(this.txtsortid.Text);
			string type=this.txttype.Text;

			zs.Model.Tbl_Guide model=new zs.Model.Tbl_Guide();
			model.pid=pid;
			model.name=name;
			model.url=url;
			model.sortid=sortid;
			model.type=type;

			zs.BLL.Tbl_Guide bll=new zs.BLL.Tbl_Guide();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
