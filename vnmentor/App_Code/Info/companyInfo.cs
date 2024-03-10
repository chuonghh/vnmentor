using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

 
	public class companyInfo
	{ 
		int _comID;
		string _comCode;
		string _comName;
		string _comAddress;
		string _comTel;
		string _comEmail;
		string _comTax;
		string _comDescription;
		bool _active;
		DateTime _comDate;

		public int comID
		{
			get { return _comID; }
			set { _comID = value; }
		}
		public string comCode
		{
			get { return _comCode; }
			set { _comCode = value; }
		}
		 
		public string comName
		{
			get { return _comName; }
			set { _comName = value; }
		}

		public string comAddress
		{
			get { return _comAddress; }
			set { _comAddress = value; }
		}

		public string comTel
		{
			get { return _comTel; }
			set { _comTel = value; }
		}

		public string comEmail
		{
			get { return _comEmail; }
			set { _comEmail = value; }
		}

		public string comTax
		{
			get { return _comTax; }
			set { _comTax = value; }
		}

		public string comDescription
		{
			get { return _comDescription; }
			set { _comDescription = value; }
		}

		public bool active
		{
			get { return _active; }
			set { _active = value; }
		}

		public DateTime comDate
		{
			get { return _comDate; }
			set { _comDate = value; }
		}
	}
 