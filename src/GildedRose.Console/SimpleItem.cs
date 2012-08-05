using System;

namespace GildedRose.Console
{
	public class SimpleItem: AbstractRetailItem {
		public SimpleItem(Item item): base(item) {
		}		
		
		protected override void UpdateItemQuality()
		{
			DecreaseQualityIfMinimumQualityIsNotReached();
		}

		protected override void UpdateExpiredItemQuality()
		{
			DecreaseQualityIfMinimumQualityIsNotReached();
		}
	}	
}

