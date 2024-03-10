using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for productColorImagesInfo
/// </summary>
public class partClassInfo
{
	string _partClassCode;
	string _name;
	string _description;
	string _pathImages;
	string _fileImages;
	string _empCode;
	bool _active;
	DateTime _sysDate;

	public string partClassCode
	{
		get { return _partClassCode; }
		set { _partClassCode = value; }
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