﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace zs.DAL
{
    /// <summary>
    /// 数据访问类:Tbl_Message
    /// </summary>
    public partial class Tbl_Message
    {
        public Tbl_Message()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Tbl_Message");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(zs.Model.Tbl_Message model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Tbl_Message(");
            strSql.Append("name,mail,tel,title,conts,askTime,reply,replyTime,isShow)");
            strSql.Append(" values (");
            strSql.Append("@name,@mail,@tel,@title,@conts,@askTime,@reply,@replyTime,@isShow)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,10),
					new SqlParameter("@mail", SqlDbType.VarChar,50),
					new SqlParameter("@tel", SqlDbType.VarChar,20),
					new SqlParameter("@title", SqlDbType.VarChar,50),
					new SqlParameter("@conts", SqlDbType.VarChar,550),
					new SqlParameter("@askTime", SqlDbType.DateTime),
					new SqlParameter("@reply", SqlDbType.VarChar,550),
					new SqlParameter("@replyTime", SqlDbType.DateTime),
					new SqlParameter("@isShow", SqlDbType.Int,4)};
            parameters[0].Value = model.name;
            parameters[1].Value = model.mail;
            parameters[2].Value = model.tel;
            parameters[3].Value = model.title;
            parameters[4].Value = model.conts;
            parameters[5].Value = model.askTime;
            parameters[6].Value = model.reply;
            parameters[7].Value = model.replyTime;
            parameters[8].Value = model.isShow;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(zs.Model.Tbl_Message model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Tbl_Message set ");
            strSql.Append("name=@name,");
            strSql.Append("mail=@mail,");
            strSql.Append("tel=@tel,");
            strSql.Append("title=@title,");
            strSql.Append("conts=@conts,");
            strSql.Append("askTime=@askTime,");
            strSql.Append("reply=@reply,");
            strSql.Append("replyTime=@replyTime,");
            strSql.Append("isShow=@isShow");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,10),
					new SqlParameter("@mail", SqlDbType.VarChar,50),
					new SqlParameter("@tel", SqlDbType.VarChar,20),
					new SqlParameter("@title", SqlDbType.VarChar,50),
					new SqlParameter("@conts", SqlDbType.VarChar,550),
					new SqlParameter("@askTime", SqlDbType.DateTime),
					new SqlParameter("@reply", SqlDbType.VarChar,550),
					new SqlParameter("@replyTime", SqlDbType.DateTime),
					new SqlParameter("@isShow", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.name;
            parameters[1].Value = model.mail;
            parameters[2].Value = model.tel;
            parameters[3].Value = model.title;
            parameters[4].Value = model.conts;
            parameters[5].Value = model.askTime;
            parameters[6].Value = model.reply;
            parameters[7].Value = model.replyTime;
            parameters[8].Value = model.isShow;
            parameters[9].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Tbl_Message ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Tbl_Message ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public zs.Model.Tbl_Message GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,name,mail,tel,title,conts,askTime,reply,replyTime,isShow from Tbl_Message ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            zs.Model.Tbl_Message model = new zs.Model.Tbl_Message();
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
                if (ds.Tables[0].Rows[0]["mail"] != null && ds.Tables[0].Rows[0]["mail"].ToString() != "")
                {
                    model.mail = ds.Tables[0].Rows[0]["mail"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tel"] != null && ds.Tables[0].Rows[0]["tel"].ToString() != "")
                {
                    model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["title"] != null && ds.Tables[0].Rows[0]["title"].ToString() != "")
                {
                    model.title = ds.Tables[0].Rows[0]["title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["conts"] != null && ds.Tables[0].Rows[0]["conts"].ToString() != "")
                {
                    model.conts = ds.Tables[0].Rows[0]["conts"].ToString();
                }
                if (ds.Tables[0].Rows[0]["askTime"] != null && ds.Tables[0].Rows[0]["askTime"].ToString() != "")
                {
                    model.askTime = DateTime.Parse(ds.Tables[0].Rows[0]["askTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["reply"] != null && ds.Tables[0].Rows[0]["reply"].ToString() != "")
                {
                    model.reply = ds.Tables[0].Rows[0]["reply"].ToString();
                }
                if (ds.Tables[0].Rows[0]["replyTime"] != null && ds.Tables[0].Rows[0]["replyTime"].ToString() != "")
                {
                    model.replyTime = DateTime.Parse(ds.Tables[0].Rows[0]["replyTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["isShow"] != null && ds.Tables[0].Rows[0]["isShow"].ToString() != "")
                {
                    model.isShow = int.Parse(ds.Tables[0].Rows[0]["isShow"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,name,mail,tel,title,conts,askTime,reply,replyTime,isShow ");
            strSql.Append(" FROM Tbl_Message ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,name,mail,tel,title,conts,askTime,reply,replyTime,isShow ");
            strSql.Append(" FROM Tbl_Message ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Tbl_Message ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from Tbl_Message T ");
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
            parameters[0].Value = "Tbl_Message";
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

