﻿

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 自动更新电子病历表 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblEmrAutoUpdate : BaseModel
    {   
		
		
		
		private string _pathName;  //文件路径与文件名
		
		private byte[] _fileContent;  //二进制文件
		
		private DateTime _oldVersion;  //上次版本时间
		
		private DateTime _newVersion;  //新版本时间
		
		private string _upLoadHostName;  //上传的工作站
		
		private string _upLoadIp;  //上传的IP
		
		private DateTime _operTime;  //上传的日期
		
		private int _operId;  //上传操作员
		
		private string _downLoadHostNames;  //指定工作站名或IP，空为全部
		
		private string _hospitalIds;  //
		
		private string _fileSize;  //文件大小
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 文件路径与文件名
		/// </summary>
		public string PathName
		{
			get { return _pathName;}
			set { _pathName = value;}
		}                                    
		
		/// <summary>
		/// 二进制文件
		/// </summary>
		public byte[] FileContent
		{
			get { return _fileContent;}
			set { _fileContent = value;}
		}                                    
		
		/// <summary>
		/// 上次版本时间
		/// </summary>
		public DateTime OldVersion
		{
			get { return _oldVersion;}
			set { _oldVersion = value;}
		}                                    
		
		/// <summary>
		/// 新版本时间
		/// </summary>
		public DateTime NewVersion
		{
			get { return _newVersion;}
			set { _newVersion = value;}
		}                                    
		
		/// <summary>
		/// 上传的工作站
		/// </summary>
		public string UpLoadHostName
		{
			get { return _upLoadHostName;}
			set { _upLoadHostName = value;}
		}                                    
		
		/// <summary>
		/// 上传的IP
		/// </summary>
		public string UpLoadIp
		{
			get { return _upLoadIp;}
			set { _upLoadIp = value;}
		}                                    
		
		/// <summary>
		/// 上传的日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 上传操作员
		/// </summary>
		public int OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 指定工作站名或IP，空为全部
		/// </summary>
		public string DownLoadHostNames
		{
			get { return _downLoadHostNames;}
			set { _downLoadHostNames = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string HospitalIds
		{
			get { return _hospitalIds;}
			set { _hospitalIds = value;}
		}                                    
		
		/// <summary>
		/// 文件大小
		/// </summary>
		public string FileSize
		{
			get { return _fileSize;}
			set { _fileSize = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


