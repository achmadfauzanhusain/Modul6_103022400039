public class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        this.title = title;
        this.playCount = 0;

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
    }

    public void increasePlayCount(int count)
    {
        playCount += count;
    }

    public void printTrackDetails()
    {
        Console.WriteLine("=== Track Details ===");
        Console.WriteLine("ID         : " + id);
        Console.WriteLine("Title      : " + title);
        Console.WriteLine("PlayCount  : " + playCount);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Lagu Favorit");
        track.increasePlayCount(5);
        track.printTrackDetails();
    }
}