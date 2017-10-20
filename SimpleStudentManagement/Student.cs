using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudentManagement
{
    class Student
    {
        public string vorname { get; set; }
        public string nachname { get; set; }
        public int alter { get; set; }
        public string studiengang { get; set; }
        public bool beitragBezahlt { get; set; }

        public Student()
        {

        }

        public Student(string _vorname, string _nachname, int _alter, string _studiengang, bool _beitragBezahlt)
        {
            this.vorname = _vorname;
            this.nachname = _nachname;
            this.alter = _alter;
            this.studiengang = _studiengang;
            this.beitragBezahlt = _beitragBezahlt;
        }
    }
}
