using NUnit.Framework;
using GildedRose.Console;

namespace GildedRose.Tests
{
    [TestFixture]
    public class PristineItemTests: ItemBehaviorBase
    {
		[Test]
		public void APristineItemShouldNotChangeInQuality() {
			SetupItem(TestItems.PristineItem);
			Assert.AreEqual(80, _item.Quality);
		}
		
		[Test]
		public void APristineItemShouldNotChangeSellIn() {
			SetupItem(TestItems.PristineItem);
			Assert.AreEqual(0, _item.SellIn);
		}
		
		[Test]
		public void AnExpiredPristineItemShouldNotChangeQuality() {
			Item item = TestItems.PristineItem;
			item.SellIn = -1;
			SetupItem(item);
			Assert.AreEqual(80, _item.Quality);
		}
	}
}
