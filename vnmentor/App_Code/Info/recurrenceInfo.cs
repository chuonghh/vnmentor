using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for recurrenceInfo
/// </summary>
public class recurrenceInfo
{
	int _recID;
	string _schCode;
	string _recurrenceType;
	bool _dailyEvery;
	int _dailyEveryData;
	bool _dailyEveryWeekday;
	/// 
	int _weeklyEveryData;
	bool _weeklySunday;
	bool _weeklyMonday;
	bool _weeklyTueday;
	bool _weeklyWedDay;
	bool _weeklyThuday;
	bool _weeklyFriday;
	bool _weeklySatday;
	/// 
	bool _monthlyDay;
	int _monthlyDayData;
	int _monthlyOfEveryDay;
	bool _monthlyThe;
	string _monthlyTheData;
	string _monthlyTheData1;
	int _monthlyofEveryThe;
	/// 
	bool _yearEvery;
	string _yearEveryData;
	int _yearEveryData1;
	bool _yearThe;
	string _yearTheData;
	string _yearTheData1;
	string _yearOf;
	bool _noEndDate;
	bool _endAfter;
	int _endAfterData;
	bool _endBy;
	DateTime _endByData;
	string _description;
	bool _active;
	DateTime _sysDate;

	public int recID
	{
		get { return _recID; }
		set { _recID = value; }
	}

	public string schCode
	{
		get { return _schCode; }
		set { _schCode = value; }
	}
	int _emsID;
	public int emsID
	{
		get { return _emsID; }
		set { _emsID = value; }
	}

	public string recurrenceType
	{
		get { return _recurrenceType; }
		set { _recurrenceType = value; }
	}

	public bool dailyEvery
	{
		get { return _dailyEvery; }
		set { _dailyEvery = value; }
	}

	public int dailyEveryData
	{
		get { return _dailyEveryData; }
		set { _dailyEveryData = value; }
	}

	public bool dailyEveryWeekday
	{
		get { return _dailyEveryWeekday; }
		set { _dailyEveryWeekday = value; }
	}

	public int weeklyEveryData
	{
		get { return _weeklyEveryData; }
		set { _weeklyEveryData = value; }
	}

	public bool weeklySunday
	{
		get { return _weeklySunday; }
		set { _weeklySunday = value; }
	}

	public bool weeklyMonday
	{
		get { return _weeklyMonday; }
		set { _weeklyMonday = value; }
	}

	public bool weeklyTueday
	{
		get { return _weeklyTueday; }
		set { _weeklyTueday = value; }
	}

	public bool weeklyWedday
	{
		get { return _weeklyWedDay; }
		set { _weeklyWedDay = value; }
	}

	public bool weeklyThuday
	{
		get { return _weeklyThuday; }
		set { _weeklyThuday = value; }
	}

	public bool weeklyFriday
	{
		get { return _weeklyFriday; }
		set { _weeklyFriday = value; }
	}

	public bool weeklySatday
	{
		get { return _weeklySatday; }
		set { _weeklySatday = value; }
	}

	public bool monthlyDay
	{
		get { return _monthlyDay; }
		set { _monthlyDay = value; }
	}

	public int monthlyDayData
	{
		get { return _monthlyDayData; }
		set { _monthlyDayData = value; }
	}

	public int monthlyOfEveryDay
	{
		get { return _monthlyOfEveryDay; }
		set { _monthlyOfEveryDay = value; }
	}

	public bool monthlyThe
	{
		get { return _monthlyThe; }
		set { _monthlyThe = value; }
	}

	public string monthlyTheData
	{
		get { return _monthlyTheData; }
		set { _monthlyTheData = value; }
	}

	public string monthlyTheData1
	{
		get { return _monthlyTheData1; }
		set { _monthlyTheData1 = value; }
	}

	public int monthlyofEveryThe
	{
		get { return _monthlyofEveryThe; }
		set { _monthlyofEveryThe = value; }
	}

	public bool yearEvery
	{
		get { return _yearEvery; }
		set { _yearEvery = value; }
	}

	public string yearEveryData
	{
		get { return _yearEveryData; }
		set { _yearEveryData = value; }
	}

	public int yearEveryData1
	{
		get { return _yearEveryData1; }
		set { _yearEveryData1 = value; }
	}

	public bool yearThe
	{
		get { return _yearThe; }
		set { _yearThe = value; }
	}

	public string yearTheData
	{
		get { return _yearTheData; }
		set { _yearTheData = value; }
	}

	public string yearTheData1
	{
		get { return _yearTheData1; }
		set { _yearTheData1 = value; }
	}

	public string yearOf
	{
		get { return _yearOf; }
		set { _yearOf = value; }
	}

	public bool noEndDate
	{
		get { return _noEndDate; }
		set { _noEndDate = value; }
	}

	public bool endAfter
	{
		get { return _endAfter; }
		set { _endAfter = value; }
	}

	public int endAfterData
	{
		get { return _endAfterData; }
		set { _endAfterData = value; }
	}

	public bool endBy
	{
		get { return _endBy; }
		set { _endBy = value; }
	}

	public DateTime endByData
	{
		get { return _endByData; }
		set { _endByData = value; }
	}

	public string description
	{
		get { return _description; }
		set { _description = value; }
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