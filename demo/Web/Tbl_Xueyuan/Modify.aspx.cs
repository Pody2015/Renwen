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
namespace zs.Web.Tbl_Xueyuan
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
		zs.BLL.Tbl_Xueyuan bll=new zs.BLL.Tbl_Xueyuan();
		zs.Model.Tbl_Xueyuan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtnameen.Text=model.nameen;
		this.txtlogo.Text=model.logo;
		this.txtimage1.Text=model.image1;
		this.txtimage2.Text=model.image2;
		this.txtimage3.Text=model.image3;
		this.txtyuanzhang.Text=model.yuanzhang;
		this.txtconts.Text=model.conts;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtnameen.Text.Trim().Length==0)
			{
				strErr+="nameen不能为空！\\n";	
			}
			if(this.txtlogo.Text.Trim().Length==0)
			{
				strErr+="logo不能为空！\\n";	
			}
			if(this.txtimage1.Text.Trim().Length==0)
			{
				strErr+="image1不能为空！\\n";	
			}
			if(this.txtimage2.Text.Trim().Length==0)
			{
				strErr+="image2不能为空！\\n";	
			}
			if(this.txtimage3.Text.Trim().Length==0)
			{
				strErr+="image3不能为空！\\n";	
			}
			if(this.txtyuanzhang.Text.Trim().Length==0)
			{
				strErr+="yuanzhang不能为空！\\n";	
			}
			if(this.txtconts.Text.Trim().Length==0)
			{
				strErr+="conts不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			string nameen=this.txtnameen.Text;
			string logo=this.txtlogo.Text;
			string image1=this.txtimage1.Text;
			string image2=this.txtimage2.Text;
			string image3=this.txtimage3.Text;
			string yuanzhang=this.txtyuanzhang.Text;
			string conts=this.txtconts.Text;


			zs.Model.Tbl_Xueyuan model=new zs.Model.Tbl_Xueyuan();
			model.id=id;
			model.name=name;
			model.nameen=nameen;
			model.logo=logo;
			model.image1=image1;
			model.image2=image2;
			model.image3=image3;
			model.yuanzhang=yuanzhang;
			model.conts=conts;

			zs.BLL.Tbl_Xueyuan bll=new zs.BLL.Tbl_Xueyuan();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
