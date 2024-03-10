using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for uploadTempInfo
/// </summary>
public class uploadTempInfo
{

	int _ultID;
	string _title;
	string _description;
	string _pathImages;
	string _fileImages;
	DateTime _sysDate;

	string _newCode;
	public string newCode
	{
		get { return _newCode; }
		set { _newCode = value; }
	}
	public int ultID
	{
		get { return _ultID; }
		set { _ultID = value; }
	}

	public string title
	{
		get { return _title; }
		set { _title = value; }
	}

	public string description
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

