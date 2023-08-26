namespace AsyncVsSync.Models
{
    public class Sync
    {
        // Synchronous Programming:
        // In synchronous programming, tasks are executed one after the other, blocking the program until each task is completed.
        // It's like standing in line at a store – you wait for the person ahead of you to finish before you can proceed.
        // Well-suited for simple and linear tasks where one task depends on the completion of the previous one.

        // Pros of Synchronous Programming:
        // Easier to understand and debug.
        // Sequential flow can simplify logic in some cases.

        // Cons of Synchronous Programming:
        // Can lead to slower performance, especially when waiting for I/O operations.
        // Inefficient when handling multiple tasks concurrently.
    }
}
