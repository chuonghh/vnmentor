using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for checkAttenInfo
/// </summary>
public class checkAttenInfo
{
	int _checkAID;
	string _empCode;
	string _cusCode;
	string _subCode;
	string _slot1;
	string _slot2;
	string _slot3;
	DateTime _datetime;
	bool _active;
	DateTime _sysDate;
	public int checkAID
	{
		get { return _checkAID; }
		set { _checkAID = value; }
	}

	public string empCode
	{
		get { return _empCode; }
		set { _empCode = value; }
	}

	public string cusCode
	{
		get { return _cusCode; }
		set { _cusCode = value; }
	}

	public string subCode
	{
		get { return _subCode; }
		set { _subCode = value; }
	}

	public string slot1
	{
		get { return _slot1; }
		set { _slot1 = value; }
	}

	public string slot2
	{
		get { return _slot2; }
		set { _slot2 = value; }
	}

	public string slot3
	{
		get { return _slot3; }
		set { _slot3 = value; }
	}

	public DateTime datetime
	{
		get { return _datetime; }
		set { _datetime = value; }
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