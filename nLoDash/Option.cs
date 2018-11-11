using System;

namespace Floatingman.nLoDash {

    public static partial class _ {

        public static Option.None None => Option.None.Default;

        public static Option<T> Some<T> (T value) => new Option.Some<T> (value);
    }

    public struct Option<T> {
        readonly bool _isSome;
        readonly T _value;

        private Option (T value) {
            _isSome = true;
            _value = value;
        }

        public static implicit operator Option<T> (Option.None _) => new Option<T> ();

        public static implicit operator Option<T> (Option.Some<T> some) => new Option<T> (some.Value);

        public static implicit operator Option<T> (T value) => value == null ? _.None : _.Some (value);

        public TResult Match<TResult> (Func<TResult> none, Func<T, TResult> some) => _isSome ? some (_value) : none ();
    }

    namespace Option {

        public struct None {
            internal static readonly None Default = new None ();
        }

        public struct Some<T> {
            internal T Value { get; }

            internal Some (T value) {
                if (value == null) throw new ArgumentNullException ();
                Value = value;
            }
        }

    }
}