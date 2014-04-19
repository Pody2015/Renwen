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
namespace zs.Web.Tbl_Chaxun
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
		zs.BLL.Tbl_Chaxun bll=new zs.BLL.Tbl_Chaxun();
		zs.Model.Tbl_Chaxun model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtstuno.Text=model.stuno;
		this.txtksno.Text=model.ksno;
		this.txtcardid.Text=model.cardid;
		this.txtscore.Text=model.score;
		this.txtluquxueyuan.Text=model.luquxueyuan;
		this.txtluquzhuanye.Text=model.luquzhuanye;
		this.txtkstype.Text=model.kstype;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="姓名不能为空！\\n";	
			}
			if(this.txtstuno.Text.Trim().Length==0)
			{
				strErr+="学号不能为空！\\n";	
			}
			if(this.txtksno.Text.Trim().Length==0)
			{
				strErr+="考试号不能为空！\\n";	
			}
			if(this.txtcardid.Text.Trim().Length==0)
			{
				strErr+="身份证号码不能为空！\\n";	
			}
			if(this.txtscore.Text.Trim().Length==0)
			{
				strErr+="分数（总分）不能为空！\\n";	
			}
			if(this.txtluquxueyuan.Text.Trim().Length==0)
			{
				strErr+="录取学院不能为空！\\n";	
			}
			if(this.txtluquzhuanye.Text.Trim().Length==0)
			{
				strErr+="录取专业不能为空！\\n";	
			}
			if(this.txtkstype.Text.Trim().Length==0)
			{
				strErr+="考试类别不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			string stuno=this.txtstuno.Text;
			string ksno=this.txtksno.Text;
			string cardid=this.txtcardid.Text;
			string score=this.txtscore.Text;
			string luquxueyuan=this.txtluquxueyuan.Text;
			string luquzhuanye=this.txtluquzhuanye.Text;
			string kstype=this.txtkstype.Text;


			zs.Model.Tbl_Chaxun model=new zs.Model.Tbl_Chaxun();
			model.id=id;
			model.name=name;
			model.stuno=stuno;
			model.ksno=ksno;
			model.cardid=cardid;
			model.score=score;
			model.luquxueyuan=luquxueyuan;
			model.luquzhuanye=luquzhuanye;
			model.kstype=kstype;

			zs.BLL.Tbl_Chaxun bll=new zs.BLL.Tbl_Chaxun();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
