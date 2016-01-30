using UnityEngine;
using System.Collections.Generic;

public class ReagentManager : MonoBehaviour {

	List<Reagent> reagents = new List<Reagent>();

	// Use this for initialization
	void Start () {
		reagents = new List<Reagent>() {
			new Reagent("Charcoal", 
			            "Burnt wood... Some say that if you use it to draw a summoning array on someone’s face, you could bring out his true self. So far people who’ve tried this just looked like idiots.",
			            Resources.Load<Sprite>("Item_Charcoal"))
			new Reagent("Holy Relic",
			            "An ancient relic used in some religion. Someone possibly would kill for it. And you’re about to use it to open a door. You monster.",
			            Resources.Load<Sprite>("Item_Cross"))
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
