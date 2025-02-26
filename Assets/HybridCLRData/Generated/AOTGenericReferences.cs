using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"System.Core.dll",
		"UnityEngine.CoreModule.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// System.Action<Entry.MyVec3>
	// System.Collections.Generic.ArraySortHelper<Entry.MyVec3>
	// System.Collections.Generic.Comparer<Entry.MyVec3>
	// System.Collections.Generic.ICollection<Entry.MyVec3>
	// System.Collections.Generic.IComparer<Entry.MyVec3>
	// System.Collections.Generic.IEnumerable<Entry.MyVec3>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<Entry.MyVec3>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IList<Entry.MyVec3>
	// System.Collections.Generic.List.Enumerator<Entry.MyVec3>
	// System.Collections.Generic.List<Entry.MyVec3>
	// System.Collections.Generic.ObjectComparer<Entry.MyVec3>
	// System.Collections.ObjectModel.ReadOnlyCollection<Entry.MyVec3>
	// System.Comparison<Entry.MyVec3>
	// System.Func<object,byte>
	// System.Predicate<Entry.MyVec3>
	// }}

	public void RefMethods()
	{
		// object System.Linq.Enumerable.First<object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,bool>)
		// object UnityEngine.GameObject.AddComponent<object>()
	}
}