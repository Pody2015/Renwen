using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;

/// <summary>
///ApplicationMethod 的摘要说明
/// </summary>
public static class ApplicationMethod
{
    /// <summary>
    /// 字符串加密
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string encript(string text)
    {
        string EncriptKey = ConfigurationManager.AppSettings["EncriptKey"].ToString();
        Byte[] key = Encoding.UTF8.GetBytes(EncriptKey);
        Byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        Byte[] InputByteArray = Encoding.UTF8.GetBytes(text);
        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream(ms,des.CreateEncryptor(key,IV),CryptoStreamMode.Write);
        cs.Write(InputByteArray, 0, InputByteArray.Length);
        cs.FlushFinalBlock();
        return Convert.ToBase64String(ms.ToArray());
    }

    /// <summary>
    /// 字符串解密
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string decript(string text)
    {
        string DecryptKey = ConfigurationManager.AppSettings["EncriptKey"].ToString();
        text = text.Replace(" ", "+");
        Byte[] key = Encoding.UTF8.GetBytes(DecryptKey);
        Byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        Byte[] InputByteArray = Convert.FromBase64String(text);
        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
        cs.Write(InputByteArray, 0, InputByteArray.Length);
        cs.FlushFinalBlock();
        Encoding encoding = Encoding.UTF8;
        return encoding.GetString(ms.ToArray());
    }

    /// <summary>
    /// 去除内容中的HTML标签
    /// </summary>
    /// <param name="Htmlstring">要去除的原内容</param>
    /// <param name="Length">截取的长度</param>
    /// <returns></returns>
    public static string NoHtmlCode(string Htmlstring, int Length)
    {
        
        //删除脚本 
        Htmlstring = Regex.Replace(Htmlstring, @"<script(\s[^>]*?)?>[\s\S]*? </script>", "", RegexOptions.IgnoreCase);
        //删除样式
        Htmlstring = Regex.Replace(Htmlstring, @"<style>[\s\S]*? </style>", "", RegexOptions.IgnoreCase);//
        Htmlstring = Regex.Replace(Htmlstring, @"\\..*\\{[\\s\\S]*\\}", "", RegexOptions.IgnoreCase);
        //删除html标签
        Htmlstring = Regex.Replace(Htmlstring, @" <(.[^>]*)>", "", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);
        Htmlstring.Replace("<", "");
        Htmlstring.Replace(">", "");
        Htmlstring.Replace("\r\n", "");
        Htmlstring.Replace(" ", "");
        
        Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();
        if (Htmlstring.Length > Length)
            return Htmlstring.Substring(0, Length);
        else
            return Htmlstring;
    }

    /// <summary>
    /// 取MD5值
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string MD5(String str)
    {
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] data = System.Text.Encoding.Default.GetBytes(str);
        byte[] result = md5.ComputeHash(data);
        String ret = "";
        for (int i = 0; i < result.Length; i++)
            ret += result[i].ToString("x").PadLeft(2, '0');
        return ret;
    }

    /// <summary>
    /// 写入日志文件
    /// </summary>
    /// <param name="content">需要写入的信息</param>
    public static void WriteLogsFile(string content)
    {
        string log_file = "";
        log_file = HttpContext.Current.Request.PhysicalApplicationPath + "/logs/log" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
        write_text_file(log_file, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + content);
    }

    /// <summary>
    /// 写入文件
    /// </summary>
    /// <param name="file_name">目标文件</param>
    /// <param name="file_content">待写入的内容</param>
    public static void write_text_file(string file_name, string file_content)
    {
        System.IO.StreamWriter oWrite;
        try
        {
            if (System.IO.File.Exists(file_name) == false)
                oWrite = System.IO.File.CreateText(file_name);
            else
                oWrite = System.IO.File.AppendText(file_name);
            oWrite.WriteLine(file_content);
            oWrite.Close();
        }
        catch (Exception ex)
        {
            ;
        }
    }

    /// <summary>
    /// 发送邮件
    /// </summary>
    /// <param name="strTo">收件人</param>
    /// <param name="subject">主题</param>
    /// <param name="content">内容</param>
    /// <param name="strCC">抄送</param>
    /// <param name="strFrom">发件人</param>
    /// <returns></returns>
    public static string send_mail(string strTo, string subject, string content, string strCC)
    {
        string strFrom = ConfigurationManager.AppSettings["mailfrom"].ToString();
        string password = ConfigurationManager.AppSettings["mailpassword"].ToString();
        string server = ConfigurationManager.AppSettings["mailserver"].ToString();
        string port = ConfigurationManager.AppSettings["mailport"].ToString();
        Boolean IsBodyHtml = true;
        int i = 0;
        string[] arr_to;
        string[] arr_cc;
        try
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new System.Net.Mail.MailAddress(strFrom);
            msg.Subject = subject;
            msg.Body = content;
            msg.IsBodyHtml = IsBodyHtml;
            if (strTo.Length > 0)
            {
                arr_to = strTo.Split(';');
                for (i = 0; i < arr_to.Length ; i++)
                    msg.To.Add(arr_to[i].Trim());
            }
            if (strCC.Length > 0)
            {
                arr_cc = strCC.Split(';');
                for (i = 0; i < arr_cc.Length ; i++)
                    msg.CC.Add(arr_cc[i].Trim());
            }
            System.Net.Mail.SmtpClient SmtpMail = new System.Net.Mail.SmtpClient(server, int.Parse(port));
            SmtpMail.Credentials = new System.Net.NetworkCredential(strFrom, password);
            SmtpMail.Send(msg);
            return "邮件发送成功。";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    ///   <summary>
    ///   去除HTML标记
    ///   </summary>
    ///   <param   name=”NoHTML”>包括HTML的源码   </param>
    ///   <returns>已经去除后的文字</returns>
    public static string NoHTML(string Htmlstring)
    {
        //删除脚本
        Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "",
        RegexOptions.IgnoreCase);
        //删除HTML 
        Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "",
        RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "",
        RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"–>", "", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"<!–.*", "", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"",
        RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&",
        RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<",
        RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">",
        RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", "   ",
        RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
        Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);
        Htmlstring.Replace("<", "");
        Htmlstring.Replace(">", "");
        Htmlstring.Replace("\r\n", "");
        Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();
        return Htmlstring;
    }

}