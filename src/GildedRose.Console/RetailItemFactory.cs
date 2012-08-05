using System;

namespace GildedRose.Console
{
	public static class RetailItemFactory {
		public static RetailItem Create(Item item) {
			if (ItemMaturesWithTime(item))
				return new MaturingItem(item);
			if (ItemIsScalping(item))
				return new ScalpingItem(item);
			if (ItemDecreasesInQuality(item))
				return new SimpleItem(item);
			return new PristineItem(item);
		}
		
		private static bool ItemDecreasesInQuality(Item item)
		{
			return item.Name != "Sulfuras, Hand of Ragnaros";
		}

		private static bool ItemMaturesWithTime(Item item)
		{
			return item.Name == "Aged Brie";
		}

		private static bool ItemIsScalping(Item item)
		{
			return item.Name.StartsWith("Backstage passes");
		}
	}
}

