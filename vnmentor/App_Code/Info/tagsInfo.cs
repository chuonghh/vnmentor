using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tagsInfo
/// </summary>
public class tagsInfo
{
	int _tagID;
	string _tagsCode;
	string _tagName;
	string _tagDescription;
	bool _active;
	DateTime _sysDate;
	string _typeCode;

	public int tagID
	{
		get { return _tagID; }
		set { _tagID = value; }
	}

	public string tagsCode
	{
		get { return _tagsCode; }
		set { _tagsCode = value; }
	}

	public string tagName
	{
		get { return _tagName; }
		set { _tagName = value; }
	}

	public string tagDescription
	{
		get { return _tagDescription; }
		set { _tagDescription = value; }
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

	public string typeCode
	{
		get { return _typeCode; }
		set { _typeCode = value; }
	}
}