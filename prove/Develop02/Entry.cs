public class Entry {

    public string _date;

    public string _entry;

    public string _prompt;

    public Entry(string _date, string _entry, string _prompt){
        // date = _date;
        // entry = _entry;
        // prompt = _prompt;
    }


    public void Display() {
        Console.WriteLine($"{_date} ({_entry}) {_prompt}");
    }

}