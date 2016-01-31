using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;

public class Seal : MonoBehaviour {

	List<Reagent> reagents = null;
	public List<Reagent> Reagents {
		get {
			if (reagents == null) {
				reagents = GetComponentsInChildren<Slot> ().Select (s => s.reagent).Where (r => r != null).ToList ();
			}
			return reagents;
		}
		set {
			if (reagents == null || value == null) {
				reagents = value;
			}
		}
	}
	
	public void ReleaseReagents()
	{
		foreach (var slot in transform.GetComponentsInChildren<Slot>())
		{
			Debug.Log("Releasing slot");
			slot.SnapBack();
		}
		reagents = null;
	}
}
