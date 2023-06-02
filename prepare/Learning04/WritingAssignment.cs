class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{base.GetStudentName()} - {base.GetTopic()}\n{_title}";
    }
}