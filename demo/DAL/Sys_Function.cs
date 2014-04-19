using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zs.DAL
{
	/// <summary>
	/// 数据访问类:Sys_Function
	/// </summary>
	public partial class Sys_Function
	{
		public Sys_Function()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Sys_Function"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_Function");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(zs.Model.Sys_Function model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_Function(");
			strSql.Append("FunctionName,FunctionDescription,Type,Assembly,ValidateDate)");
			strSql.Append(" values (");
			strSql.Append("@FunctionName,@FunctionDescription,@Type,@Assembly,@ValidateDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionName", SqlDbType.VarChar,20),
					new SqlParameter("@FunctionDescription", SqlDbType.VarChar,100),
					new SqlParameter("@Type", SqlDbType.VarChar,10),
					new SqlParameter("@Assembly", SqlDbType.VarChar,50),
					new SqlParameter("@ValidateDate", SqlDbType.DateTime)};
			parameters[0].Value = model.FunctionName;
			parameters[1].Value = model.FunctionDescription;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Assembly;
			parameters[4].Value = model.ValidateDate;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zs.Model.Sys_Function model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_Function set ");
			strSql.Append("FunctionName=@FunctionName,");
			strSql.Append("FunctionDescription=@FunctionDescription,");
			strSql.Append("Type=@Type,");
			strSql.Append("Assembly=@Assembly,");
			strSql.Append("ValidateDate=@ValidateDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionName", SqlDbType.VarChar,20),
					new SqlParameter("@FunctionDescription", SqlDbType.VarChar,100),
					new SqlParameter("@Type", SqlDbType.VarChar,10),
					new SqlParameter("@Assembly", SqlDbType.VarChar,50),
					new SqlParameter("@ValidateDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.FunctionName;
			parameters[1].Value = model.FunctionDescription;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Assembly;
			parameters[4].Value = model.ValidateDate;
			parameters[5].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_Function ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_Function ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zs.Model.Sys_Function GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FunctionName,FunctionDescription,Type,Assembly,ValidateDate from Sys_Function ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			zs.Model.Sys_Function model=new zs.Model.Sys_Function();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FunctionName"]!=null && ds.Tables[0].Rows[0]["FunctionName"].ToString()!="")
				{
					model.FunctionName=ds.Tables[0].Rows[0]["FunctionName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["FunctionDescription"]!=null && ds.Tables[0].Rows[0]["FunctionDescription"].ToString()!="")
				{
					model.FunctionDescription=ds.Tables[0].Rows[0]["FunctionDescription"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null && ds.Tables[0].Rows[0]["Type"].ToString()!="")
				{
					model.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Assembly"]!=null && ds.Tables[0].Rows[0]["Assembly"].ToString()!="")
				{
					model.Assembly=ds.Tables[0].Rows[0]["Assembly"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ValidateDate"]!=null && ds.Tables[0].Rows[0]["ValidateDate"].ToString()!="")
				{
					model.ValidateDate=DateTime.Parse(ds.Tables[0].Rows[0]["ValidateDate"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,FunctionName,FunctionDescription,Type,Assembly,ValidateDate ");
			strSql.Append(" FROM Sys_Function ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,FunctionName,FunctionDescription,Type,Assembly,ValidateDate ");
			strSql.Append(" FROM Sys_Function ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Sys_Function ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Sys_Function T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Sys_Function";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

