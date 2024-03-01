using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class employee
{
    int _employee_id;
    public int Employee_id
    {
        get { return _employee_id; }
    }

    string _login;
    public string Login
    {
        get { return _login; }
    }

    string _name;
    string _surname;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }

    public employee(int employee_id, string login, string name, string surname)
    {
        this._employee_id = employee_id;
        this._login = login;

        this._name = name;
        this._surname = surname;
    }

    ~employee()
    {

    }
}