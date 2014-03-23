using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Text;

public partial class admincp_tbl_chaxun : System.Web.UI.Page
{
    zs.BLL.Tbl_Chaxun bll = new zs.BLL.Tbl_Chaxun();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            BindData();

    }

    private void BindData()
    {
        UsersBind(bll.GetModelList(""),15);
    }

    private void UsersBind(List<zs.Model.Tbl_Chaxun> userList, int pageSize)//repeater分页并绑定
    {
        try
        {
            PagedDataSource objPage = new PagedDataSource();
            objPage.DataSource = userList;
            objPage.AllowPaging = true;
            objPage.PageSize = pageSize;
            int CurPage;
            if (Request.QueryString["page"] != null)
            {
                CurPage = Convert.ToInt32(Request.QueryString["page"]);
            }
            else
            {
                CurPage = 1;
            }
            objPage.CurrentPageIndex = CurPage - 1;
            Repeater1.DataSource = objPage;
            Repeater1.DataBind();
            RecordCount.Text = objPage.DataSourceCount.ToString();
            PageCount.Text = objPage.PageCount.ToString();
            Pageindex.Text = CurPage.ToString();
            Literal1.Text = PageList(objPage.PageCount, CurPage);

            FirstPage.NavigateUrl = Request.CurrentExecutionFilePath + "?page=1";
            PrevPage.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + (CurPage - 1);
            NextPage.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + (CurPage + 1);
            LastPaeg.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + objPage.PageCount.ToString();
            if (CurPage <= 1 && objPage.PageCount <= 1)
            {
                FirstPage.NavigateUrl = "";
                PrevPage.NavigateUrl = "";
                NextPage.NavigateUrl = "";
                LastPaeg.NavigateUrl = "";
            }
            if (CurPage <= 1 && objPage.PageCount > 1)
            {
                FirstPage.NavigateUrl = "";
                PrevPage.NavigateUrl = "";
            }
            if (CurPage >= objPage.PageCount)
            {
                NextPage.NavigateUrl = "";
                LastPaeg.NavigateUrl = "";
            }
        }
        catch (Exception error)
        {
            Response.Write(error.ToString());
        }
        finally
        {

        }
    }

    private string PageList(int Pagecount, int Pageindex)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<select id=\"Page_Jump\" name=\"Page_Jump\" onchange=\"window.location='" + Request.CurrentExecutionFilePath + "?page='+ this.options[this.selectedIndex].value + '';\">");

        for (int i = 1; i <= Pagecount; i++)
        {
            if (Pageindex == i)
                sb.Append("<option value='" + i + "' selected>" + i + "</option>");
            else
                sb.Append("<option value='" + i + "'>" + i + "</option>");
        }
        sb.Append("</select>");
        return sb.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Dim filename, folder, SaveFilename, SaveFilePath As String
        string filename, folder, SaveFilename, SaveFilePath;
        //'Check if file is valid and upload
        if (FileUPexcel.HasFile)
        {
            string extension = System.IO.Path.GetExtension(FileUPexcel.PostedFile.FileName);
            if (extension.ToLower() != "xls")
                this.lb_Result.Text = "请选择Excel文件！";
            filename = System.IO.Path.GetFileNameWithoutExtension(FileUPexcel.PostedFile.FileName);
            folder = Server.MapPath("../import");
            SaveFilename = filename + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + extension;
            SaveFilePath = folder + "\\" + SaveFilename;
            try
            {
                FileUPexcel.PostedFile.SaveAs(SaveFilePath);
            }
            catch (Exception ex)
            {
                this.lb_Result.Text = ex.Message;
                return;
            }
        }
        else
        {
            this.lb_Result.Text = "请选择上传文件！";
            return;
        }
        import_data(SaveFilePath);
        call_excel_quit();
        try
        {
            System.IO.File.Delete(SaveFilePath);
        }
        catch (Exception ex)
        {
            this.lb_Result.Text += ex.Message + "  文件删除失败，这不影响数据导入，但可能泄漏学生隐私信息，请登录服务器删除！";
        }
    }

    private void call_excel_quit()
    {
        //try
        //{
        //    //ExcelWB.close();
        //    //NAR(ExcelWB);
        //}
        //Try
        //    ExcelWB.close()
        //    ExcelApp.Quit()
        //    ExcelSheet = Nothing
        //    ExcelWB = Nothing
        //    ExcelApp = Nothing
        //    NAR(ExcelSheet)
        //    NAR(ExcelWB)
        //    NAR(ExcelApp)

        //    GC.Collect()
        //    GC.WaitForPendingFinalizers()
        //Catch ex As Exception
        //End Try
    }

    private void import_data(string filepath)
    {
        System.Data.OleDb.OleDbConnection ExcelConn = new OleDbConnection();
        System.Data.OleDb.OleDbDataAdapter ExcelAdpt = null;
        DataSet Excelds = new DataSet();
        //DataRow ExcelRow = new DataRow();
        string sql = "";
        try
        {
            ExcelConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";
            ExcelConn.Open();
            sql = "select * from [student$]";
            ExcelAdpt = new OleDbDataAdapter(sql, ExcelConn);
            ExcelAdpt.AcceptChangesDuringFill = true;
            ExcelAdpt.Fill(Excelds);
            run_upload_data(Excelds);
        }
        catch (Exception ex)
        {
            this.lb_Result.Text = ex.Message;
        }
        finally
        {
            //Excelds.Dispose();
            //ExcelAdpt.Dispose();
            ExcelConn.Close();
        }
    }

    private void run_upload_data(DataSet Excelds)
    {
        int i = 0;
        string name = "";
        string stuno = "";
        string ksno = "";
        string CardID = "";
        string score = "";
        string luquxueyuan = "";
        string luquzhuanye = "";
        string kstype = "";
        zs.Model.Tbl_Chaxun chaxun = new zs.Model.Tbl_Chaxun();
        //PJXT.Model.teacher teacher = new PJXT.Model.teacher();
        //PJXT.Model.classes classes = new PJXT.Model.classes();
        //PJXT.Model.student student = new PJXT.Model.student();
        while (i < Excelds.Tables[0].Rows.Count)
        {
            name = Excelds.Tables[0].Rows[i][0].ToString();
            stuno = Excelds.Tables[0].Rows[i][1].ToString();
            ksno = Excelds.Tables[0].Rows[i][2].ToString();
            CardID = Excelds.Tables[0].Rows[i][3].ToString();
            score = Excelds.Tables[0].Rows[i][4].ToString();
            luquxueyuan = Excelds.Tables[0].Rows[i][5].ToString();
            luquzhuanye = Excelds.Tables[0].Rows[i][6].ToString();
            kstype = Excelds.Tables[0].Rows[i][7].ToString();
            if (bll.GetModelList("cardid='" + CardID + "'").Count > 0)
            {
                chaxun = bll.GetModelList("cardid='" + CardID + "'")[0];
                chaxun.name = name;
                chaxun.stuno = stuno;
                chaxun.ksno = ksno;
                chaxun.cardid = CardID;
                chaxun.score = score;
                chaxun.luquxueyuan = luquxueyuan;
                chaxun.luquzhuanye = luquzhuanye;
                chaxun.kstype = kstype;
                bll.Update(chaxun);
            }
            else
            {
                chaxun.name = name;
                chaxun.stuno = stuno;
                chaxun.ksno = ksno;
                chaxun.cardid = CardID;
                chaxun.score = score;
                chaxun.luquxueyuan = luquxueyuan;
                chaxun.luquzhuanye = luquzhuanye;
                chaxun.kstype = kstype;
                bll.Add(chaxun);
            }
            i++;
        }
        this.lb_Result.Text = "共新增数据：" + i + "条。";
        BindData();
        //Allusers.WriteLogsFile("管理员,导入学生" + i + "个成功!IP:" + Request.UserHostAddress.ToString());
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            bll.Delete(int.Parse(e.CommandArgument.ToString()));
            BindData();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        bll.DeleteList("");
    }
}