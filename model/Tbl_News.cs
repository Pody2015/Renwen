using System;
namespace zs.Model
{
    /// <summary>
    /// Tbl_News:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Tbl_News
    {
        public Tbl_News()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _conts;
        private DateTime? _addtime;
        private string _author;
        private int? _leiid;
        private int _isrecommand = 0;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string conts
        {
            set { _conts = value; }
            get { return _conts; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? addtime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string author
        {
            set { _author = value; }
            get { return _author; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? leiid
        {
            set { _leiid = value; }
            get { return _leiid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isRecommand
        {
            set { _isrecommand = value; }
            get { return _isrecommand; }
        }
        #endregion Model

    }
}

