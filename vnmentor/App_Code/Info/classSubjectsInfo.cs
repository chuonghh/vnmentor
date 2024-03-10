using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for classSubjectsInfo
/// </summary>
public class classSubjectsInfo
{
	int _csID;
	string _classCode;
	string _subCode;
	int _semester;
	string _fyCode;
	bool _active;
	DateTime _sysDate;

	public int csID
	{
		get { return _csID; }
		set { _csID = value; }
	}

	public string classCode
	{
		get { return _classCode; }
		set { _classCode = value; }
	}

	public string subCode
	{
		get { return _subCode; }
		set { _subCode = value; }
	}

	public int semester
	{
		get { return _semester; }
		set { _semester = value; }
	}

	public string fyCode
	{
		get { return _fyCode; }
		set { _fyCode = value; }
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