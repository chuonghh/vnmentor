using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for partLanguagesInfo
/// </summary>
public class partLanguagesInfo
{
	int _partLanID;
	string _partCode;
	string _lanCode;
	string _partLanCode;
	string _partLanName;
	string _partLanDescription;
	string _empCode;
	bool _active;
	DateTime _sysDate;

	public int partLanID
	{
		get { return _partLanID; }
		set { _partLanID = value; }
	}

	public string partCode
	{
		get { return _partCode; }
		set { _partCode = value; }
	}

	public string lanCode
	{
		get { return _lanCode; }
		set { _lanCode = value; }
	}

	public string partLanCode
	{
		get { return _partLanCode; }
		set { _partLanCode = value; }
	}

	public string partLanName
	{
		get { return _partLanName; }
		set { _partLanName = value; }
	}

	public string partLanDescription
	{
		get { return _partLanDescription; }
		set { _partLanDescription = value; }
	}

	public string empCode
	{
		get { return _empCode; }
		set { _empCode = value; }
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