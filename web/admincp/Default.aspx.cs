using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class admincp_Default : System.Web.UI.Page
{
    public string ServerOS;
    public string CpuSum;
    public string CpuType;
    public string ServerSoft;
    public string MachineName;
    public string ServerName;
    public string ServerPath;
    public string ServerNet;
    public string ServerArea;
    public string ServerTimeOut;
    public string ServerStart;
    public string ServerSessions;
    public string ServerApp;
    public string ServerCache;
    public string AspNetCpu;
    public string AspNetN;
    public string PrStart;
    public string ServerAppN;
    public string ServerFso;
    protected void Page_Load(object sender, EventArgs e)
    {
        serveren();
    }
    public void serveren()
    {
        ServerOS = Environment.OSVersion.ToString(); //操作系统：
        CpuSum = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS"); //CPU个数：
        CpuType = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"); //CPU类型：
        ServerSoft = Request.ServerVariables["SERVER_SOFTWARE"]; //信息服务软件：
        MachineName = Server.MachineName; //服务器名
        ServerName = Request.ServerVariables["SERVER_NAME"]; //服务器域名
        ServerPath = Request.ServerVariables["APPL_PHYSICAL_PATH"]; //虚拟服务绝对路径
        ServerNet = ".NET CLR " + Environment.Version.ToString(); //.NET 版本
        ServerArea = (DateTime.Now - DateTime.UtcNow).TotalHours > 0 ? "+" + (DateTime.Now - DateTime.UtcNow).TotalHours.ToString() : (DateTime.Now - DateTime.UtcNow).TotalHours.ToString(); //服务器时区
        ServerStart = ((Double)System.Environment.TickCount / 3600000).ToString("N2"); //开机运行时长
        //PrStart = GetPrStart(); //进程开始时间
        AspNetN = GetAspNetN(); //AspNet 内存占用
        if(AspNetN.Length >= 5 )
            AspNetN=AspNetN.Substring(0, 5);
        AspNetCpu = GetAspNetCpu(); //AspNet CPU时间
        ServerSessions = Session.Contents.Count.ToString(); //Session总数
        ServerApp = Application.Contents.Count.ToString(); //Application总数
        ServerCache = Cache.Count.ToString(); //应用程序缓存总数
        //ServerAppN = GetServerAppN(); //应用程序占用内存
        //ServerFso = Check("Scripting.FileSystemObject"); //FSO 文本文件读写
        ServerTimeOut = Server.ScriptTimeout.ToString() + "毫秒"; //本页执行时间 
    }

    private string Check(string p)
    {
        throw new NotImplementedException();
    }

    private string GetPrStart()
    {
        throw new NotImplementedException();
    }

    private string GetServerAppN()
    {
        throw new NotImplementedException();
    }

    private string GetAspNetCpu()
    {
        PerformanceCounter _oPerformanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        float _nVal = _oPerformanceCounter.NextValue();
        _oPerformanceCounter.Dispose();
        return _nVal.ToString("f2") + "%";
    }

    private string GetAspNetN()
    {
        return ((((double)System.Diagnostics.Process.GetCurrentProcess().WorkingSet64) / 1024) / 1024).ToString();
    }
}