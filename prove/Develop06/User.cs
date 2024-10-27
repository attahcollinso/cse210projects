Public class User
{
    Private string _name;
    Public int _score;
    Public User(string name, int score)
    {
        _name = name;
        _score = score;
    }

    Public void Save()
    {
        Using (var writer = new StreamWriter(_name + “.txt”))
        {
            Writer.Write(_score);
        }
    }

    Public void LoadFromFile()
    {
        Using (var reader = new StreamReader(_name + “.txt”))
        {
            _score = int.Parse(reader.ReadToEnd());
        }
    }
    Public bool IsNewUser()
    {
        // check if file exists
        Return !File.Exists(_name + “.txt”);
    }
}



