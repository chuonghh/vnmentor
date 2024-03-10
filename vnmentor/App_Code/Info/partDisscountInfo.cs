using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for disscountInfo
/// </summary>
public class partDisscountInfo
{
	int _disID;
	string _partColorCode;
	DateTime _beginDate;
	DateTime _expiredDate;
	double _disscount;
	bool _active;
	DateTime _sysDate;

	public int disID
	{
		get { return _disID; }
		set { _disID = value; }
	}

	public string partColorCode
	{
		get { return _partColorCode; }
		set { _partColorCode = value; }
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

	public double disscount
	{
		get { return _disscount; }
		set { _disscount = value; }
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