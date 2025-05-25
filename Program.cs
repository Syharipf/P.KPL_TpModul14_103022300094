class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Masukkan judul video: ");
            string title = Console.ReadLine();

            var video = new SayaTubeVideo(title);
            video.PrintVideoDetails();

            Console.Write("\nMasukkan jumlah penambahan play count: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMenguji overflow play count...");
            var random = new Random();
            int loopLimit = random.Next(50, 300);

            for (int i = 0; i < loopLimit; i++)
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