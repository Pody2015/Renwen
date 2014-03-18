using System;
namespace zs.Model
{
	/// <summary>
	/// Tbl_Flex:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tbl_Flex
	{
		public Tbl_Flex()
		{}
		#region Model
		private int _id;
		private string _keyname;
		private string _keyvalue;
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
		public string keyName
		{
			set{ _keyname=value;}
			get{return _keyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string keyValue
		{
			set{ _keyvalue=value;}
			get{return _keyvalue;}
		}
		#endregion Model

	}
}

