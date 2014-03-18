using System;
namespace zs.Model
{
	/// <summary>
	/// Tbl_User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tbl_User
	{
		public Tbl_User()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _userpsw;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userPsw
		{
			set{ _userpsw=value;}
			get{return _userpsw;}
		}
		#endregion Model

	}
}

