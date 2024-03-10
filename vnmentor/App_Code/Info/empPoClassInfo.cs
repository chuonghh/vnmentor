using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for empPoClassInfo
/// </summary>
public class empPoClassInfo
{
	int _epcID;
	int _epsID;
	string _classCode;
	bool _active;
	DateTime _sysDate;

	public int epcID
	{
		get { return _epcID; }
		set { _epcID = value; }
	}

	public int epsID
	{
		get { return _epsID; }
		set { _epsID = value; }
	}

	public string classCode
	{
		get { return _classCode; }
		set { _classCode = value; }
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