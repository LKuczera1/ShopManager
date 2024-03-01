using System;
using System.Data;
using Microsoft.Data.SqlClient;

public class DatabaseConnector
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
	private SqlConnection _connection;
    private SqlCommand _command;
    private SqlDataAdapter _dataAdapter;
    private DataSet _dataSet;

    private DatabaseConnector()
    {
        _server = "DESKTOP-25RR54T";
        _catalog = "Magazyn";
        _connectionParameters = "Server = " + _server + "; Initial Catalog =" + _catalog + "; Integrated security = true; Encrypt = false";

        try
        {
            _connection = new SqlConnection(_connectionParameters);
            _connection.Open();

            _command = new SqlCommand();

            _command.Connection = _connection;

            _dataAdapter = new SqlDataAdapter();

            _dataSet = new DataSet();
        }
        catch (Exception e)
        {
            MessageBox.Show("An error occured while connecting to database", "Error", MessageBoxButtons.OK);
        }

    }
    public DatabaseConnector(string server, string catalog)
    {
        _server = server;
        _catalog = catalog;
        _connectionParameters = "Server = " + _server + "; Initial Catalog =" + _catalog + "; Integrated security = true; Encrypt = false";

        try
        {
            _connection = new SqlConnection(_connectionParameters);
            _connection.Open();

            _command = new SqlCommand();

            _command.Connection = _connection;

            _dataAdapter = new SqlDataAdapter();

            _dataSet = new DataSet();
        }
        catch (Exception e)
        {
            MessageBox.Show("An error occured while connecting to database", "Error", MessageBoxButtons.OK);
        }

    }

    ~DatabaseConnector()
    {

    }

    public void databaseNonQuery(string query)
    {
        _command.Connection = _connection;
        _command.CommandText = query;

        try
        {
            _command.ExecuteNonQuery();
        }
        catch(Exception e)
        {
            MessageBox.Show("An error occured while sending query to database", "Error", MessageBoxButtons.OK);
        }
    }
    public DataSet databaseQuery(string query)
    {
        _command.Connection = _connection;
        _command.CommandText = query;

        try
        {
            SqlDataReader reader =  _command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + reader[3].ToString() + reader[4].ToString());
                }
                reader.Close(); //jest bałagan, nie wiem co robić dalej
                //Ale udalo nam sie odczytac co zwraca baza danych.
                //notka: Dodawac wiecej komentarzy

                reader = null;
            }
            catch(Exception ee)
            {

            }
        }
        catch (Exception e)
        {
            MessageBox.Show("An error occured while sending query to database", "Error", MessageBoxButtons.OK);
        }

        return _dataSet;
    }
}
