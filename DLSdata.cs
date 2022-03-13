using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using static DLS.CONSTANTS;
using System.Xml.Serialization;
using System.Xml;

namespace DLS
{
    internal static class GenericXmlSerializer
    {
        public static void WriteObject<T>(T outputObject, string outputFile)
        {
            using (FileStream writer = new FileStream(outputFile, FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, outputObject);
            }
        }

        public static T ReadObject<T>(string objectData)
        {
            T deserializedObject = default(T);

            using (FileStream reader = new FileStream(objectData, FileMode.OpenOrCreate))
            {
                XmlTextReader xmlReader = new XmlTextReader(reader);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                deserializedObject = (T)ser.Deserialize(xmlReader);
                xmlReader.Close();
            }

            return deserializedObject;
        }
    }

    public static class DataTransferObject 
    {
        public static Method method;
        public static Course course;
        public static string str;
    }

    static class CONSTANTS
    {
        public const string ERROR_IMAGE = "images/error.png";
        public const string BASIC_STR = "NONE";
        public const double RECOMMENDED_TIME = 600;
    }
    
    [Serializable]
    public class DLSdata
    {
        public Person User;
        public List<Course> Course_List = new List<Course> { };
        public List<student> Student_List = new List<student> { };
        public List<teacher> Teacher_List = new List<teacher> { };

        public Course Find_Course(string title)
        {
            foreach (Course cs in Course_List)
                if (cs.title == title)
                    return cs;
            return null;
        }

        public int Find_Course_ind(string title)
        {
            int i = 0;
            foreach (Course cs in Course_List)
            {
                if (cs.title == title)
                    return i;
                i++;
            }
 
            return -1;
        }

        public Person Find_Person(string login, string password)
        {
            foreach (student st in Student_List)
                if (st.login == login && st.password == password)
                    return (st);

            foreach (teacher tc in Teacher_List)
                if (tc.login == login && tc.password == password)
                    return (tc);

            return null;
        }

        public Person Find_Person(string name)
        {
            foreach (student st in Student_List)
                if (st.name == name)
                    return (st);

            foreach (teacher tc in Teacher_List)
                if (tc.name == name)
                    return (tc);

            return null;
        }
       
        public DLSdata()
        {           
        }
    }
}
