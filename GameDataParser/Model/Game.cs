namespace GameDataParser.Model
{
    public class Game
    {
        public string Title { get; init;}
        public int ReleaseYear { get; init;}
        public decimal Rating { get; init;}

        public Game(string title, int releaseYear, decimal rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        public override string ToString()
        {
            string gameStr = $"{Title}, released in {ReleaseYear}, rating: {Rating}";
            return gameStr;
        }
    }
}
