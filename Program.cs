using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOP_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<string> file = Readfile("values.csv");
            List<Person> people = GetPeople(file);
            PrintPeople(people);
        }

        static List<string> Readfile(string filename)
        {
            return File.ReadAllLines(filename).ToList();
        }

        private static List<string> GetItems(string line)
        {
            return line.Split(',').Select(item => item.Trim()).ToList();
        }

        private static List<Person> GetPeople(List<string> file)
        {
            List<Person> people = new();
            Dictionary<int, string> headerMap = new();

            var headers = GetItems(file[0]);
            for (int j = 0; j < headers.Count; j++)
            {
                headerMap[j] = headers[j].ToLower();
            }

            for (int i = 1; i < file.Count; i++)
            {
                var fields = GetItems(file[i]);
                string firstname = "", lastname = "", workspace = "";
                int age = 0;

                for (int j = 0; j < fields.Count; j++)
                {
                    switch (headerMap[j])
                    {
                        case "firstname":
                            firstname = fields[j];
                            break;
                        case "lastname":
                            lastname = fields[j];
                            break;
                        case "workspace":
                            workspace = fields[j];
                            break;
                        case "age":
                            int.TryParse(fields[j], out age);
                            break;
                        default:
                            Console.WriteLine($"Unknown header: {headerMap[j]}");
                            break;
                    }
                }

                Person p = new(firstname, lastname, workspace, age);
                people.Add(p);
            }

            return people;
        }

        private static void PrintPeople(List<Person> people)
        {
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Firstname} {p.Lastname} is {p.Age} years old and works in a {p.Workspace} job as a SWE.");
            }
        }
    }

    class Person
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public string Workspace { get; }
        public int Age { get; }

        public Person(string firstname, string lastname, string workspace, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Workspace = workspace;
            Age = age;
        }
    }
}
