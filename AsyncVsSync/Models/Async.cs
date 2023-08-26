namespace AsyncVsSync.Models
{
    // Asynchronous Programming:
    // In asynchronous programming, tasks can be started and allowed to run independently.The program doesn't wait for each task to finish before moving on.
    // It's like ordering food online – you can continue doing other things while waiting for your order to arrive.
    // Well-suited for tasks that involve waiting for external resources(like file I/O, network requests) or parallel processing.

    // Pros of Asynchronous Programming:
    // Improved performance as tasks can run concurrently, utilizing system resources effectively.
    // Better responsiveness in applications, as the program doesn't get blocked by slow operations.
    // Well-suited for scenarios where multiple tasks need to be handled without waiting for each other.

    // Cons of Asynchronous Programming:
    // More complex to understand due to asynchronous callbacks or handling.

    // What is a Task //
    // In C# asynchronous programming, a Task represents a unit of work that can be executed asynchronously.
    // It's like a container for a piece of code that might take some time to complete, allowing your program to continue with other tasks in the meantime.
    // It is a way to manage and control operations that can happen in the background without blocking your program's execution.
    // It enables your program to be more responsive and efficient, especially when dealing with time-consuming or resource-intensive operations.

    // Awaiting a Task: When you want to wait for a task to complete before continuing,
    // you use the await keyword.This tells your program to pause at that point until the task finishes its work.
    // This is how you can seamlessly mix asynchronous and synchronous code.
}
