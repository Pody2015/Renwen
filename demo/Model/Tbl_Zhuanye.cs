using System;
namespace zs.Model
{
	/// <summary>
	/// Tbl_Zhuanye:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tbl_Zhuanye
	{
		public Tbl_Zhuanye()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _cont;
		private int? _xueyuanid;
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
		public string cont
		{
			set{ _cont=value;}
			get{return _cont;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? xueyuanid
		{
			set{ _xueyuanid=value;}
			get{return _xueyuanid;}
		}
		#endregion Model

	}
}

