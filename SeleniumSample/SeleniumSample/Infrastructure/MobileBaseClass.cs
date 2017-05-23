using NUnit.Framework;

namespace SeleniumSample.Infrastructure
{
    public abstract class MobileBaseClass : BaseClass
    {
        [SetUp]
        public override void SetUp()
        {
            this.driver = DriverFactory.GetInstance(true);
        }
    }
}
