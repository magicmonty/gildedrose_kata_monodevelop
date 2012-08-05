using System;

namespace GildedRose.Console
{
	public class ScalpingItem: AbstractRetailItem {
		public ScalpingItem(Item item): base(item) {
		}		

		protected override void UpdateItemQuality()
		{
			IncreaseQualityIfMaximumQualityIsNotReached();
	
			if (SellIn < 11) {
				IncreaseQualityIfMaximumQualityIsNotReached();
			}

			if (SellIn < 6) {
				IncreaseQualityIfMaximumQualityIsNotReached();
			}
		}

		protected override void UpdateExpiredItemQuality()
		{
			Quality = 0;
		}
	}
	
}

