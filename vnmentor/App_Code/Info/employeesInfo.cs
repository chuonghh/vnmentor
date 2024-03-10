using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class employeesInfo
{
	string _empCode;
	int _empID;
	string _depCode;
	string _empName;
	string _password;
	DateTime _birthDay;
	string _birthPlace;
	string _sex;
	string _identityCard;
	string _email;
	string _phone;
	string _address;
	string _address1;
	string _description;
	DateTime _beginDate;
	DateTime _contractBegin;
	DateTime _contractEnd;
	string _bHYT;
	string _bHXH;
	string _pathImages;
	string _fileImages;
	bool _active;
	DateTime _sysDate;

	public string empCode
	{
		get { return _empCode; }
		set { _empCode = value; }
	}

	public int empID
	{
		get { return _empID; }
		set { _empID = value; }
	}

	public string depCode
	{
		get { return _depCode; }
		set { _depCode = value; }
	}

	public string empName
	{
		get { return _empName; }
		set { _empName = value; }
	}

	public string password
	{
		get { return _password; }
		set { _password = value; }
	}

	public DateTime birthDay
	{
		get { return _birthDay; }
		set { _birthDay = value; }
	}

	public string birthPlace
	{
		get { return _birthPlace; }
		set { _birthPlace = value; }
	}

	public string sex
	{
		get { return _sex; }
		set { _sex = value; }
	}

	public string identityCard
	{
		get { return _identityCard; }
		set { _identityCard = value; }
	}

	public string email
	{
		get { return _email; }
		set { _email = value; }
	}

	public string phone
	{
		get { return _phone; }
		set { _phone = value; }
	}

	public string address
	{
		get { return _address; }
		set { _address = value; }
	}

	public string address1
	{
		get { return _address1; }
		set { _address1 = value; }
	}

	public string description
	{
		get { return _description; }
		set { _description = value; }
	}

	public DateTime beginDate
	{
		get { return _beginDate; }
		set { _beginDate = value; }
	}

	public DateTime contractBegin
	{
		get { return _contractBegin; }
		set { _contractBegin = value; }
	}

	public DateTime contractEnd
	{
		get { return _contractEnd; }
		set { _contractEnd = value; }
	}

	public string BHYT
	{
		get { return _bHYT; }
		set { _bHYT = value; }
	}

	public string BHXH
	{
		get { return _bHXH; }
		set { _bHXH = value; }
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