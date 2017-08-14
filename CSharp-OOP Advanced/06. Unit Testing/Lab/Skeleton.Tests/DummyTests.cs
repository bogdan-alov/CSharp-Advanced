using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
	[TestFixture]
	public class DummyTests
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
		public void DummyLoosesHealthWhenAttacked()
		{
			// Arrange
			Axe axe = new Axe(5, 10);
			Dummy dummy = new Dummy(10, 10);

			// Act
			axe.Attack(dummy);

			// Assert
			Assert.AreEqual(5, dummy.Health);
		}

		[Test]
		public void AttackingDeadDummy()
		{
			// Arrange 
			Axe axe = new Axe(5, 10);
			Dummy dummy = new Dummy(5, 10);

			// Act

			axe.Attack(dummy);

			// Assert
			var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
			Assert.AreEqual(ex.Message, "Dummy is dead.");
		}

		[Test]
		public void DeadDummyGivesXP()
		{
			// Arrange 
			Axe axe = new Axe(5,10);
			Dummy dummy = new Dummy(5, 10);

			// Act

			axe.Attack(dummy);

			// Assert 

			Assert.AreEqual(10, dummy.GiveExperience());
		}

		[Test]
		public void AliveDummyCantGiveXP()
		{
			// Act 

			axe.Attack(dummy);

			// Assert
			var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
			Assert.AreEqual(ex.Message, "Target is not dead.");
		}
	}
}
