﻿using System;

namespace Floatingman.nLoDash
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
    }
}
