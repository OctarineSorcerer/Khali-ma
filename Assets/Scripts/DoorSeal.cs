using UnityEngine;
using System.Collections;

public class DoorSeal : Seal {

	// Use this for initialization
	void Start () {
		ArrayGenerator.SelectElem(7);
		GetComponent<Seal> ().Reagents = ArrayGenerator.elem;
		
		foreach (Reagent r in GetComponent<Seal> ().Reagents) {
			Debug.Log("DOOR Reagent: " + r.Name);
		}
		Debug.Log ("WE HAVE " + ArrayGenerator.elem.Count + " reagents");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
