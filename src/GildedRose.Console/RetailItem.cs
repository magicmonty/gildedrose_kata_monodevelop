using System;

namespace GildedRose.Console
{
	public interface RetailItem
	{
		string Name { get; set; }
		int SellIn { get; set; }
		int Quality { get; set; }
		
		void Update();
	}
	
	public abstract class AbstractRetailItem: RetailItem
	{
		public static int MAX_QUALITY = 50;
		private Item _item;
		
		public string Name{ 
			get{ return _item.Name; } 
			set { _item.Name = value; }
		}

		public int SellIn{ 
			get{ return _item.SellIn; } 
			set { _item.SellIn = value; }
		}

		public int Quality{ 
			get{ return _item.Quality; } 
			set { _item.Quality = value; }
		}
		
		public AbstractRetailItem(Item item) {
			_item = item;
		}		
		
		public void Update()
		{
			UpdateItemQuality();
			UpdateSellIn();

			if (SellIn >= 0) {
				return;
			}
			UpdateExpiredItemQuality();
		}
		
		protected bool IsMinimumQualityReached() {
			return Quality <= 0;
		}

		protected bool IsMaximumQualityReached() {
			return Quality >= MAX_QUALITY;
		}
		
		protected void DecreaseQualityIfMinimumQualityIsNotReached() {
			if (!IsMinimumQualityReached()) {
				Quality--;
			}
		}

		protected void IncreaseQualityIfMaximumQualityIsNotReached() {
			if (!IsMaximumQualityReached()) {
				Quality++;
			}
		}

		protected abstract void UpdateItemQuality();
		
		protected virtual void UpdateSellIn()
		{
			SellIn--;
		}
		
		protected abstract void UpdateExpiredItemQuality();
	}
}

