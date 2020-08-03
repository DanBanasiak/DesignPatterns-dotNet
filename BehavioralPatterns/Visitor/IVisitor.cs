namespace Visitor
{
	/// <summary>
	/// The Visitor interface, which declares a Visit operation for each Concrete Visitor to implement.
	/// </summary>
	interface IVisitor
	{
		void Visit(Element element);
	}
}
