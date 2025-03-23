class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Masukkan judul video: ");
            string judul = Console.ReadLine();
            SayaTubeVideo video = new SayaTubeVideo(judul);
            video.PrintVideoDetails();
            Console.Write("\nMasukkan jumlah penambahan play count: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("\nMenguji overflow play count...");
            Random rand = new Random();
            int loopLimit = rand.Next(50, 300);
            for (int i=0; i < loopLimit; i++)
            {
                video.IncreasePlayCount(count);
            }

            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan: " + ex.Message);
        }
    }
}