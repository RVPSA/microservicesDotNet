using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public class StudentModel
    {
        private string name;
        private string gurdian;
        private DateTime admissionDate;
        private int classId;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Gurdian
        {
            get { return gurdian; }
            set { gurdian = value; }
        }

        public DateTime AdmissionDate
        {
            get { return admissionDate; }
            set { admissionDate = value; }
        }

        public int ClassId {
            get { return classId; }
            set { classId = value; }
        }
    }
}
