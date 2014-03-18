using System;
namespace zs.Model
{
	/// <summary>
	/// Sys_Group:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_Group
	{
		public Sys_Group()
		{}
		#region Model
		private int _id;
		private string _type;
		private string _groupname;
		private int? _pid;
		private string _idpath;
		private string _namepath;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupName
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PID
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDPath
		{
			set{ _idpath=value;}
			get{return _idpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NamePath
		{
			set{ _namepath=value;}
			get{return _namepath;}
		}
		#endregion Model

	}
}

