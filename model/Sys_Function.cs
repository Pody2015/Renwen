using System;
namespace zs.Model
{
	/// <summary>
	/// Sys_Function:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_Function
	{
		public Sys_Function()
		{}
		#region Model
		private int _id;
		private string _functionname;
		private string _functiondescription;
		private string _type;
		private string _assembly;
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
		public string FunctionName
		{
			set{ _functionname=value;}
			get{return _functionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FunctionDescription
		{
			set{ _functiondescription=value;}
			get{return _functiondescription;}
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
		public string Assembly
		{
			set{ _assembly=value;}
			get{return _assembly;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ValidateDate
		{
			set{ _validatedate=value;}
			get{return _validatedate;}
		}
		#endregion Model

	}
}

