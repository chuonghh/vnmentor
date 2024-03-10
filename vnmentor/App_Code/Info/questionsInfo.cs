using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for questionsInfo
/// </summary>
public class questionsInfo
{
	string _queCode;
	string _topCode;
	int _queID;
	string _queName;
	string _queDescription;
	int _points;
	bool _random;
	bool _active;
	DateTime _sysDate;

	public string queCode
	{
		get { return _queCode; }
		set { _queCode = value; }
	}

	public string topCode
	{
		get { return _topCode; }
		set { _topCode = value; }
	}

	public int queID
	{
		get { return _queID; }
		set { _queID = value; }
	}

	public string queName
	{
		get { return _queName; }
		set { _queName = value; }
	}

	public string queDescription
	{
		get { return _queDescription; }
		set { _queDescription = value; }
	}

	public int points
	{
		get { return _points; }
		set { _points = value; }
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