using System;
using System.IO;
using System.Collections.Generic;
using static DLS.CONSTANTS;

namespace DLS
{
    [Serializable]
    public abstract class Person
    {
        public string name { get; set; }
        public string role { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public Person(string _name = BASIC_STR, string _login = BASIC_STR, string _password = BASIC_STR)
        {
            name = _name;
            login = _login;
            password = _password;
            role = BASIC_STR;
        }

        public Person()
        {
        }
    }

    [Serializable]
    public class teacher : Person
    {
        public string subject { get; set; }

        public teacher(string _name, string _login, string _password, string _subject) : base(_name, _login, _password)
        {
            role = "преподаватель";
            subject = _subject;
        }

        public teacher() { }
    }

    [Serializable]
    public class student : Person
    {
        public student(string _name, string _login, string _password) : base(_name, _login, _password)
        {
            role = "студент";
        }

        public student() { }
    }
}

