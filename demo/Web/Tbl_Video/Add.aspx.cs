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
namespace zs.Web.Tbl_Video
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtid.Text))
			{
				strErr+="id格式错误！\\n";	
			}
			if(this.txttitle.Text.Trim().Length==0)
			{
				strErr+="title不能为空！\\n";	
			}
			if(this.txtthumb.Text.Trim().Length==0)
			{
				strErr+="thumb不能为空！\\n";	
			}
			if(this.txtconts.Text.Trim().Length==0)
			{
				strErr+="conts不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtaddtime.Text))
			{
				strErr+="addtime格式错误！\\n";	
			}
			if(this.txtauthor.Text.Trim().Length==0)
			{
				strErr+="author不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtleiid.Text))
			{
				strErr+="leiid格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.txtid.Text);
			string title=this.txttitle.Text;
			string thumb=this.txtthumb.Text;
			string conts=this.txtconts.Text;
			DateTime addtime=DateTime.Parse(this.txtaddtime.Text);
			string author=this.txtauthor.Text;
			int leiid=int.Parse(this.txtleiid.Text);

			zs.Model.Tbl_Video model=new zs.Model.Tbl_Video();
			model.id=id;
			model.title=title;
			model.thumb=thumb;
			model.conts=conts;
			model.addtime=addtime;
			model.author=author;
			model.leiid=leiid;

			zs.BLL.Tbl_Video bll=new zs.BLL.Tbl_Video();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
