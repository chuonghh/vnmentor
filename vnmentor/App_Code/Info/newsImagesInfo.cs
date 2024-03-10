using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for newsImagesInfo
/// </summary>
public class newsImagesInfo
{
	int _neiID;

	string _neiDescription;
	string _pathImages;
	string _fileImages;
	int _priority;
	string _href;
	bool _active;
	DateTime _sysDate;

	public int neiID
	{
		get { return _neiID; }
		set { _neiID = value; }
	}
	string _newCode;
	public string newCode
	{
		get { return _newCode; }
		set { _newCode = value; }
	}

	public string neiDescription
	{
		get { return _neiDescription; }
		set { _neiDescription = value; }
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

	public string href
	{
		get { return _href; }
		set { _href = value; }
	}

	public bool active
	{
		get { return _active; }
		set { _active = value; }
	}
	string _size;
	public string size
	{
		get { return _size; }
		set { _size = value; }
	}
	public DateTime sysDate
	{
		get { return _sysDate; }
		set { _sysDate = value; }
	}

}