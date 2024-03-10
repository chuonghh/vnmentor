using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for productLanguagesInfo
/// </summary>
public class partColorImagesInfo
{
	int _partColorImaID;
	string _partColorCode;
	string _pathImages;
	string _fileImages;
	int _priority;
	bool _active;
	DateTime _sysDate;

	public int partColorImaID
	{
		get { return _partColorImaID; }
		set { _partColorImaID = value; }
	}

	public string partColorCode
	{
		get { return _partColorCode; }
		set { _partColorCode = value; }
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

	public int priority
	{
		get { return _priority; }
		set { _priority = value; }
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