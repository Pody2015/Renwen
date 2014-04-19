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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string keyName=this.txtkeyName.Text;
			string keyValue=this.txtkeyValue.Text;

			zs.Model.Tbl_Flex model=new zs.Model.Tbl_Flex();
			model.keyName=keyName;
			model.keyValue=keyValue;

			zs.BLL.Tbl_Flex bll=new zs.BLL.Tbl_Flex();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
