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
namespace zs.Web.Tbl_Page
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
		zs.BLL.Tbl_Page bll=new zs.BLL.Tbl_Page();
		zs.Model.Tbl_Page model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtconts.Text=model.conts;
		this.txtmetatags.Text=model.metatags;
		this.txtmetadescription.Text=model.metadescription;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtconts.Text.Trim().Length==0)
			{
				strErr+="conts不能为空！\\n";	
			}
			if(this.txtmetatags.Text.Trim().Length==0)
			{
				strErr+="metatags不能为空！\\n";	
			}
			if(this.txtmetadescription.Text.Trim().Length==0)
			{
				strErr+="metadescription不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			string conts=this.txtconts.Text;
			string metatags=this.txtmetatags.Text;
			string metadescription=this.txtmetadescription.Text;


			zs.Model.Tbl_Page model=new zs.Model.Tbl_Page();
			model.id=id;
			model.name=name;
			model.conts=conts;
			model.metatags=metatags;
			model.metadescription=metadescription;

			zs.BLL.Tbl_Page bll=new zs.BLL.Tbl_Page();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
