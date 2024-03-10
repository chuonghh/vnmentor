using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for partGiftInfo
/// </summary>
public class partGiftInfo
{
	string _giftCode;
	string _partColorCode;
	DateTime _beginDate;
	DateTime _expiredDate;
	double _payments;
	bool _active;
	DateTime _sysDate;

	public string giftCode
	{
		get { return _giftCode; }
		set { _giftCode = value; }
	}

	public string partColorCode
	{
		get { return _partColorCode; }
		set { _partColorCode = value; }
	}

	public DateTime beginDate
	{
		get { return _beginDate; }
		set { _beginDate = value; }
	}

	public DateTime expiredDate
	{
		get { return _expiredDate; }
		set { _expiredDate = value; }
	}

	public double payments
	{
		get { return _payments; }
		set { _payments = value; }
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