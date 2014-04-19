using System;
namespace zs.Model
{
	/// <summary>
	/// Tbl_Chaxun:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tbl_Chaxun
	{
		public Tbl_Chaxun()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _stuno;
		private string _ksno;
		private string _cardid;
		private string _score;
		private string _luquxueyuan;
		private string _luquzhuanye;
		private string _kstype;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 学号
		/// </summary>
		public string stuno
		{
			set{ _stuno=value;}
			get{return _stuno;}
		}
		/// <summary>
		/// 考试号
		/// </summary>
		public string ksno
		{
			set{ _ksno=value;}
			get{return _ksno;}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string cardid
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 分数（总分）
		/// </summary>
		public string score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 录取学院
		/// </summary>
		public string luquxueyuan
		{
			set{ _luquxueyuan=value;}
			get{return _luquxueyuan;}
		}
		/// <summary>
		/// 录取专业
		/// </summary>
		public string luquzhuanye
		{
			set{ _luquzhuanye=value;}
			get{return _luquzhuanye;}
		}
		/// <summary>
		/// 考试类别，目前两种“高考”和“专升本”。
		/// </summary>
		public string kstype
		{
			set{ _kstype=value;}
			get{return _kstype;}
		}
		#endregion Model

	}
}

