using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zs.Model;
namespace zs.BLL
{
	/// <summary>
	/// Tbl_Chaxun
	/// </summary>
	public partial class Tbl_Chaxun
	{
		private readonly zs.DAL.Tbl_Chaxun dal=new zs.DAL.Tbl_Chaxun();
		public Tbl_Chaxun()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
        public bool Exists(string cardid)
        {
            return dal.Exists(cardid);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(zs.Model.Tbl_Chaxun model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zs.Model.Tbl_Chaxun model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public zs.Model.Tbl_Chaxun GetModel(int id)
		{
			return dal.GetModel(id);
		}
        public zs.Model.Tbl_Chaxun GetModel(string cardid)
        {
            return dal.GetModel(cardid);
        }

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public zs.Model.Tbl_Chaxun GetModelByCache(int id)
		{
			
			string CacheKey = "Tbl_ChaxunModel-" + id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (zs.Model.Tbl_Chaxun)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zs.Model.Tbl_Chaxun> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zs.Model.Tbl_Chaxun> DataTableToList(DataTable dt)
		{
			List<zs.Model.Tbl_Chaxun> modelList = new List<zs.Model.Tbl_Chaxun>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				zs.Model.Tbl_Chaxun model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new zs.Model.Tbl_Chaxun();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["name"]!=null && dt.Rows[n]["name"].ToString()!="")
					{
					model.name=dt.Rows[n]["name"].ToString();
					}
					if(dt.Rows[n]["stuno"]!=null && dt.Rows[n]["stuno"].ToString()!="")
					{
					model.stuno=dt.Rows[n]["stuno"].ToString();
					}
					if(dt.Rows[n]["ksno"]!=null && dt.Rows[n]["ksno"].ToString()!="")
					{
					model.ksno=dt.Rows[n]["ksno"].ToString();
					}
					if(dt.Rows[n]["cardid"]!=null && dt.Rows[n]["cardid"].ToString()!="")
					{
					model.cardid=dt.Rows[n]["cardid"].ToString();
					}
					if(dt.Rows[n]["score"]!=null && dt.Rows[n]["score"].ToString()!="")
					{
					model.score=dt.Rows[n]["score"].ToString();
					}
					if(dt.Rows[n]["luquxueyuan"]!=null && dt.Rows[n]["luquxueyuan"].ToString()!="")
					{
					model.luquxueyuan=dt.Rows[n]["luquxueyuan"].ToString();
					}
					if(dt.Rows[n]["luquzhuanye"]!=null && dt.Rows[n]["luquzhuanye"].ToString()!="")
					{
					model.luquzhuanye=dt.Rows[n]["luquzhuanye"].ToString();
					}
					if(dt.Rows[n]["kstype"]!=null && dt.Rows[n]["kstype"].ToString()!="")
					{
					model.kstype=dt.Rows[n]["kstype"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

