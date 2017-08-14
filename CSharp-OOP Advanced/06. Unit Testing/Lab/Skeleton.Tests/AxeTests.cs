using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
	[TestFixture]
    public class AxeTests
    {

	    private const int AxeAttack = 2;
	    private const int AxeDurability = 2;
	    private const int DummyHealth = 20;
	    private const int DummyXP = 20;
	    private Axe axe;
	    private Dummy dummy;

	    [SetUp]
	    public void TestInit()
	    {
		    this.axe = new Axe(AxeAttack, AxeDurability);
		    this.dummy = new Dummy(DummyHealth, DummyXP);
	    }

		[Test]
	    public void AxeLosesDurabilityAfterAttack()
	    {
			// Act
			axe.Attack(dummy);


			// Assert
			Assert.AreEqual(9, axe.DurabilityPoints);
	    }

	    [Test]
	    public void AttackingWithABrokenWeapon()
	    {
		    // Arrange
			Axe axe = new Axe(1,1);
			Dummy dummy = new Dummy(10,10);

			// Act
			axe.Attack(dummy);

			// Assert
		    var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
			Assert.That(ex.Message, Is.EqualTo("Axe is broken!"));
	    }
    }
	
}
