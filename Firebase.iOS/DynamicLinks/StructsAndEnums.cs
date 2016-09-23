using System;
using ObjCRuntime;

namespace Firebase.iOS
{
	[Native]
	public enum FIRDynamicLinkMatchConfidence : ulong
	{
		Weak,
		Strong
	}
}
