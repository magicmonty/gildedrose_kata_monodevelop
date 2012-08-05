using NUnit.Framework;
using GildedRose.Console;

namespace GildedRose.Tests
{
    [TestFixture]
    public class ScalpingItemTests: ItemBehaviorBase
    {
		[Test]
		public void AScalpingItemShouldIncreaseInQuality() {
			SetupItem(TestItems.ScalpingItem);
			Assert.AreEqual(2, _item.Quality);
		}

		[Test]
		public void AScalpingItemShouldNeverIncreaseInQualityBeyondMaximum() {
			Item item = TestItems.ScalpingItem;
			item.Quality = Program.MAX_QUALITY;
			SetupItem(item);
			Assert.AreEqual(Program.MAX_QUALITY, _item.Quality);
		}

		[Test]
		public void AScalpingItemShouldDoubleIncreaseInQualityIfSellInIsLessThan11() {
			Item item = TestItems.ScalpingItem;
			item.SellIn = 10;
			SetupItem(item);
			Assert.AreEqual(3, _item.Quality);
		}

		[Test]
		public void AScalpingItemShouldNotIncreaseInQualityBeyondMaximumIfSellInIsLessThan11() {
			Item item = TestItems.ScalpingItem;
			item.SellIn = 10;
			item.Quality = Program.MAX_QUALITY - 1;
			SetupItem(item);
			Assert.AreEqual(Program.MAX_QUALITY, _item.Quality);
		}

		[Test]
		public void AScalpingItemShouldTripleIncreaseInQualityIfSellInIsLessThan6() {
			Item item = TestItems.ScalpingItem;
			item.SellIn = 5;
			SetupItem(item);
			Assert.AreEqual(4, _item.Quality);
		}
		
		[Test]
		public void AScalpingItemShouldNotIncreaseInQualityBeyondMaximumIfSellInIsLessThan6() {
			Item item = TestItems.ScalpingItem;
			item.SellIn = 5;
			item.Quality = Program.MAX_QUALITY - 1;
			SetupItem(item);
			Assert.AreEqual(Program.MAX_QUALITY, _item.Quality);
		}

		[Test]
		public void AScalpingItemShouldDecreaseSellIn() {
			SetupItem(TestItems.ScalpingItem);
			Assert.AreEqual(19, _item.SellIn);
		}

		[Test]
		public void TheQualityOfAnExpiredScalpingItemShouldDropTo0() {
			Item item = TestItems.ScalpingItem;
			item.SellIn = -1;
			SetupItem(item);
			Assert.AreEqual(0, _item.Quality);
		}
	}
}
