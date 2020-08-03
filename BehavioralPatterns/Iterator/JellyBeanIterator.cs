namespace Iterator
{
	/// <summary>
	/// The 'ConcreteIterator' class
	/// </summary>
	class JellyBeanIterator : IJellyBeanIterator
	{
		private JellyBeanCollection _jellyBeans;
		private int _current = 0;
		private int _step = 1;

		// Constructor
		public JellyBeanIterator(JellyBeanCollection beans)
		{
			_jellyBeans = beans;
		}

		// Gets first jelly bean
		public JellyBean First()
		{
			_current = 0;
			return _jellyBeans[_current] as JellyBean;
		}

		// Gets next jelly bean
		public JellyBean Next()
		{
			_current += _step;
			if (!IsDone)
				return _jellyBeans[_current] as JellyBean;
			else
				return null;
		}

		public JellyBean CurrentBean => _jellyBeans[_current] as JellyBean;
		public bool IsDone => _current >= _jellyBeans.Count;
	}
}
