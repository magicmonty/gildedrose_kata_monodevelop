using NUnit.Framework;
using GildedRose.Console;

namespace GildedRose.Tests
{
    [TestFixture]
    public class SimpleItemTests: ItemBehaviorBase
    {		
        [Test]
        public void ASimpleItemShouldDecreaseInQuality()
        {
			SetupItem(TestItems.SimpleItem);
            Assert.AreEqual(0, _item.Quality);
        }

		[Test]
        public void ASimpleItemShouldNeverDecreaseInQualityBelow0()
        {
			Item item = TestItems.SimpleItem;
			item.Quality = 0;
			SetupItem(item);
            Assert.AreEqual(0, _item.Quality);
        }
		
        [Test]
        public void ASimpleItemShouldDecreaseSellIn()
        {
			SetupItem(TestItems.SimpleItem);
            Assert.AreEqual(19, _item.SellIn);
        }

        [Test]
        public void ASimpleItemShouldDecreaseSellInFurther()
        {
			Item item = TestItems.SimpleItem;
			item.SellIn = -1;
			
			SetupItem(item);
            Assert.AreEqual(-2, _item.SellIn);
        }
		
        [Test]
        public void AnExpiredSimpleItemShouldDecreaseInQualityTwiceAsFast()
        {
			Item item = TestItems.SimpleItem;
			item.SellIn = -1;
			item.Quality = 10;
			
			SetupItem(item);
            Assert.AreEqual(8, _item.Quality);
        }

		[Test]
        public void AnExpiredSimpleItemShouldNeverDecreaseInQualityBelow0()
        {
			Item item = TestItems.SimpleItem;
			item.SellIn = -1;
			item.Quality = 0;
			
			SetupItem(item);
            Assert.AreEqual(0, _item.Quality);
        }
   }
}