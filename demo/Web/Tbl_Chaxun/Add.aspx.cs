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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string name=this.txtname.Text;
			string stuno=this.txtstuno.Text;
			string ksno=this.txtksno.Text;
			string cardid=this.txtcardid.Text;
			string score=this.txtscore.Text;
			string luquxueyuan=this.txtluquxueyuan.Text;
			string luquzhuanye=this.txtluquzhuanye.Text;
			string kstype=this.txtkstype.Text;

			zs.Model.Tbl_Chaxun model=new zs.Model.Tbl_Chaxun();
			model.name=name;
			model.stuno=stuno;
			model.ksno=ksno;
			model.cardid=cardid;
			model.score=score;
			model.luquxueyuan=luquxueyuan;
			model.luquzhuanye=luquzhuanye;
			model.kstype=kstype;

			zs.BLL.Tbl_Chaxun bll=new zs.BLL.Tbl_Chaxun();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
