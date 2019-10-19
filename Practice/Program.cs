using System;

namespace Practice
{

    /// <summary>
    /// Model Class for patient entry
    /// </summary>
    public class PatientEntry
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }


    /// <summary>
    /// Interface for crud operations
    /// </summary>
    public interface ICrud
    {
        /// <summary>
        /// Add new entry of patient in database2
        /// </summary>
        /// <param name="patient">Patient to add</param>
        /// <returns></returns>
        bool AddPatient(PatientEntry patient);

        /// <summary>
        /// Remove the given patient from database2
        /// </summary>
        /// <param name="patient">Patient to remove</param>
        /// <param name="id"> this is stupid default value</param>
        /// <returns></returns>
        bool RemovePatient(PatientEntry patient, int id = 0);

        /// <summary>
        /// Get patient with id
        /// </summary>
        /// <param name="id">Patient id to get</param>
        /// <returns></returns>
        PatientEntry GetPatient(int id);

    }

    public class Firebasedatabase2ForPatient : ICrud
    {

        public bool AddPatient(PatientEntry patient)
        {
            Console.WriteLine($"{patient.Name} with {patient.ID} is added in database2 using firebase");
            return true;
        }

        public PatientEntry GetPatient(int id)
        {
            PatientEntry patient = new PatientEntry() { ID = id, Name = "NewPatientWithID" };
            return patient;
        }

        public bool RemovePatient(PatientEntry patient, int id)
        {
            Console.WriteLine($"{patient.Name} with {patient.ID} is removed in database2 using firebase");
            return true;
        }
    }



    public class Awsdatabase2ForPatient : ICrud
    {

        public bool AddPatient(PatientEntry patient)
        {
            Console.WriteLine($"{patient.Name} with {patient.ID} is added in database2 using AWS");
            return true;
        }

        public PatientEntry GetPatient(int id)
        {
            PatientEntry patient = new PatientEntry() { ID = id, Name = "NewPatientWithID" };
            return patient;
        }

        public bool RemovePatient(PatientEntry patient, int id)
        {
            Console.WriteLine($"{patient.Name} with {patient.ID} is removed in database2 using AWS");
            return true;
        }
    }

    class Program
    {
        static ICrud database2;
        static void Main(string[] args, ICrud crud)
        {
            Console.WriteLine("Hello World!");
            database2 = crud;
            database2.AddPatient(new PatientEntry() { ID=0, Name="NewPatient" });
            database2.RemovePatient(new PatientEntry() { ID = 0, Name = "NewPatient" });
            PatientEntry patient =  database2.GetPatient(0);

        }
    }

    class Program2
    {
        static ICrud database2;
        static void Main(string[] args, ICrud crud)
        {
            Console.WriteLine("Hello World!");
            database2 = crud;
            database2.AddPatient(new PatientEntry() { ID = 0, Name = "NewPatient" });
            database2.RemovePatient(new PatientEntry() { ID = 0, Name = "NewPatient" });
            PatientEntry patient = database2.GetPatient(0);

        }
    }

    
}
