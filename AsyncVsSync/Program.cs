using System.Diagnostics;

Console.WriteLine("Starting synchronous image download...");
Thread.Sleep(2000);
Stopwatch syncStopwatch = new Stopwatch();
syncStopwatch.Start();
SynchronousImageDownload();
syncStopwatch.Stop();
Console.WriteLine($"Synchronous download took: {syncStopwatch.ElapsedMilliseconds} ms");

Thread.Sleep(2000);

Console.WriteLine("\nStarting asynchronous image download...");
Thread.Sleep(2000);
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

    // Waits for All Tasks To Complete Before Moving on //
    await Task.WhenAll(task1, task2, task3);
}

/// <summary>
/// Downloads an image synchronously using an HttpClient.
/// HttpClient is a class in C# that provides a convenient way to send HTTP requests
/// and receive HTTP responses from a web server.
/// The using statement ensure that the client is property disposed before exiting the scope.
/// </summary>
/// <param name="imageNumber">The number associated with the image being downloaded.</param>
static void DownloadImageSync(int imageNumber)
{
    using HttpClient client = new HttpClient();
    string imageUrl = $"https://archives.bulbagarden.net/media/upload/3/3f/0143Snorlax.png";
    byte[] imageBytes = client.GetByteArrayAsync(imageUrl).Result;
    Console.WriteLine($"Downloaded image {imageNumber} synchronously.");
}

/// <summary>
/// Downloads an image asynchronously using an HttpClient.
/// HttpClient is a class in C# that provides a convenient way to send HTTP requests
/// and receive HTTP responses from a web server.
/// The using statement ensure that the client is property disposed before exiting the scope.
/// </summary>
/// <param name="imageNumber">The number associated with the image being downloaded.</param>
/// <returns>A Task representing the asynchronous operation.</returns>
static async Task DownloadImageAsync(int imageNumber)
{
    using HttpClient client = new HttpClient();
    string imageUrl = $"https://archives.bulbagarden.net/media/upload/3/3f/0143Snorlax.png";
    byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
    Console.WriteLine($"Downloaded image {imageNumber} asynchronously.");
}






