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
namespace zs.Web.Tbl_Message
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
		zs.BLL.Tbl_Message bll=new zs.BLL.Tbl_Message();
		zs.Model.Tbl_Message model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtmail.Text=model.mail;
		this.txttel.Text=model.tel;
		this.txtconts.Text=model.conts;
		this.txtaskTime.Text=model.askTime.ToString();
		this.txtreply.Text=model.reply;
		this.txtreplyTime.Text=model.replyTime.ToString();
		this.txtisShow.Text=model.isShow.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtmail.Text.Trim().Length==0)
			{
				strErr+="mail不能为空！\\n";	
			}
			if(this.txttel.Text.Trim().Length==0)
			{
				strErr+="tel不能为空！\\n";	
			}
			if(this.txtconts.Text.Trim().Length==0)
			{
				strErr+="conts不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtaskTime.Text))
			{
				strErr+="askTime格式错误！\\n";	
			}
			if(this.txtreply.Text.Trim().Length==0)
			{
				strErr+="reply不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtreplyTime.Text))
			{
				strErr+="replyTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisShow.Text))
			{
				strErr+="是否显示格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			string mail=this.txtmail.Text;
			string tel=this.txttel.Text;
			string conts=this.txtconts.Text;
			DateTime askTime=DateTime.Parse(this.txtaskTime.Text);
			string reply=this.txtreply.Text;
			DateTime replyTime=DateTime.Parse(this.txtreplyTime.Text);
			int isShow=int.Parse(this.txtisShow.Text);


			zs.Model.Tbl_Message model=new zs.Model.Tbl_Message();
			model.id=id;
			model.name=name;
			model.mail=mail;
			model.tel=tel;
			model.conts=conts;
			model.askTime=askTime;
			model.reply=reply;
			model.replyTime=replyTime;
			model.isShow=isShow;

			zs.BLL.Tbl_Message bll=new zs.BLL.Tbl_Message();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
