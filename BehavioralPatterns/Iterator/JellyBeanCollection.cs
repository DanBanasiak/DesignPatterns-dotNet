using System.Collections;

namespace Iterator
{
	/// <summary>
	/// The concrete aggregate class
	/// </summary>
	class JellyBeanCollection : ICandyCollection
	{
		private ArrayList _items = new ArrayList();

		public JellyBeanIterator CreateIterator()
		{
			return new JellyBeanIterator(this);
		}

		// Gets jelly bean count
		public int Count => _items.Count;

		// Indexer
		public object this[int index]
		{
			get => _items[index];
			set => _items.Add(value);
		}
	}
}
