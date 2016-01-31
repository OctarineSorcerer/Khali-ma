using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SealChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CheckEqual() {
		List<Reagent> doorReagents = new List<Reagent>(GameObject.Find ("DoorSeal").GetComponent<DoorSeal> ().Reagents);
		List<Reagent> myReagents = new List<Reagent>(GameObject.Find ("Seal").GetComponent<Seal> ().Reagents);

		bool equal = AreSame (myReagents, doorReagents);

		if (equal) {
			GameObject.Find ("TextHolder").GetComponent<TextManager> ().SetText ("They're equal!");
		} else {
			GameObject.Find ("TextHolder").GetComponent<TextManager> ().SetText ("Pfft nope");
		}
	}

	private bool AreSame(List<Reagent> List1, List<Reagent> List2) {
		// If they're not equal in size, then you know they're not equal
		if (List1.Count != List2.Count) {
			return false;
		}

		List<int> matched = new List<int> ();

		foreach (Reagent r in List1) {
			bool match = false;
			for(int i = 0; i < List2.Count; i++) {
				if(!matched.Contains(i) && r == List2[i]) {
					match = true;
					matched.Add(i);
					break;
				}
			}
			if (match == false) return false;
		}
		return true;
	}
}
