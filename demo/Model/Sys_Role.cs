using System;
namespace zs.Model
{
	/// <summary>
	/// Sys_Role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_Role
	{
		public Sys_Role()
		{}
		#region Model
		private int _id;
		private string _rolename;
		private string _description;
		private DateTime? _validatedate;
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
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? validateDate
		{
			set{ _validatedate=value;}
			get{return _validatedate;}
		}
		#endregion Model

	}
}

