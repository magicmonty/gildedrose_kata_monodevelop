using NUnit.Framework;
using GildedRose.Console;

namespace GildedRose.Tests
{
    [TestFixture]
    public class MaturingItemTests: ItemBehaviorBase
    {
		[Test]
		public void AMaturingItemShouldIncreaseInQuality() {
			SetupItem(TestItems.MaturingItem);
			Assert.AreEqual(2, _item.Quality);
		}
		
		[Test]
		public void AMaturingItemShouldNeverIncreaseInQualityBeyondMaximum() {
			Item item = TestItems.MaturingItem;
			item.Quality = AbstractRetailItem.MAX_QUALITY;
			SetupItem(item);
			Assert.AreEqual(AbstractRetailItem.MAX_QUALITY, _item.Quality);
		}
		
		[Test]
		public void AMaturingItemShouldDecreaseSellIn() {
			SetupItem(TestItems.MaturingItem);
			Assert.AreEqual(19, _item.SellIn);
		}
				
		[Test]
		public void AMaturingItemShouldFurtherDecreaseSellIn() {
			Item item = TestItems.MaturingItem;
			item.SellIn = -1;
			SetupItem(item);
			Assert.AreEqual(-2, _item.SellIn);
		}
				
		[Test]
		public void AnExpiredMaturingItemShouldIncreaseInQualityTwiceAsFast() {
			Item item = TestItems.MaturingItem;
			item.SellIn = -1;
			SetupItem(item);
			Assert.AreEqual(3, _item.Quality);
		}
				
		[Test]
		public void AnExpiredMaturingItemShouldNeverIncreaseInQualityBeyondMaximum() {
			Item item = TestItems.MaturingItem;
			item.SellIn = -1;
			item.Quality = AbstractRetailItem.MAX_QUALITY - 1;
			SetupItem(item);
			Assert.AreEqual(AbstractRetailItem.MAX_QUALITY, _item.Quality);
		}
	}
}

