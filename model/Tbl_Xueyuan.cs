using System;
namespace zs.Model
{
	/// <summary>
	/// Tbl_Xueyuan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tbl_Xueyuan
	{
		public Tbl_Xueyuan()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _nameen;
		private string _logo;
		private string _image1;
		private string _image2;
		private string _image3;
		private string _yuanzhang;
		private string _conts;
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
		public string nameen
		{
			set{ _nameen=value;}
			get{return _nameen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image1
		{
			set{ _image1=value;}
			get{return _image1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image2
		{
			set{ _image2=value;}
			get{return _image2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image3
		{
			set{ _image3=value;}
			get{return _image3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yuanzhang
		{
			set{ _yuanzhang=value;}
			get{return _yuanzhang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string conts
		{
			set{ _conts=value;}
			get{return _conts;}
		}
		#endregion Model

	}
}

