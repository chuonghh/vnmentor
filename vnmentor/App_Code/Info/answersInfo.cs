using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for answersInfo
/// </summary>
public class answersInfo
{
	string _ansCode;
	string _queCode;
	int _ansID;
	string _ansName;
	bool _ansCheck;
	string _checkName;
	bool _random;
	bool _active;
	DateTime _sysDate;

	public string ansCode
	{
		get { return _ansCode; }
		set { _ansCode = value; }
	}

	public string queCode
	{
		get { return _queCode; }
		set { _queCode = value; }
	}

	public int ansID
	{
		get { return _ansID; }
		set { _ansID = value; }
	}

	public string ansName
	{
		get { return _ansName; }
		set { _ansName = value; }
	}

	public bool ansCheck
	{
		get { return _ansCheck; }
		set { _ansCheck = value; }
	}

	public string checkName
	{
		get { return _checkName; }
		set { _checkName = value; }
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