using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for empSubjectsInfo
/// </summary>
public class empSubjectsInfo
{
	int _emsID;
	string _empCode;
	string _subCode;
	string _descriptions;
	bool _active;
	DateTime _sysDate;

	public int emsID
	{
		get { return _emsID; }
		set { _emsID = value; }
	}

	public string empCode
	{
		get { return _empCode; }
		set { _empCode = value; }
	}

	public string subCode
	{
		get { return _subCode; }
		set { _subCode = value; }
	}

	public string descriptions
	{
		get { return _descriptions; }
		set { _descriptions = value; }
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