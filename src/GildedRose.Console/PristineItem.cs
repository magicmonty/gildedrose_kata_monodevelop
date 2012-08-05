using System;

namespace GildedRose.Console
{
	public class PristineItem: AbstractRetailItem {
		public PristineItem(Item item): base(item) {
		}		
		
		protected override void UpdateItemQuality()
		{
			// Pristine items don't change in quality
		}

		protected override void UpdateSellIn()
		{
			// Pristine items can't be sold
		}

		protected override void UpdateExpiredItemQuality()
		{
			// Pristine items don't change in quality
		}
	}
	
}

