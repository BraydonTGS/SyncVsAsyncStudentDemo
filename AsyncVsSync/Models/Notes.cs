using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncVsSync.Models
{
// Functions and other operations operate on "threads." A thread is just a string of operations,
// but you can have more than one thread at a time.In some ways the most important thread is the main thread,
// often called the UI thread because this is where the user interface is controlled.

// When performing lengthy operations(such as getting data from the Internet) you do not want to wait for that data on the main thread
//as you will "block" that thread from responding to user input(for example, clicking the cancel button)

// To solve this, you put the long running task on its own thread.C# makes this easy, you just use the await keyword,
//and the function will await completion of the work without blocking the main thread.

// The word await is a "keyword" -- its use is reserved for this purpose.To signal that a function has an await in it,
// you must mark the function with async.If you do mark it async, the compiler will expect at least one await.
}
