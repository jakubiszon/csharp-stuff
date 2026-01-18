namespace MyLibrary;

/// <summary>
/// Defines a call to a delegate with specified arguments.
/// The call can be invoked later.
/// </summary>
public class DelegateInvocation
{
	public Delegate Delegate { get; }

	public object?[] Arguments { get; }

	public DelegateInvocation(
		Delegate @delegate,
		params object?[] arguments)
	{
		Delegate = @delegate ?? throw new System.ArgumentNullException(nameof(@delegate));
		Arguments = arguments;
	}

	public object? Invoke()
	{
		return Delegate.DynamicInvoke(Arguments);
	}
}
