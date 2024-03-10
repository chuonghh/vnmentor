using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for colorInfo
/// </summary>
public class colorInfo
{
	string _colCode;
	string _colName;
	string _colDescription;
	string _colorCSS;
	bool _active;
	DateTime _sysDate;

	public string colCode
	{
		get { return _colCode; }
		set { _colCode = value; }
	}

	public string colName
	{
		get { return _colName; }
		set { _colName = value; }
	}

	public string colDescription
	{
		get { return _colDescription; }
		set { _colDescription = value; }
	}

	public string colorCSS
	{
		get { return _colorCSS; }
		set { _colorCSS = value; }
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