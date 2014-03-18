using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_tbl_videoadd : System.Web.UI.Page
{
    zs.BLL.Tbl_Video bll = new zs.BLL.Tbl_Video();
    public string cont = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["userId"] == null || Request.Cookies["userId"].Value == "")
            Response.Redirect("./Login.aspx");
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        zs.BLL.Tbl_Guide bllg = new zs.BLL.Tbl_Guide();
        this.ddl_leiid.DataSource = bllg.GetModelList("type='video'");
        this.ddl_leiid.DataTextField = "name";
        this.ddl_leiid.DataValueField = "id";
        this.ddl_leiid.DataBind();
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_Video model = bll.GetModel(int.Parse(ids));
                this.tb_title.Text = model.title;
                this.tb_author.Text = model.author;
                this.tb_videourl.Text = model.videourl;
                
                this.ddl_leiid.SelectedItem.Value = model.leiid.Value.ToString();
                cont = model.conts;
                this.btn_add.Text = "修改";
            }
        }

    }

    protected void btn_add_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string ids = Request.QueryString["id"].ToString();
            if (ids != "0")
            {
                zs.Model.Tbl_Video model = bll.GetModel(int.Parse(ids));
                model.title = this.tb_title.Text.Trim();
                model.author = this.tb_author.Text.Trim();
                model.videourl = this.tb_videourl.Text.Trim();
                if (this.fu_thumb.HasFile)
                {
                    model.thumb = UploadImage(this.fu_thumb);
                }
                model.leiid = int.Parse(this.ddl_leiid.SelectedValue);
                model.addtime = DateTime.Now;
                model.conts = Request.Form["myValue"].ToString();
                bll.Update(model);
                BindData();
            }
            else
            {
                zs.Model.Tbl_Video model = new zs.Model.Tbl_Video();
                model.title = this.tb_title.Text.Trim();
                model.author = this.tb_author.Text.Trim();
                model.videourl = this.tb_videourl.Text.Trim();
                if (this.fu_thumb.HasFile)
                {
                    model.thumb = UploadImage(this.fu_thumb);
                }
                model.leiid = int.Parse(this.ddl_leiid.SelectedValue);
                model.addtime = DateTime.Now;
                model.conts = Request.Form["myValue"].ToString();
                bll.Add(model);
            }
        }
    }
    private string UploadImage(FileUpload FU_Image)
    {
        Boolean fileOK = false;
        String path = Server.MapPath("../img/thumb/");
        string Dir = "";
        String fileExtension = "";
        if (FU_Image.HasFile)
        {
            fileExtension = System.IO.Path.GetExtension(FU_Image.FileName).ToLower();
            String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (fileExtension == allowedExtensions[i])
                {
                    fileOK = true;
                }
            }
        }
        if (fileOK)
        {
            try
            {
                string filepath = DateTime.Now.ToString("yyyyMMddhhmmssfff") + fileExtension;
                FU_Image.PostedFile.SaveAs(path + filepath);
                Dir = "img/thumb/" + filepath.Replace("\\", "/");
                //Label1.Text = "File uploaded!";
            }
            catch (Exception ex)
            {
                //Label1.Text = "File could not be uploaded.";
            }
        }
        else
        {
            //Label1.Text = "Cannot accept files of this type.";
        }
        return Dir;
    }
}