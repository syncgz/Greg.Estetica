using Greg.Estetica.Core.Interfaces;
using Greg.Estetica.Core.IoC;
using NUnit.Framework;

namespace Greg.Estetica.Core.Test.Unit
{
    [TestFixture]
    public class ContainerTest
    {
        [Test]
        public void ResolveType_ResolveIPromotionRepository_ResultOk()
        {
            var item = Container.ResolveType<IPromotionRepository>();

            Assert.IsNotNull(item);
        }
    }
}
