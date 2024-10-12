using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();
        Video video4 = new Video();
        
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);
        int i = 1;
        foreach (Video _video in _videos)
        {
            Random rnd = new Random();
            _video._author = "Attaco";
            _video._title = $"Assurance track {i}";
            _video._lenght = rnd.Next(30,300);
            i++;
            for (int j = 0; j < 4; j++)
            {
                Comment comment = new Comment();
                comment._userName = "Collins";
                comment._text = $"Comment number {j} for track {i-1} video";
                _video.AddComment(comment);
            }
        }

        foreach (Video _video in _videos)
        {
            _video.DisplayAll();
        }
    }
}