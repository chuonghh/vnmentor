using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for menuInfo
/// </summary>
public class menuInfo
{
	string _menCode;
	string _menName;
	string _menDescription;
	string _fileImages;
	string _pathImages;
	string _partrentID;
	int _level;
	string _href;
	int _priority;
	string _empCode;
	bool _active;
	DateTime _sysDate;

	public string menCode
	{
		get { return _menCode; }
		set { _menCode = value; }
	}

	public string menName
	{
		get { return _menName; }
		set { _menName = value; }
	}

	public string menDescription
	{
		get { return _menDescription; }
		set { _menDescription = value; }
	}

	public string fileImages
	{
		get { return _fileImages; }
		set { _fileImages = value; }
	}

	public string pathImages
	{
		get { return _pathImages; }
		set { _pathImages = value; }
	}

	public string partrentID
	{
		get { return _partrentID; }
		set { _partrentID = value; }
	}

	public int level
	{
		get { return _level; }
		set { _level = value; }
	}

	public string href
	{
		get { return _href; }
		set { _href = value; }
	}

	public int priority
	{
		get { return _priority; }
		set { _priority = value; }
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