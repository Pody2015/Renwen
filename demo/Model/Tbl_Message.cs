using System;
namespace zs.Model
{
	/// <summary>
	/// Tbl_Message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tbl_Message
	{
		public Tbl_Message()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _mail;
		private string _tel;
		private string _conts;
		private DateTime? _asktime;
		private string _reply;
		private DateTime? _replytime;
		private int? _isshow;
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
		public string mail
		{
			set{ _mail=value;}
			get{return _mail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
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
		public DateTime? askTime
		{
			set{ _asktime=value;}
			get{return _asktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reply
		{
			set{ _reply=value;}
			get{return _reply;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? replyTime
		{
			set{ _replytime=value;}
			get{return _replytime;}
		}
		/// <summary>
		/// 是否显示，0为隐藏。
		/// </summary>
		public int? isShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		#endregion Model

	}
}

