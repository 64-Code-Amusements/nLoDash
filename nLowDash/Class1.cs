using System;

namespace nLowDash
{
    public static partial class _
    {
        public static TResult Using<TDisposable, TResult>(
            TDisposable disposable,
            Func<TDisposable, TResult> function)
        where TDisposable : IDisposable
        {
            using(disposable) return function(disposable);
        }

        using(var stream = File.OpenRead()){
            stream
        }

        Using(File.OpenRead(),f => f.ReadLines())
    }
}
