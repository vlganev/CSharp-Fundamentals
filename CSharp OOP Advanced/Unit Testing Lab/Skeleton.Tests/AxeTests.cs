using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private const int AxeAttack = 1;
    private const int AxeDurability = 1;
    private const int DummyHealth = 20;
    private const int DummyXp = 1;

    private Axe axe;
    private Dummy dummy;
    [SetUp]
    public void TestInit()
    {
        // Arange
        this.axe = new Axe(AxeAttack, AxeDurability);
        this.dummy = new Dummy(DummyHealth, DummyXp);
    }
        
    [Test]
    public void AxeLosesDurabilityAttack()
    {

        // Act
        this.axe.Attack(dummy);

        // Assert
        Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
    }

    [Test]
    public void AttackWithBrokenAxe()
    {
        // Arange
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(20, 20);

        // Act
        axe.Attack(dummy);

        // Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
    }
}