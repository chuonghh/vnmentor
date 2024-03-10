using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for courseInfo
/// </summary>
public class courseInfo
{
	string _couCode;
	int _couID;
	string _couName;
	string _couDescription;
	DateTime _startDay;
	int _timeEducation;
	string _schedule;
	int _fees;
	string _capacity;
	string _style;
	string _citCode;
	string _googleMap;
	string _conditions;
	string _participants;
	string _empCode;
	int _countView;
	bool _active;
	DateTime _sysDate;

	public string couCode
	{
		get { return _couCode; }
		set { _couCode = value; }
	}

	public int couID
	{
		get { return _couID; }
		set { _couID = value; }
	}

	public string couName
	{
		get { return _couName; }
		set { _couName = value; }
	}

	public string couDescription
	{
		get { return _couDescription; }
		set { _couDescription = value; }
	}

	public DateTime startDay
	{
		get { return _startDay; }
		set { _startDay = value; }
	}

	public int timeEducation
	{
		get { return _timeEducation; }
		set { _timeEducation = value; }
	}

	public string schedule
	{
		get { return _schedule; }
		set { _schedule = value; }
	}

	public int fees
	{
		get { return _fees; }
		set { _fees = value; }
	}

	public string capacity
	{
		get { return _capacity; }
		set { _capacity = value; }
	}

	public string style
	{
		get { return _style; }
		set { _style = value; }
	}

	public string citCode
	{
		get { return _citCode; }
		set { _citCode = value; }
	}

	public string googleMap
	{
		get { return _googleMap; }
		set { _googleMap = value; }
	}

	public string conditions
	{
		get { return _conditions; }
		set { _conditions = value; }
	}

	public string participants
	{
		get { return _participants; }
		set { _participants = value; }
	}

	public string empCode
	{
		get { return _empCode; }
		set { _empCode = value; }
	}

	public int countView
	{
		get { return _countView; }
		set { _countView = value; }
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