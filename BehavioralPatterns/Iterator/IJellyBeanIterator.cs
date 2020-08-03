namespace Iterator
{
	/// <summary>
	/// The 'Iterator' interface
	/// </summary>
	interface IJellyBeanIterator
	{
		JellyBean First();
		JellyBean Next();
		bool IsDone { get; }
		JellyBean CurrentBean { get; }
	}
}
