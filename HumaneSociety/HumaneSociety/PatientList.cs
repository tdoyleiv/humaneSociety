using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class PatientList
    {
        List<object> patientList = new List<object>();
        public PatientList()
        {

        }
        public void AddPatient(object patient)
        {
            patientList.Add(patient);
        }
        public void DeletePatient(object patient)
        {
            patientList.Remove(patient);
        }
    }
}
