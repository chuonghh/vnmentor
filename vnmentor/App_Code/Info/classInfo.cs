using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for classInfo
/// </summary>
public class classInfo
{
	string _classCode;
	string _fyCode;
	string _depCode;
	int _classID;
	string _description;
	bool _active;
	DateTime _sysDate;

	public string classCode
	{
		get { return _classCode; }
		set { _classCode = value; }
	}

	public string fyCode
	{
		get { return _fyCode; }
		set { _fyCode = value; }
	}

	public string depCode
	{
		get { return _depCode; }
		set { _depCode = value; }
	}

	public int classID
	{
		get { return _classID; }
		set { _classID = value; }
	}

	public string Description
	{
		get { return _description; }
		set { _description = value; }
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