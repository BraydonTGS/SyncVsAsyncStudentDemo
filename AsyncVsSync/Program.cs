using System.Diagnostics;

Console.WriteLine("Starting synchronous image download...");
Stopwatch syncStopwatch = new Stopwatch();
syncStopwatch.Start();
SynchronousImageDownload();
syncStopwatch.Stop();
Console.WriteLine($"Synchronous download took: {syncStopwatch.ElapsedMilliseconds} ms");

Thread.Sleep(2000);

Console.WriteLine("\nStarting asynchronous image download...");
Stopwatch asyncStopwatch = new Stopwatch();
asyncStopwatch.Start();
await AsynchronousImageDownload();
asyncStopwatch.Stop();
Console.WriteLine($"Asynchronous download took: {asyncStopwatch.ElapsedMilliseconds} ms");


static void SynchronousImageDownload()
{
    for (int i = 1; i <= 3; i++)
    {
        DownloadImageSync(i);
    }
}

static async Task AsynchronousImageDownload()
{
    Task task1 = DownloadImageAsync(1);
    Task task2 = DownloadImageAsync(2);
    Task task3 = DownloadImageAsync(3);

    await Task.WhenAll(task1, task2, task3);
}

static void DownloadImageSync(int imageNumber)
{
    using (HttpClient client = new HttpClient())
    {
        string imageUrl = $"https://archives.bulbagarden.net/media/upload/3/3f/0143Snorlax.png";
        byte[] imageBytes = client.GetByteArrayAsync(imageUrl).Result;
        Console.WriteLine($"Downloaded image {imageNumber} synchronously.");
    }
}

static async Task DownloadImageAsync(int imageNumber)
{
    using (HttpClient client = new HttpClient())
    {
        string imageUrl = $"https://archives.bulbagarden.net/media/upload/3/3f/0143Snorlax.png";
        byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
        Console.WriteLine($"Downloaded image {imageNumber} asynchronously.");
    }
}






