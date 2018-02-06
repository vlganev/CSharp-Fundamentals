using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroGetExperienceAfterKillingTarget()
    {
        Hero hero = new Hero("Pesho", new Axe(10, 10));
        Dummy dummy = new Dummy(10, 10);

        hero.Attack(dummy);

        Assert.AreEqual(10, hero.Experience, "Hero doesn't get Experience");
    }

    [Test]
    public void MockingTest()
    {
        Mock<IWeapon> weapon = new Mock<IWeapon>();
        weapon.Setup(w => w.Attack(It.IsAny<ITarget>())).Callback(() => weapon.Object.DurabilityPoints = 10);

        Hero hero = new Hero("Gosho", weapon.Object);
    }
}