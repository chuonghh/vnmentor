using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for partGroupInfo
/// </summary>
public class partGroupInfo
{
	string _partGroupCode;
	string _name;
	string _description;
	string _pathImages;
	string _fileImages;
	string _partrentID;
	int _level;
	string _empCode;
	bool _active;
	DateTime _sysDate;

	public string partGroupCode
	{
		get { return _partGroupCode; }
		set { _partGroupCode = value; }
	}

	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	public string Description
	{
		get { return _description; }
		set { _description = value; }
	}

	public string pathImages
	{
		get { return _pathImages; }
		set { _pathImages = value; }
	}

	public string fileImages
	{
		get { return _fileImages; }
		set { _fileImages = value; }
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