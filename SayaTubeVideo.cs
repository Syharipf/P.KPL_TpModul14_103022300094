using System;
using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter.");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 10000)
        {
            Console.WriteLine("Error: Jumlah play count harus antara 0 hingga 10 juta.");
            return;
        }

        try
        {
            checked     
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("\n=== Video Details ===");
        Console.WriteLine("Video ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}