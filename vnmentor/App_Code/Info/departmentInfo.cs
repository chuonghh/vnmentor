using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
    public class departmentInfo
{
		string _depCode;
		int _depID;
		string _comCode;
		string _depName;
		string _depDependsID;
		string _depDescription;
		bool _active;
		DateTime _sysDate;

		public string depCode
		{
			get { return _depCode; }
			set { _depCode = value; }
		}

		public int depID
		{
			get { return _depID; }
			set { _depID = value; }
		}

		public string comCode
		{
			get { return _comCode; }
			set { _comCode = value; }
		}

		public string depName
		{
			get { return _depName; }
			set { _depName = value; }
		}

		public string depDependsID
		{
			get { return _depDependsID; }
			set { _depDependsID = value; }
		}

		public string depDescription
		{
			get { return _depDescription; }
			set { _depDescription = value; }
		}

		public bool active
		{
			get { return _active; }
			set { _active = value; }
		}

		public DateTime sysDate
		{
			get { return _sysDate; }
			set { _sysDate = value; }
		}
	}
 