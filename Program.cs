class Program
{
    static void Main()
    {
        Console.Write("Masukkan judul video: ");
        string judul = Console.ReadLine();
        SayaTubeVideo video = new SayaTubeVideo(judul);
        Console.Write("Masukkan jumlah penambahan play count: ");
        int count = int.Parse(Console.ReadLine());
        video.IncreasePlayCount(count);
        video.PrintVideoDetails();
    }
}
