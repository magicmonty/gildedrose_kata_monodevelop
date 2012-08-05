using GildedRose.Console;
using System.Collections.Generic;

namespace GildedRose.Tests
{
	public class ItemBehaviorBase
	{
		protected Item _item;
		
		protected void SetupItem(Item item)
		{
			_item = item;
			Program app = new Program() {
				Items = new List<Item> {
					_item,
				}
			};
			app.UpdateQuality();
		}		
	}
	
}
