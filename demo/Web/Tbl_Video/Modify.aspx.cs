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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		zs.BLL.Tbl_Video bll=new zs.BLL.Tbl_Video();
		zs.Model.Tbl_Video model=bll.GetModel();
		this.txtid.Text=model.id.ToString();
		this.txttitle.Text=model.title;
		this.txtthumb.Text=model.thumb;
		this.txtconts.Text=model.conts;
		this.txtaddtime.Text=model.addtime.ToString();
		this.txtauthor.Text=model.author;
		this.txtleiid.Text=model.leiid.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
