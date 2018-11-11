using Unit = System.ValueTuple;
using System;

namespace Floatingman.nLoDash {

    public static partial class _ {
        public static Unit Unit () => default (Unit);
    }

    public static class ActionExtensions {

        public static Func<Unit> ToFunc (this Action action) => () => { action (); return _.Unit (); };

        public static Func<T, Unit> ToFunc<T> (this Action<T> action) => (t) => { action (t); return _.Unit (); };

        public static Func<T1, T2, Unit> ToFunc<T1, T2> (this Action<T1, T2> action) => (t1, t2) => { action (t1, t2); return _.Unit (); };

        // etc. add new Func overloads as required
    }

}