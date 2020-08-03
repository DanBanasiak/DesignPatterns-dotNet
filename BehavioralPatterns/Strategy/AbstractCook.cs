namespace Strategy
{
	/// <summary>
	/// The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
	/// </summary>
	abstract class AbstractCook
	{
		public abstract void Cook(string food);
	}
}
