using System;
using Xunit;

using static Floatingman.nLoDash._;

namespace nLoDash.Test {

    public class UsingTests {
        private class TestDisposable : IDisposable {
            public void Dispose () {
                // ...
            }
            public string Run(){
                return "ran";
            }
        }

        [Fact]
        public void Using_abstraction_calls_passed_func () {
            var result = Using (new TestDisposable(),(f) => f.Run());

        }
    }
}