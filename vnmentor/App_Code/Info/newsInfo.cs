using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for newsInfo
/// </summary>
public class newsInfo
{
	string _newCode;
	string _menCode;
	int _newID;
	string _title;
	string _sumContent;
	string _content;
	string _description;
	string _author;
	string _source;
	int _countView;
	bool _active;
	DateTime _sysDate;

	public string newCode
	{
		get { return _newCode; }
		set { _newCode = value; }
	}

	public string menCode
	{
		get { return _menCode; }
		set { _menCode = value; }
	}

	public int newID
	{
		get { return _newID; }
		set { _newID = value; }
	}

	public string title
	{
		get { return _title; }
		set { _title = value; }
	}

	public string sumContent
	{
		get { return _sumContent; }
		set { _sumContent = value; }
	}

	public string content
	{
		get { return _content; }
		set { _content = value; }
	}

	public string description
	{
		get { return _description; }
		set { _description = value; }
	}

	public string author
	{
		get { return _author; }
		set { _author = value; }
	}

	public string source
	{
		get { return _source; }
		set { _source = value; }
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