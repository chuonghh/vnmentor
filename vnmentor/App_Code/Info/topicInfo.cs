using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for topicInfo
/// </summary>
public class topicInfo
{
	string _topCode;
	string _exaCode;
	int _topID;
	string _topName;
	string _topDescription;
	bool _random;
	bool _active;
	DateTime _sysDate;

	public string topCode
	{
		get { return _topCode; }
		set { _topCode = value; }
	}

	public string exaCode
	{
		get { return _exaCode; }
		set { _exaCode = value; }
	}

	public int topID
	{
		get { return _topID; }
		set { _topID = value; }
	}

	public string topName
	{
		get { return _topName; }
		set { _topName = value; }
	}

	public string topDescription
	{
		get { return _topDescription; }
		set { _topDescription = value; }
	}

	public bool random
	{
		get { return _random; }
		set { _random = value; }
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