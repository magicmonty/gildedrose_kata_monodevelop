using System.Collections.Generic;

namespace GildedRose.Console
{
	public class Program
	{
		public IList<Item> Items;
		
		static void Main (string[] args)
		{
			System.Console.WriteLine ("OMGHAI!");

			var app = new Program ()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };

			app.UpdateQuality ();

			System.Console.ReadKey ();

		}
		
		public static int MAX_QUALITY = 50;
        
		bool ItemDecreasesInQuality (Item item)
		{
			return item.Name != "Sulfuras, Hand of Ragnaros";
		}

		bool ItemMaturesWithTime (Item item)
		{
			return item.Name == "Aged Brie";
		}

		bool ItemIsScalping (Item item)
		{
			return item.Name == "Backstage passes to a TAFKAL80ETC concert";
		}
		
		public void UpdateQuality ()
		{
			foreach (Item item in Items) {
				UpdateItemQuality (item);
				UpdateSellIn(item);

				if (item.SellIn >= 0) {
					continue;
				}
				
				UpdateExpiredItemQuality(item);
			}
		}

		void UpdateItemQuality (Item item)
		{
			if (ItemMaturesWithTime (item) || ItemIsScalping (item)) {
				if (item.Quality < MAX_QUALITY) {
					item.Quality = item.Quality + 1;
        	
					if (ItemIsScalping (item)) {
						if (item.SellIn < 11) {
							if (item.Quality < MAX_QUALITY) {
								item.Quality = item.Quality + 1;
							}
						}
        	
						if (item.SellIn < 6) {
							if (item.Quality < MAX_QUALITY) {
								item.Quality = item.Quality + 1;
							}
						}
					}
				}
			} else {
				if (item.Quality > 0) {
					if (ItemDecreasesInQuality (item)) {
						item.Quality = item.Quality - 1;
					}
				}
			}
		}

		void UpdateSellIn(Item item)
		{
			if (ItemDecreasesInQuality (item)) {
				item.SellIn = item.SellIn - 1;
			}
		}

		void UpdateExpiredItemQuality(Item item)
		{
			if (ItemMaturesWithTime (item)) {
				if (item.Quality < MAX_QUALITY) {
					item.Quality = item.Quality + 1;
				}
			} else {
				if (ItemIsScalping (item)) {
					item.Quality = item.Quality - item.Quality;
				} else {
					if (item.Quality > 0) {
						if (ItemDecreasesInQuality (item)) {
							item.Quality = item.Quality - 1;
						}
					}
				}
			}
		}
	}
}