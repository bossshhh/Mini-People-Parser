using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Person
    {
        //Private feilds
        private string _firstname = "";
        private string _lastname = "";
        private string _workspace = "";
        private int _age = 0;

        //public feilds
        public string Firstname
        {
            get { return _firstname; }
            //set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            //set { _lastname = value; }
        }
        public string Workspace
        {
            get { return _workspace; }
            //set { _workspace = value; }
        }
        public int Age
        {
            get { return _age; }
            //set { _age = _age; }   
        }
        /// <summary>
        /// Const
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="workspace"></param>
        /// <param name="age"></param>
        public Person(string firstname, string lastname, string workspace, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _workspace = workspace;
            _age = age;
        }
    }
}