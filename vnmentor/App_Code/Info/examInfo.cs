using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for examInfo
/// </summary>
public class examInfo
{
	string _exaCode;
	int _clsID;
	int _exaID;
	string _exaName;
	string _exaDescription;
	DateTime _exaBegin;
	DateTime _exaEnd;
	int _exaTimeFinish;
	string _comments;
	int _factor;
	int _numQuest;
	string _empCode;
	bool _active;
	DateTime _sysDate;

	public string exaCode
	{
		get { return _exaCode; }
		set { _exaCode = value; }
	}

	public int clsID
	{
		get { return _clsID; }
		set { _clsID = value; }
	}

	public int exaID
	{
		get { return _exaID; }
		set { _exaID = value; }
	}

	public string exaName
	{
		get { return _exaName; }
		set { _exaName = value; }
	}

	public string exaDescription
	{
		get { return _exaDescription; }
		set { _exaDescription = value; }
	}

	public DateTime exaBegin
	{
		get { return _exaBegin; }
		set { _exaBegin = value; }
	}

	public DateTime exaEnd
	{
		get { return _exaEnd; }
		set { _exaEnd = value; }
	}

	public int exaTimeFinish
	{
		get { return _exaTimeFinish; }
		set { _exaTimeFinish = value; }
	}

	public string comments
	{
		get { return _comments; }
		set { _comments = value; }
	}

	public int factor
	{
		get { return _factor; }
		set { _factor = value; }
	}

	public int numQuest
	{
		get { return _numQuest; }
		set { _numQuest = value; }
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