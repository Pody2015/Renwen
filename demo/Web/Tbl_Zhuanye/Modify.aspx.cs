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
namespace zs.Web.Tbl_Zhuanye
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
		zs.BLL.Tbl_Zhuanye bll=new zs.BLL.Tbl_Zhuanye();
		zs.Model.Tbl_Zhuanye model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtcont.Text=model.cont;
		this.txtxueyuanid.Text=model.xueyuanid.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtcont.Text.Trim().Length==0)
			{
				strErr+="cont不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtxueyuanid.Text))
			{
				strErr+="xueyuanid格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			string cont=this.txtcont.Text;
			int xueyuanid=int.Parse(this.txtxueyuanid.Text);


			zs.Model.Tbl_Zhuanye model=new zs.Model.Tbl_Zhuanye();
			model.id=id;
			model.name=name;
			model.cont=cont;
			model.xueyuanid=xueyuanid;

			zs.BLL.Tbl_Zhuanye bll=new zs.BLL.Tbl_Zhuanye();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
