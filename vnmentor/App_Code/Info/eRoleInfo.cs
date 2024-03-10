using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for eRoleInfo
/// </summary>
public class eRoleInfo
{
	int _tRoldID;
	string _empCode;
	string _majorCode;
	string _description;
	string _able;
	DateTime _sysDate;

	public int tRoldID
	{
		get { return _tRoldID; }
		set { _tRoldID = value; }
	}

	public string empCode
	{
		get { return _empCode; }
		set { _empCode = value; }
	}

	public string majorCode
	{
		get { return _majorCode; }
		set { _majorCode = value; }
	}

	public string description
	{
		get { return _description; }
		set { _description = value; }
	}

	public string able
	{
		get { return _able; }
		set { _able = value; }
	}

	public DateTime sysDate
	{
		get { return _sysDate; }
		set { _sysDate = value; }
	}
}