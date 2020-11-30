using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DemoApp.Includes
{
    public class EmployeeAccess
    {
        private DirectoryInfo infoDirr;
        private string path;

        public EmployeeAccess()
        {
            infoDirr = new DirectoryInfo(@"..\..\");
            path     = infoDirr + "DataBase.txt";
        }

        public string[] GetEmployees()
        {
            List<string> employees = new List<string>();

            using (StreamReader fs = File.OpenText(path))
            {
                string s = "";
                while ((s = fs.ReadLine()) != null)
                {
                    string temp = s.Substring(0, s.IndexOf('|'));

                    if (temp != "*")
                    {
                        employees.Add(s);
                    }
                }
            }

            return employees.ToArray();
        }

        public string[] GetEmployeeFamily(string id)
        {
            List<string> family = new List<string>();

            using (StreamReader fs = File.OpenText(path))
            {
                string s = "";
                while ((s = fs.ReadLine()) != null)
                {
                    if(s[0] == '*')
                    {
                        string temp = s.Substring(2, s.IndexOf('|'));

                        if (temp == id)
                        {
                            family.Add(s);
                        }
                    }
                }
            }

            return family.ToArray();
        }

        public void AddPerson(string employeeInfo)
        {
            using (StreamWriter fs = File.AppendText(path))
            {
                fs.WriteLine(employeeInfo);
            }
        }

        public int FindEmployee(string id)
        {
            int lineNumber = 0;

            using (StreamReader fs = File.OpenText(path))
            {
                string s = "";
                while ((s = fs.ReadLine()) != null)
                {
                    lineNumber++;
                    s = s.Substring(0, s.IndexOf('|'));

                    if (s == id)
                    {
                        Debug.WriteLine("Found employee, " + id + lineNumber.ToString());
                        return lineNumber;
                    }
                }
            }

            return 0;
        }

        public void DeleteEmployee(string id)
        {
            int targetLine = FindEmployee(id);
            int currLine   = 0;
            string s       = "";

            string temp = Path.GetTempFileName();

            if (targetLine != 0)
            {
                using (StreamReader fr = new StreamReader(path))
                {
                    using (StreamWriter fw = new StreamWriter(temp))
                    {
                        while ((s = fr.ReadLine()) != null)
                        {
                            currLine++;

                            if (currLine == targetLine)
                                continue;

                            if (!string.IsNullOrWhiteSpace(s))
                            {
                                fw.WriteLine(s);
                            }
                        }
                    }
                }
                File.Delete(path);
                File.Move(temp, path);
            }
        }

        public void UpdateEmployee(string id, string entry)
        {
            int targetLine = FindEmployee(id);
            int currLine = 0;
            string s = "";

            string temp = Path.GetTempFileName();

            if (targetLine != 0)
            {
                using (StreamReader fr = new StreamReader(path))
                {
                    using (StreamWriter fw = new StreamWriter(temp))
                    {
                        while ((s = fr.ReadLine()) != null)
                        {
                            currLine++;

                            if (currLine == targetLine)
                            {
                                fw.WriteLine(entry);
                            }

                            else if (!string.IsNullOrWhiteSpace(s))
                            {
                                fw.WriteLine(s);
                            }
                        }
                    }
                }
                File.Delete(path);
                File.Move(temp, path);
            }
        }
    }
}
