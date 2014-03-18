using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace zs.DAL
{
	/// <summary>
	/// 数据访问类:Tbl_Chaxun
	/// </summary>
	public partial class Tbl_Chaxun
	{
		public Tbl_Chaxun()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Tbl_Chaxun"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tbl_Chaxun");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        public bool Exists(string cardid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Tbl_Chaxun");
            strSql.Append(" where cardid=@cardid");
            SqlParameter[] parameters = {
					new SqlParameter("@cardid", SqlDbType.VarChar,20)
			};
            parameters[0].Value = cardid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(zs.Model.Tbl_Chaxun model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tbl_Chaxun(");
			strSql.Append("name,stuno,ksno,cardid,score,luquxueyuan,luquzhuanye,kstype)");
			strSql.Append(" values (");
			strSql.Append("@name,@stuno,@ksno,@cardid,@score,@luquxueyuan,@luquzhuanye,@kstype)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,10),
					new SqlParameter("@stuno", SqlDbType.VarChar,20),
					new SqlParameter("@ksno", SqlDbType.VarChar,50),
					new SqlParameter("@cardid", SqlDbType.VarChar,20),
					new SqlParameter("@score", SqlDbType.VarChar,10),
					new SqlParameter("@luquxueyuan", SqlDbType.VarChar,50),
					new SqlParameter("@luquzhuanye", SqlDbType.VarChar,50),
					new SqlParameter("@kstype", SqlDbType.VarChar,10)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.stuno;
			parameters[2].Value = model.ksno;
			parameters[3].Value = model.cardid;
			parameters[4].Value = model.score;
			parameters[5].Value = model.luquxueyuan;
			parameters[6].Value = model.luquzhuanye;
			parameters[7].Value = model.kstype;

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
		public bool Update(zs.Model.Tbl_Chaxun model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tbl_Chaxun set ");
			strSql.Append("name=@name,");
			strSql.Append("stuno=@stuno,");
			strSql.Append("ksno=@ksno,");
			strSql.Append("cardid=@cardid,");
			strSql.Append("score=@score,");
			strSql.Append("luquxueyuan=@luquxueyuan,");
			strSql.Append("luquzhuanye=@luquzhuanye,");
			strSql.Append("kstype=@kstype");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,10),
					new SqlParameter("@stuno", SqlDbType.VarChar,20),
					new SqlParameter("@ksno", SqlDbType.VarChar,50),
					new SqlParameter("@cardid", SqlDbType.VarChar,20),
					new SqlParameter("@score", SqlDbType.VarChar,10),
					new SqlParameter("@luquxueyuan", SqlDbType.VarChar,50),
					new SqlParameter("@luquzhuanye", SqlDbType.VarChar,50),
					new SqlParameter("@kstype", SqlDbType.VarChar,10),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.stuno;
			parameters[2].Value = model.ksno;
			parameters[3].Value = model.cardid;
			parameters[4].Value = model.score;
			parameters[5].Value = model.luquxueyuan;
			parameters[6].Value = model.luquzhuanye;
			parameters[7].Value = model.kstype;
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
			strSql.Append("delete from Tbl_Chaxun ");
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
			strSql.Append("delete from Tbl_Chaxun ");
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
		public zs.Model.Tbl_Chaxun GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,stuno,ksno,cardid,score,luquxueyuan,luquzhuanye,kstype from Tbl_Chaxun ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			zs.Model.Tbl_Chaxun model=new zs.Model.Tbl_Chaxun();
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
				if(ds.Tables[0].Rows[0]["stuno"]!=null && ds.Tables[0].Rows[0]["stuno"].ToString()!="")
				{
					model.stuno=ds.Tables[0].Rows[0]["stuno"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ksno"]!=null && ds.Tables[0].Rows[0]["ksno"].ToString()!="")
				{
					model.ksno=ds.Tables[0].Rows[0]["ksno"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cardid"]!=null && ds.Tables[0].Rows[0]["cardid"].ToString()!="")
				{
					model.cardid=ds.Tables[0].Rows[0]["cardid"].ToString();
				}
				if(ds.Tables[0].Rows[0]["score"]!=null && ds.Tables[0].Rows[0]["score"].ToString()!="")
				{
					model.score=ds.Tables[0].Rows[0]["score"].ToString();
				}
				if(ds.Tables[0].Rows[0]["luquxueyuan"]!=null && ds.Tables[0].Rows[0]["luquxueyuan"].ToString()!="")
				{
					model.luquxueyuan=ds.Tables[0].Rows[0]["luquxueyuan"].ToString();
				}
				if(ds.Tables[0].Rows[0]["luquzhuanye"]!=null && ds.Tables[0].Rows[0]["luquzhuanye"].ToString()!="")
				{
					model.luquzhuanye=ds.Tables[0].Rows[0]["luquzhuanye"].ToString();
				}
				if(ds.Tables[0].Rows[0]["kstype"]!=null && ds.Tables[0].Rows[0]["kstype"].ToString()!="")
				{
					model.kstype=ds.Tables[0].Rows[0]["kstype"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

        public zs.Model.Tbl_Chaxun GetModel(string cardid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,name,stuno,ksno,cardid,score,luquxueyuan,luquzhuanye,kstype from Tbl_Chaxun ");
            strSql.Append(" where cardid=@cardid");
            SqlParameter[] parameters = {
					new SqlParameter("@cardid", SqlDbType.VarChar,20)
			};
            parameters[0].Value = cardid;

            zs.Model.Tbl_Chaxun model = new zs.Model.Tbl_Chaxun();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["name"] != null && ds.Tables[0].Rows[0]["name"].ToString() != "")
                {
                    model.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["stuno"] != null && ds.Tables[0].Rows[0]["stuno"].ToString() != "")
                {
                    model.stuno = ds.Tables[0].Rows[0]["stuno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ksno"] != null && ds.Tables[0].Rows[0]["ksno"].ToString() != "")
                {
                    model.ksno = ds.Tables[0].Rows[0]["ksno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cardid"] != null && ds.Tables[0].Rows[0]["cardid"].ToString() != "")
                {
                    model.cardid = ds.Tables[0].Rows[0]["cardid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["score"] != null && ds.Tables[0].Rows[0]["score"].ToString() != "")
                {
                    model.score = ds.Tables[0].Rows[0]["score"].ToString();
                }
                if (ds.Tables[0].Rows[0]["luquxueyuan"] != null && ds.Tables[0].Rows[0]["luquxueyuan"].ToString() != "")
                {
                    model.luquxueyuan = ds.Tables[0].Rows[0]["luquxueyuan"].ToString();
                }
                if (ds.Tables[0].Rows[0]["luquzhuanye"] != null && ds.Tables[0].Rows[0]["luquzhuanye"].ToString() != "")
                {
                    model.luquzhuanye = ds.Tables[0].Rows[0]["luquzhuanye"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kstype"] != null && ds.Tables[0].Rows[0]["kstype"].ToString() != "")
                {
                    model.kstype = ds.Tables[0].Rows[0]["kstype"].ToString();
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
			strSql.Append("select id,name,stuno,ksno,cardid,score,luquxueyuan,luquzhuanye,kstype ");
			strSql.Append(" FROM Tbl_Chaxun ");
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
			strSql.Append(" id,name,stuno,ksno,cardid,score,luquxueyuan,luquzhuanye,kstype ");
			strSql.Append(" FROM Tbl_Chaxun ");
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
			strSql.Append("select count(1) FROM Tbl_Chaxun ");
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
			strSql.Append(")AS Row, T.*  from Tbl_Chaxun T ");
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
			parameters[0].Value = "Tbl_Chaxun";
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

