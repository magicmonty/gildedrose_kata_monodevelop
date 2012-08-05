using
	GildedRose.Console;

namespace GildedRose.Tests
{
	public static class TestItems
	{
		public static Item SimpleItem { 
			get { 
				return new Item {
					Name = "Simple Item", 
					SellIn = 20, 
					Quality = 1
				}; 
			} 
		}
		
		public static Item MaturingItem { 
			get { 
				return new Item {
					Name = "Aged Brie", 
					SellIn = 20, 
					Quality = 1
				}; 
			} 
		}
				
		public static Item ScalpingItem { 
			get { 
				return new Item {
					Name = "Backstage passes to a TAFKAL80ETC concert", 
					SellIn = 20, 
					Quality = 1
				}; 
			} 
		}
				
		public static Item PristineItem { 
			get { 
				return new Item {
					Name = "Sulfuras, Hand of Ragnaros", 
					SellIn = 0, 
					Quality = 80
				}; 
			} 
		}
		
	}
	
}
