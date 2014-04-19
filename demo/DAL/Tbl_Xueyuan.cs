using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace zs.DAL
{
	/// <summary>
	/// 数据访问类:Tbl_Xueyuan
	/// </summary>
	public partial class Tbl_Xueyuan
	{
		public Tbl_Xueyuan()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Tbl_Xueyuan"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tbl_Xueyuan");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(zs.Model.Tbl_Xueyuan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tbl_Xueyuan(");
			strSql.Append("name,nameen,logo,image1,image2,image3,yuanzhang,conts)");
			strSql.Append(" values (");
			strSql.Append("@name,@nameen,@logo,@image1,@image2,@image3,@yuanzhang,@conts)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@nameen", SqlDbType.VarChar,80),
					new SqlParameter("@logo", SqlDbType.VarChar,50),
					new SqlParameter("@image1", SqlDbType.VarChar,50),
					new SqlParameter("@image2", SqlDbType.VarChar,50),
					new SqlParameter("@image3", SqlDbType.VarChar,50),
					new SqlParameter("@yuanzhang", SqlDbType.VarChar),
					new SqlParameter("@conts", SqlDbType.VarChar)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.nameen;
			parameters[2].Value = model.logo;
			parameters[3].Value = model.image1;
			parameters[4].Value = model.image2;
			parameters[5].Value = model.image3;
			parameters[6].Value = model.yuanzhang;
			parameters[7].Value = model.conts;

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
		public bool Update(zs.Model.Tbl_Xueyuan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tbl_Xueyuan set ");
			strSql.Append("name=@name,");
			strSql.Append("nameen=@nameen,");
			strSql.Append("logo=@logo,");
			strSql.Append("image1=@image1,");
			strSql.Append("image2=@image2,");
			strSql.Append("image3=@image3,");
			strSql.Append("yuanzhang=@yuanzhang,");
			strSql.Append("conts=@conts");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@nameen", SqlDbType.VarChar,80),
					new SqlParameter("@logo", SqlDbType.VarChar,50),
					new SqlParameter("@image1", SqlDbType.VarChar,50),
					new SqlParameter("@image2", SqlDbType.VarChar,50),
					new SqlParameter("@image3", SqlDbType.VarChar,50),
					new SqlParameter("@yuanzhang", SqlDbType.VarChar),
					new SqlParameter("@conts", SqlDbType.VarChar),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.nameen;
			parameters[2].Value = model.logo;
			parameters[3].Value = model.image1;
			parameters[4].Value = model.image2;
			parameters[5].Value = model.image3;
			parameters[6].Value = model.yuanzhang;
			parameters[7].Value = model.conts;
			parameters[8].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tbl_Xueyuan ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tbl_Xueyuan ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public zs.Model.Tbl_Xueyuan GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,nameen,logo,image1,image2,image3,yuanzhang,conts from Tbl_Xueyuan ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			zs.Model.Tbl_Xueyuan model=new zs.Model.Tbl_Xueyuan();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["name"]!=null && ds.Tables[0].Rows[0]["name"].ToString()!="")
				{
					model.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["nameen"]!=null && ds.Tables[0].Rows[0]["nameen"].ToString()!="")
				{
					model.nameen=ds.Tables[0].Rows[0]["nameen"].ToString();
				}
				if(ds.Tables[0].Rows[0]["logo"]!=null && ds.Tables[0].Rows[0]["logo"].ToString()!="")
				{
					model.logo=ds.Tables[0].Rows[0]["logo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["image1"]!=null && ds.Tables[0].Rows[0]["image1"].ToString()!="")
				{
					model.image1=ds.Tables[0].Rows[0]["image1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["image2"]!=null && ds.Tables[0].Rows[0]["image2"].ToString()!="")
				{
					model.image2=ds.Tables[0].Rows[0]["image2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["image3"]!=null && ds.Tables[0].Rows[0]["image3"].ToString()!="")
				{
					model.image3=ds.Tables[0].Rows[0]["image3"].ToString();
				}
				if(ds.Tables[0].Rows[0]["yuanzhang"]!=null && ds.Tables[0].Rows[0]["yuanzhang"].ToString()!="")
				{
					model.yuanzhang=ds.Tables[0].Rows[0]["yuanzhang"].ToString();
				}
				if(ds.Tables[0].Rows[0]["conts"]!=null && ds.Tables[0].Rows[0]["conts"].ToString()!="")
				{
					model.conts=ds.Tables[0].Rows[0]["conts"].ToString();
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
			strSql.Append("select id,name,nameen,logo,image1,image2,image3,yuanzhang,conts ");
			strSql.Append(" FROM Tbl_Xueyuan ");
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
			strSql.Append(" id,name,nameen,logo,image1,image2,image3,yuanzhang,conts ");
			strSql.Append(" FROM Tbl_Xueyuan ");
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
			strSql.Append("select count(1) FROM Tbl_Xueyuan ");
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
			strSql.Append(")AS Row, T.*  from Tbl_Xueyuan T ");
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
			parameters[0].Value = "Tbl_Xueyuan";
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

