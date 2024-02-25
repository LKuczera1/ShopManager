using System;
using Microsoft.Data.SqlClient;

public class Class1
{
	private string _connectionParameters;
	private string _server;

	public string server
	{
		get
		{
			return _server;
		}

		set
		{
			_server = value;
		}
    }

    private string _catalog;

	public string catalog
    {
        get
        {
            return _catalog;
        }

        set
        {
            _catalog = value;
        }
    }

	

    public Class1()
	{
		connectionParameters = "Server = " + _server +"; Initial Catalog =" +_catalog+"; Integrated security = true; Encrypt = false";
		_server = "DESKTOP-25RR54T";
		_catalog = "Magazyn";

    }
}
