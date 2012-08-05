using System;

namespace GildedRose.Console
{
	public class MaturingItem: AbstractRetailItem {
		public MaturingItem(Item item): base(item) {
		}		
		
		protected override void UpdateItemQuality()
		{
			IncreaseQualityIfMaximumQualityIsNotReached();
		}

		protected override void UpdateExpiredItemQuality()
		{
			IncreaseQualityIfMaximumQualityIsNotReached();
		}
	}
	
}

