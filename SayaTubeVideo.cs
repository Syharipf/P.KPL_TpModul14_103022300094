using System;
using System.Diagnostics;

class SayaTubeVideo
{
    private int _id;
    private string _title;
    private int _playCount;

    public SayaTubeVideo(string title)
    {
        // Validasi judul video tidak boleh null/empty dan maksimal 100 karakter
        if (string.IsNullOrEmpty(title) || title.Length > 100)
        {
            throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter.", nameof(title));
        }

        var random = new Random();
        _id = random.Next(10000, 99999);
        _title = title;
        _playCount = 0;
    }

    /// <summary>
    /// Menambah jumlah play count video dengan validasi batas.
    /// </summary>
    /// <param name="count">Jumlah play count yang ingin ditambahkan</param>
    public void IncreasePlayCount(int count)
    {
        // Validasi nilai count harus dalam range 0 sampai 10,000
        if (count < 0 || count > 10000)
        {
            Console.WriteLine("Error: Jumlah play count harus antara 0 hingga 10,000.");
            return;
        }

        try
        {
            checked
            {
                _playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
        }
    }

    /// <summary>
    /// Menampilkan detail video ke console.
    /// </summary>
    public void PrintVideoDetails()
    {
        Console.WriteLine("\n=== Video Details ===");
        Console.WriteLine("Video ID: " + _id);
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Play Count: " + _playCount);
    }
}