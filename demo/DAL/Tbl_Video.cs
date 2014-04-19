using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zs.DAL
{
	/// <summary>
	/// 数据访问类:Tbl_Video
	/// </summary>
	public partial class Tbl_Video
	{
		public Tbl_Video()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(zs.Model.Tbl_Video model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tbl_Video(");
			strSql.Append("id,title,thumb,conts,addtime,author,leiid)");
			strSql.Append(" values (");
			strSql.Append("@id,@title,@thumb,@conts,@addtime,@author,@leiid)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@title", SqlDbType.VarChar,150),
					new SqlParameter("@thumb", SqlDbType.VarChar,150),
					new SqlParameter("@conts", SqlDbType.VarChar),
					new SqlParameter("@addtime", SqlDbType.DateTime),
					new SqlParameter("@author", SqlDbType.VarChar,50),
					new SqlParameter("@leiid", SqlDbType.Int,4)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.title;
			parameters[2].Value = model.thumb;
			parameters[3].Value = model.conts;
			parameters[4].Value = model.addtime;
			parameters[5].Value = model.author;
			parameters[6].Value = model.leiid;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(zs.Model.Tbl_Video model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tbl_Video set ");
			strSql.Append("id=@id,");
			strSql.Append("title=@title,");
			strSql.Append("thumb=@thumb,");
			strSql.Append("conts=@conts,");
			strSql.Append("addtime=@addtime,");
			strSql.Append("author=@author,");
			strSql.Append("leiid=@leiid");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@title", SqlDbType.VarChar,150),
					new SqlParameter("@thumb", SqlDbType.VarChar,150),
					new SqlParameter("@conts", SqlDbType.VarChar),
					new SqlParameter("@addtime", SqlDbType.DateTime),
					new SqlParameter("@author", SqlDbType.VarChar,50),
					new SqlParameter("@leiid", SqlDbType.Int,4)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.title;
			parameters[2].Value = model.thumb;
			parameters[3].Value = model.conts;
			parameters[4].Value = model.addtime;
			parameters[5].Value = model.author;
			parameters[6].Value = model.leiid;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tbl_Video ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public zs.Model.Tbl_Video GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,title,thumb,conts,addtime,author,leiid from Tbl_Video ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			zs.Model.Tbl_Video model=new zs.Model.Tbl_Video();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["thumb"]!=null && ds.Tables[0].Rows[0]["thumb"].ToString()!="")
				{
					model.thumb=ds.Tables[0].Rows[0]["thumb"].ToString();
				}
				if(ds.Tables[0].Rows[0]["conts"]!=null && ds.Tables[0].Rows[0]["conts"].ToString()!="")
				{
					model.conts=ds.Tables[0].Rows[0]["conts"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addtime"]!=null && ds.Tables[0].Rows[0]["addtime"].ToString()!="")
				{
					model.addtime=DateTime.Parse(ds.Tables[0].Rows[0]["addtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["author"]!=null && ds.Tables[0].Rows[0]["author"].ToString()!="")
				{
					model.author=ds.Tables[0].Rows[0]["author"].ToString();
				}
				if(ds.Tables[0].Rows[0]["leiid"]!=null && ds.Tables[0].Rows[0]["leiid"].ToString()!="")
				{
					model.leiid=int.Parse(ds.Tables[0].Rows[0]["leiid"].ToString());
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
			strSql.Append("select id,title,thumb,conts,addtime,author,leiid ");
			strSql.Append(" FROM Tbl_Video ");
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
			strSql.Append(" id,title,thumb,conts,addtime,author,leiid ");
			strSql.Append(" FROM Tbl_Video ");
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
			strSql.Append("select count(1) FROM Tbl_Video ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from Tbl_Video T ");
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
			parameters[0].Value = "Tbl_Video";
			parameters[1].Value = "id";
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

