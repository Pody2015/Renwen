using System;
namespace zs.Model
{
	/// <summary>
	/// Sys_RoleFunction:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_RoleFunction
	{
		public Sys_RoleFunction()
		{}
		#region Model
		private int _id;
		private int? _roleid;
		private int? _functionid;
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
		public int? RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FunctionID
		{
			set{ _functionid=value;}
			get{return _functionid;}
		}
		#endregion Model

	}
}

