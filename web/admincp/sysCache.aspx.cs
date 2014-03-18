using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class admincp_sysCache : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        showCache();
    }

    protected void RemoveAllCache()
    {
        System.Web.Caching.Cache _cache = HttpRuntime.Cache;
        IDictionaryEnumerator CacheEnum = _cache.GetEnumerator();
        ArrayList al = new ArrayList();
        while (CacheEnum.MoveNext())
        {
            al.Add(CacheEnum.Key);
        }
        foreach (string key in al)
        {
            _cache.Remove(key);
        }
        showCache();
    }
    //显示所有缓存 
    public void showCache()
    {
        string str = "";
        IDictionaryEnumerator CacheEnum = HttpRuntime.Cache.GetEnumerator();

        while (CacheEnum.MoveNext())
        {
            str += "缓存名<b>[" + CacheEnum.Key + "]</b><br />";
        }
        this.Label1.Text = "当前网站总缓存数:" + HttpRuntime.Cache.Count + "<br />" + str;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        RemoveAllCache();
    }
}