public class User
{
    private string _name;
    public int _score;
    public User(string name, int score)
    {
        _name = name;
        _score = score;
    }

    public void Save()
    {
        using (var writer = new StreamWriter(_name + ".txt"))
        {
            writer.Write(_score);
        }
    }

    public void LoadFromFile()
    {
        using (var reader = new StreamReader(_name + ".txt"))
        {
            _score = int.Parse(reader.ReadToEnd());
        }
    }
    public bool IsNewUser()
    {
        // check if file exists
        return !File.Exists(_name + ".txt");
    }
}