using UnityEngine;
using System.Collections.Generic;
using System;

public class Seal : MonoBehaviour {

	public List<Reagent> reagents = new List<Reagent>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CalculateTotalAffinity() {
		Dictionary<Affinity.ElementName, int> affinities = new Dictionary<Affinity.ElementName, int> ();

		foreach (var ele in (Affinity.ElementName[])Enum.GetValues(typeof(Affinity.ElementName))) {
			affinities.Add(ele, 0); //Add all elements with default 0, may not need this later
		}

		foreach (Reagent reagent in reagents) {
			foreach(Affinity aff in reagent.Affinities) {
				affinities[aff.element] += aff.amount;
			}
		}

		foreach (KeyValuePair<Affinity.ElementName, int> kv in affinities) {
			Debug.Log("Element: " + kv.Key.ToString() + " | Total Affinity: " + kv.Value);
		}
	}
}
