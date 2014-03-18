using System;
namespace zs.Model
{
	/// <summary>
	/// Tbl_Page:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tbl_Page
	{
		public Tbl_Page()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _conts;
		private string _metatags;
		private string _metadescription;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string conts
		{
			set{ _conts=value;}
			get{return _conts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string metatags
		{
			set{ _metatags=value;}
			get{return _metatags;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string metadescription
		{
			set{ _metadescription=value;}
			get{return _metadescription;}
		}
		#endregion Model

	}
}

