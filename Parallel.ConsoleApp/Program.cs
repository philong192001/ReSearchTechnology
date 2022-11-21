ParallelLoopResult result = Parallel.For(1, 20, RunTask);   // Vòng lặp tạo ra 20 lần chạy RunTask


static void RunTask(int i)
{
    PintInfo($"Start {i,3}");
    Task.Delay(1000).Wait();          // Task dừng 1s - rồi mới chạy tiếp
    PintInfo($"Finish {i,3}");
}


static void PintInfo(string info) =>
          Console.WriteLine($"{info,10}    task:{Task.CurrentId,3}    " +
                            $"thread: {Thread.CurrentThread.ManagedThreadId}");