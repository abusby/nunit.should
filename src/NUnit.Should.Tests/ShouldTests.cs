﻿using System.Collections.Generic;
using NUnit.Framework;
using System;
namespace NUnit.Should.Tests
{
	[TestFixture]
	public class ShouldTests
	{
		[Test]
		public void ShouldContainTest()
		{
			IList<string> strings = new List<string> {"test"};
			strings.ShouldContain("test");
		}

		[Test]
		public void ShouldNotContainTest()
		{
			IList<string> strings = new List<string> {"test"};
			strings.ShouldNotContain("test2");
		}

		[Test]
		public void ShouldBeTest()
		{
			true.ShouldBe(true);
		}

		[Test]
		public void ShouldBeTrueTest()
		{
			true.ShouldBeTrue();
		}

		[Test]
		public void ShouldBeFalseTest()
		{
			false.ShouldBeFalse();
		}

		[Test]
		public void ShouldNotBeNullTest()
		{
			new object().ShouldNotBeNull();
		}

		[Test]
		public void ShouldBeNullTest()
		{
			object bacon = null;
			bacon.ShouldBeNull();
		}

        [Test]
        public void ShouldThrowTest()
        {
            Action action = () => ExceptionThrower();
            action.ShouldThrow<NotImplementedException>();
        }

        private void ExceptionThrower()
        {
            throw new NotImplementedException();
        }
	}
}
