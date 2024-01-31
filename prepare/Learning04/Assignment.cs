using System;
namespace activityW4
{
    public class Assigments
    {
        protected string _studentName = "";
        private string _topic = "";

        public string GetStudentName()
        {
            return _studentName;
        }
        public void SetStudentName(string studentName)
        {
            _studentName = studentName;
        }

        public string GetTopic()
        {
            return _topic;
        }
        public void SetTopic(string topic)
        {
            _topic = topic;
        }
        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}