using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for exerciseInfo
/// </summary>
public class exerciseInfo
{
	int _exeID;
	string _cusCode;
	string _ansCode;
	DateTime _exeBegin;
	DateTime _exeEnd;
	string _exeDescription;
	bool _active;
	DateTime _sysDate;

	public int exeID
	{
		get { return _exeID; }
		set { _exeID = value; }
	}

	public string cusCode
	{
		get { return _cusCode; }
		set { _cusCode = value; }
	}

	public string ansCode
	{
		get { return _ansCode; }
		set { _ansCode = value; }
	}

	public DateTime exeBegin
	{
		get { return _exeBegin; }
		set { _exeBegin = value; }
	}

	public DateTime exeEnd
	{
		get { return _exeEnd; }
		set { _exeEnd = value; }
	}

	public string exeDescription
	{
		get { return _exeDescription; }
		set { _exeDescription = value; }
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