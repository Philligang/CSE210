public class Job {

    private string _company;

    private string _jobTitle;

    private int _startYear;

    private int _endYear;

    public Job(string companyName, string title, int start, int end){
        company = companyName;
        jobTitle = title;
        startYear = start;
        endYear = end;
    }

    public void Display() {
        //Software Engineer (Microsoft) 2019-2022
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}