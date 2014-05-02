using System;

public class A
{
	private enum E1 // Doesn't work
	{
	}

	protected enum E2 // Doesn't work
	{
	}

	internal delegate void D1 ();
	// Doesn't work

	private A () // Works
	{
	}

	private int a;
	// Works

	internal int Prop { private get; set; }
	// Works

	private event D1 e;
	// Works

	protected interface I // Doesn't work
	{
	}
}