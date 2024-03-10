using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for productColorInfo
/// </summary>
public class partColorInfo
{
	string _partColorCode;
	string _curCode;
	string _partCode;
	int _partColorID;
	string _name;
	string _description;
	double _priceSell;
	string _color;
	bool _active;
	DateTime _sysDate;

	public string partColorCode
	{
		get { return _partColorCode; }
		set { _partColorCode = value; }
	}

	public string curCode
	{
		get { return _curCode; }
		set { _curCode = value; }
	}

	public string partCode
	{
		get { return _partCode; }
		set { _partCode = value; }
	}

	public int partColorID
	{
		get { return _partColorID; }
		set { _partColorID = value; }
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

	public double priceSell
	{
		get { return _priceSell; }
		set { _priceSell = value; }
	}

	public string color
	{
		get { return _color; }
		set { _color = value; }
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