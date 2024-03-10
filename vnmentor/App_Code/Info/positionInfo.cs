using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

 
	public class positionInfo
	{

		string _posCode;
		int _posID;
		string _posName;
		string _posLevel;
		string _posDescription;
		bool _active;
		DateTime _sysDate;
		public string posCode
		{
			get { return _posCode; }
			set { _posCode = value; }
		}

		public int posID
		{
			get { return _posID; }
			set { _posID = value; }
		}

		public string posName
		{
			get { return _posName; }
			set { _posName = value; }
		}

		public string posLevel
		{
			get { return _posLevel; }
			set { _posLevel = value; }
		}

		public string posDescription
		{
			get { return _posDescription; }
			set { _posDescription = value; }
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
 