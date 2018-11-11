using Unit = System.ValueTuple;

namespace Floatingman.nLoDash {
    using static _;

    public static partial class _ {
        public static Unit Unit () => default (Unit);
    }

    public static class ActionExtensions {

        public static Func<Unit> ToFunc (this Action action) => () => { action (); return Unit (); }

        public static Func<T, Unit> ToFunc (this Action<T> action) => (t) => { action (t); return Unit (); }

        public static Func<T1,T2, Unit> ToFunc (this Action<T1,T2> action) => (t1,t2) => { action (t1,t2); return Unit (); }

        // etc. add new Func overloads as required
    }

}