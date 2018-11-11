using System;
using FluentAssertions;
using Moq;
using Xunit;

using static Floatingman.nLoDash._;

namespace nLoDash.Test {

    public class UsingTests {

        // this is a pretty simple example ...
        public interface ITestDisposable : IDisposable {
            string Run ();
        }

        [Fact]
        public void Using_abstraction_calls_passed_func () {
            var mDisp = new Mock<ITestDisposable> ();
            mDisp.Setup (d => d.Run ()).Returns ("ran");
            var result = Using (mDisp.Object, (f) => f.Run ());

            mDisp.Verify (d => d.Run (), Times.Once);
            result.Should ().Be ("ran");
        }
    }
}