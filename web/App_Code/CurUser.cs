using System;
using System.Data ;


	/// <summary>
	/// Visiter 的摘要说明。
	/// </summary>
	public class CurUser
	{
        public static bool _isSaveCookie = true;
        public static bool IsSaveCookie
        {
            get
            {
                return _isSaveCookie;
            }
            set
            {
                _isSaveCookie = value;
            }
        } 
        /// <summary>
        /// 用户ID
        /// </summary>
		public static int Id 
		{
			get
			{
				string val = SiteAbout.GetValue("UserId") ;
				return val == ""?0: int.Parse(val);
			}
			set
			{
                 
				SiteAbout.SetValue("UserId",value.ToString()) ;
			}
		}
        /// <summary>
        /// 登录名
        /// </summary>
		public static  string LoginName 
		{
			get
			{
				return SiteAbout.GetValue("LoginName") ;
			}
			set
			{
				SiteAbout.SetValue("LoginName",value) ;
			}
		}
        /// <summary>
        /// 密码
        /// </summary>
		public static  string Password 
		{
			get
			{
				return SiteAbout.GetValue("Password") ;
			}
			set
			{
				SiteAbout.SetValue("Password",value) ;
			}
		}
        /// <summary>
        /// 用户名
        /// </summary>
		public static  string Name 
		{
			get
			{
				return SiteAbout.GetValue("UserName") ;
			}
			set
			{
                 
				SiteAbout.SetValue("UserName",value) ;
			}
		}

		/// <summary>
		/// 下属用户
		/// </summary>
		public static  string PowerTree 
		{
			get
			{
				return SiteAbout.GetValue("PowerTree") ;
			}
			set
			{
				SiteAbout.SetValue("PowerTree",value) ;
			}
		}

		/// <summary>
		/// 下属用户及自己
		/// </summary>
		public static  string PowerTreeAndMy
		{
			get
			{
				return SiteAbout.GetValue("PowerTreeAndMy") ;
			}
			set
			{
				SiteAbout.SetValue("PowerTreeAndMy",value) ;
			}
		}

		public static  string PowerTreeName
		{
			get
			{
				return SiteAbout.GetValue("PowerTreeName") ;
			}
			set
			{
				SiteAbout.SetValue("PowerTreeName",value) ;
			}
		}
        /// <summary>
        /// 角色
        /// </summary>
		public static string Role 
		{
			get
			{
				return SiteAbout.GetValue("Role") ;
			}
			set
			{
				SiteAbout.SetValue("Role",value) ;
			}
		}
		public static int DeptId
		{
			get
			{
				string val = SiteAbout.GetValue("DeptId");
				if (val == "")
					return 0 ; 
				else
					return int.Parse(val) ;
			}
			set
			{
				SiteAbout.SetValue("DeptId", value.ToString());
			}
		}
		public static string DeptName
		{
			get
			{
				return SiteAbout.GetValue("DeptName");
			}
			set
			{
				SiteAbout.SetValue("DeptName", value);
			}
		} 

		public static string Company
		{
			get
			{
				return SiteAbout.GetValue("Company");
			}
			set
			{
				SiteAbout.SetValue("Company", value);
			}
		} 

		public static string Note
		{
			get
			{
				return SiteAbout.GetValue("Note");
			}
			set
			{
				SiteAbout.SetValue("Note", value);
			}
		}

        public static string Lang
        {
            get
            {
                return SiteAbout.GetValue("Lang");
            }
            set
            {
                SiteAbout.SetValueForever("Lang", value);
            }
        } 
        /// <summary>
        /// 是否超级管理员
        /// </summary>
		public static bool IsSuper
		{
			get
			{
				object o =  SiteAbout.GetValue("IsSuper");
				if ((o == null)||(o.ToString() == ""))
					return false ;
				else
					return bool.Parse(o.ToString());
			}
			set
			{
				SiteAbout.SetValue("IsSuper", value.ToString());
			}
		}


        public static int CompanyId
        {
            get
            {
                string val = SiteAbout.GetValue("CompanyId");
                return val == "" ? 0 : int.Parse(val);
            }
            set
            {

                SiteAbout.SetValue("CompanyId", value.ToString());
            }
        }
		#region LogOut 注销
        /// <summary>
        /// 注销
        /// </summary>
		public static void LogOut()
		{
			System.Web.HttpContext context = System.Web.HttpContext.Current ;
			context.Session.Abandon() ;
            SiteAbout.DeleteCookie("UserId");
            SiteAbout.DeleteCookie("LoginName");
            SiteAbout.DeleteCookie("UserName");
            SiteAbout.DeleteCookie("IsSuper");
		}
		#endregion

		/// <summary>
		/// 能否操作
		/// </summary>
		/// <param name="funName">功能名称</param>
		/// <param name="operate">操作 1是 1自已 3下属 15所有</param>
		/// <returns></returns>
		public bool CanOperate(string funName,int operate)
		{
			DataView dv = new DataView(SiteAbout.Power) ;
			dv.RowFilter = "FunName='" + funName + "' and UserId='" + CurUser.Id + "'" ;
			foreach(DataRowView  item in dv)
			{
				if (((int)item["Operate"] & operate) == operate)
					return true ;
			}
			return false ;
		}

	}

