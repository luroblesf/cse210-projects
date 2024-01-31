using System;
namespace activityW4
{
    public class WritingAssignments : Assigments
    {
        private string _title ="";
        
        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title, string studentName) 
        {
            _title = title;
            _studentName = studentName;
        }

        public string GetWritingInformation()
        {
            return $"{_title} by {_studentName}";
        }
    }
}