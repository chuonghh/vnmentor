using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for majorsInfo
/// </summary>
public class majorsInfo
{
	string _maCode;
	int _maID;
	string _maName;
	string _maDescription;
	DateTime _sysDate;

	public string maCode
	{
		get { return _maCode; }
		set { _maCode = value; }
	}

	public int maID
	{
		get { return _maID; }
		set { _maID = value; }
	}

	public string maName
	{
		get { return _maName; }
		set { _maName = value; }
	}

	public string maDescription
	{
		get { return _maDescription; }
		set { _maDescription = value; }
	}

	public DateTime sysDate
	{
		get { return _sysDate; }
		set { _sysDate = value; }
	}
}