using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for fyInfo
/// </summary>
public class fyInfo
{ 
		string _fyCode;
		int _fyID;
		string _fyName;
		string _fyDescription;
		DateTime _beginDate;
		DateTime _expiredDate;
		bool _active;
		DateTime _sysDate;

		public string fyCode
	{
		get { return _fyCode; }
		set { _fyCode = value; }
	}

	public int fyID
	{
		get { return _fyID; }
		set { _fyID = value; }
	}

	public string fyName
	{
		get { return _fyName; }
		set { _fyName = value; }
	}

	public string fyDescription
	{
		get { return _fyDescription; }
		set { _fyDescription = value; }
	}

	public DateTime beginDate
	{
		get { return _beginDate; }
		set { _beginDate = value; }
	}

	public DateTime expiredDate
	{
		get { return _expiredDate; }
		set { _expiredDate = value; }
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
 
  