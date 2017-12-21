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
            try
            {
                patientList.Add(patient);
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
        public void DeletePatient(object patient)
        {
            try
            {
                patientList.Remove(patient);
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("{0} occurred, invalid input.", e));
            }
        }
    }
}
