using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for schedulingInfo
/// </summary>
public class schedulingInfo
{
	int _schID;
	string _couCode;
	string _schCode;
	bool _allEveryDay;
	DateTime _startDate;
	TimeSpan _startTime;
	DateTime _endDate;
	TimeSpan _endTime;
	string _label;
	string _showTimeAs;
	bool _recurrence;


	public int schID
	{
		get { return _schID; }
		set { _schID = value; }
	}

	public string couCode
	{
		get { return _couCode; }
		set { _couCode = value; }
	}

	public string schCode
	{
		get { return _schCode; }
		set { _schCode = value; }
	}

	public bool allEveryDay
	{
		get { return _allEveryDay; }
		set { _allEveryDay = value; }
	}

	public DateTime startDate
	{
		get { return _startDate; }
		set { _startDate = value; }
	}

	public TimeSpan startTime
	{
		get { return _startTime; }
		set { _startTime = value; }
	}

	public DateTime endDate
	{
		get { return _endDate; }
		set { _endDate = value; }
	}

	public TimeSpan endTime
	{
		get { return _endTime; }
		set { _endTime = value; }
	}

	public string label
	{
		get { return _label; }
		set { _label = value; }
	}

	public string showTimeAs
	{
		get { return _showTimeAs; }
		set { _showTimeAs = value; }
	}

	public bool recurrence
	{
		get { return _recurrence; }
		set { _recurrence = value; }
	}
	
}