using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for customersInfo
/// </summary>
public class customersInfo
{
	string _cusCode;
	int _cusID;
	string _classCode;
	string _cusName;
	string _cusCard;
	string _cusEmail;
	string _cusPassword;
	string _cusPhone;
	string _cusAddress;
	string _cusAddress1;
	string _cusDescription;
	DateTime _cusDOB;
	string _cusImages;
	string _cusFileImages;
	string _fyCode;
	bool _active;
	DateTime _sysDate;

	public string cusCode
	{
		get { return _cusCode; }
		set { _cusCode = value; }
	}

	public int cusID
	{
		get { return _cusID; }
		set { _cusID = value; }
	}

	public string classCode
	{
		get { return _classCode; }
		set { _classCode = value; }
	}

	public string cusName
	{
		get { return _cusName; }
		set { _cusName = value; }
	}

	public string cusCard
	{
		get { return _cusCard; }
		set { _cusCard = value; }
	}

	public string cusEmail
	{
		get { return _cusEmail; }
		set { _cusEmail = value; }
	}

	public string cusPassword
	{
		get { return _cusPassword; }
		set { _cusPassword = value; }
	}

	public string cusPhone
	{
		get { return _cusPhone; }
		set { _cusPhone = value; }
	}

	public string cusAddress
	{
		get { return _cusAddress; }
		set { _cusAddress = value; }
	}

	public string cusAddress1
	{
		get { return _cusAddress1; }
		set { _cusAddress1 = value; }
	}

	public string cusDescription
	{
		get { return _cusDescription; }
		set { _cusDescription = value; }
	}

	public DateTime cusDOB
	{
		get { return _cusDOB; }
		set { _cusDOB = value; }
	}

	public string cusImages
	{
		get { return _cusImages; }
		set { _cusImages = value; }
	}

	public string cusFileImages
	{
		get { return _cusFileImages; }
		set { _cusFileImages = value; }
	}

	public string fyCode
	{
		get { return _fyCode; }
		set { _fyCode = value; }
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