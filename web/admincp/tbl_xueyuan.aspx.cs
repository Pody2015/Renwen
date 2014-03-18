using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class admincp_tbl_xueyuan : System.Web.UI.Page
{
    zs.BLL.Tbl_Xueyuan bll = new zs.BLL.Tbl_Xueyuan();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        if (Request.QueryString["id"] != null)
        {
            zs.Model.Tbl_Xueyuan model = bll.GetModel(int.Parse(Request.QueryString["id"].ToString()));
            this.tb_name.Text = model.name;
            this.tb_nameen.Text = model.nameen;
            this.ASPxHtmlEditor_yuanzhang.Html = model.yuanzhang;
            this.ASPxHtmlEditor_conts.Html = model.conts;
            this.btn_add.Text = "修改信息";
        }
    }

    public string GetXueyuanList()
    {
        List<zs.Model.Tbl_Xueyuan> models = bll.GetModelList("");
        StringBuilder sb = new StringBuilder();
        foreach (zs.Model.Tbl_Xueyuan model in models)
        {
            sb.Append("<li>");
            sb.Append("<a href='./tbl_xueyuan.aspx?id=" + model.id.ToString() + "'>");
            sb.Append(model.name + "</a></li>");
        }
        return sb.ToString();
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            zs.Model.Tbl_Xueyuan model = bll.GetModel(int.Parse(Request.QueryString["id"].ToString()));
            model.name = this.tb_name.Text;
            model.nameen = this.tb_nameen.Text;
            model.yuanzhang = this.ASPxHtmlEditor_yuanzhang.Html;
            model.conts = this.ASPxHtmlEditor_conts.Html;
            if (fu_logo.HasFile)
            {
                model.logo = UploadImage(fu_logo);
            }
            if (fu_image1.HasFile)
            {
                model.image1 = UploadImage(fu_image1);
            }
            if (fu_image2.HasFile)
            {
                model.image2 = UploadImage(fu_image2);
            }
            if (fu_image3.HasFile)
            {
                model.image3 = UploadImage(fu_image3);
            }
            bll.Update(model);
            this.Label1.Text = "修改成功！";
        }
        else
        {
            zs.Model.Tbl_Xueyuan model =new zs.Model.Tbl_Xueyuan();
            model.name = this.tb_name.Text;
            model.nameen = this.tb_nameen.Text;
            model.yuanzhang = this.ASPxHtmlEditor_yuanzhang.Html;
            model.conts = this.ASPxHtmlEditor_conts.Html;
            if (fu_logo.HasFile)
            {
                model.logo = UploadImage(fu_logo);
            }
            if (fu_image1.HasFile)
            {
                model.image1 = UploadImage(fu_image1);
            }
            if (fu_image2.HasFile)
            {
                model.image2 = UploadImage(fu_image2);
            }
            if (fu_image3.HasFile)
            {
                model.image3 = UploadImage(fu_image3);
            }
            bll.Add(model);
            this.Label1.Text = "保存成功！";
        }
    }

    private string UploadImage(FileUpload FU_Image)
    {
        Boolean fileOK = false;
        String path = Server.MapPath("../img/");
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
                Dir = "img/" + filepath.Replace("\\", "/");
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