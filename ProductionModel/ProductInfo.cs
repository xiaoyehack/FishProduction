using System;
namespace ProductionModel
{
	/// <summary>
	/// ProInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProductInfo
    {
		public ProductInfo()
		{}
		#region Model
		private int _id;
		private string _boardid;
		private string _simid;
		private string _sofeedti;
		private DateTime? _prodate;
		private string _otherone;
		private string _othertwo;
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
		public string BoardId
		{
			set{ _boardid=value;}
			get{return _boardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SimId
		{
			set{ _simid=value;}
			get{return _simid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SofeEdti
		{
			set{ _sofeedti=value;}
			get{return _sofeedti;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Prodate
		{
			set{ _prodate=value;}
			get{return _prodate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherOne
		{
			set{ _otherone=value;}
			get{return _otherone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OtherTwo
		{
			set{ _othertwo=value;}
			get{return _othertwo;}
		}
		#endregion Model

	}
}

