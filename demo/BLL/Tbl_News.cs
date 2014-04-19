using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using zs.Model;
namespace zs.BLL
{
	/// <summary>
	/// Tbl_News
	/// </summary>
	public partial class Tbl_News
	{
		private readonly zs.DAL.Tbl_News dal=new zs.DAL.Tbl_News();
		public Tbl_News()
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

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(zs.Model.Tbl_News model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(zs.Model.Tbl_News model)
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
		public zs.Model.Tbl_News GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public zs.Model.Tbl_News GetModelByCache(int id)
		{
			
			string CacheKey = "Tbl_NewsModel-" + id;
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
			return (zs.Model.Tbl_News)objModel;
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
		public List<zs.Model.Tbl_News> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<zs.Model.Tbl_News> DataTableToList(DataTable dt)
		{
			List<zs.Model.Tbl_News> modelList = new List<zs.Model.Tbl_News>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				zs.Model.Tbl_News model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new zs.Model.Tbl_News();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["title"]!=null && dt.Rows[n]["title"].ToString()!="")
					{
					model.title=dt.Rows[n]["title"].ToString();
					}
					if(dt.Rows[n]["conts"]!=null && dt.Rows[n]["conts"].ToString()!="")
					{
					model.conts=dt.Rows[n]["conts"].ToString();
					}
					if(dt.Rows[n]["addtime"]!=null && dt.Rows[n]["addtime"].ToString()!="")
					{
						model.addtime=DateTime.Parse(dt.Rows[n]["addtime"].ToString());
					}
					if(dt.Rows[n]["author"]!=null && dt.Rows[n]["author"].ToString()!="")
					{
					model.author=dt.Rows[n]["author"].ToString();
					}
					if(dt.Rows[n]["leiid"]!=null && dt.Rows[n]["leiid"].ToString()!="")
					{
						model.leiid=int.Parse(dt.Rows[n]["leiid"].ToString());
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

