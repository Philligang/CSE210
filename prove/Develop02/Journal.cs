public class Journal {

    public List<Entry> _entrys= new List<Entry>();

    public void Display() {
        foreach (Entry E in _entrys) {
            E.Display();
        }
    }
}