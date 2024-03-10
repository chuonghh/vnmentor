using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for empPositionInfo
/// </summary>
public class empPositionInfo
{
	int _epsID;
	string _empCode;
	string _posCode;
	string _depCode;
	string _epsDescription;
	bool _active;
	DateTime _sysDate;

	public int epsID
	{
		get { return _epsID; }
		set { _epsID = value; }
	}

	public string empCode
	{
		get { return _empCode; }
		set { _empCode = value; }
	}

	public string posCode
	{
		get { return _posCode; }
		set { _posCode = value; }
	}

	public string depCode
	{
		get { return _depCode; }
		set { _depCode = value; }
	}

	public string epsDescription
	{
		get { return _epsDescription; }
		set { _epsDescription = value; }
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