using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Greg.Estetica.Core.Cache;
using NUnit.Framework;

namespace Greg.Estetica.Core.Test.Unit
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Set_WriteThenRead_ObjectInCache()
        {
            var testObj = new TestClass();

            testObj.Test = 20;

            //GenericConverter.Set(testObj, CacheItemEnum.Promotions);

            var result = Cache.Cache.Get<TestClass>(CacheItemEnum.Promotions);

            Assert.NotNull(result);

            Assert.AreEqual(testObj.Test, result.Test);
        }

        [Test]
        public void Set_WriteThenReadAfter10sec_ObjectNotInCache()
        {
            var testObj = new TestClass();

            testObj.Test = 20;

            Cache.Cache.Set(testObj, CacheItemEnum.Promotions);

            Thread.Sleep(11000);

            var result = Cache.Cache.Get<TestClass>(CacheItemEnum.Promotions);

            Assert.IsNull(result);
        }
    }

    class TestClass
    {
        public int Test = 10;
    }
}
