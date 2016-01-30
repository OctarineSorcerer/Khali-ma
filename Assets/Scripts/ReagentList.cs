using UnityEngine;
using System.Collections.Generic;

public class ReagentList {

	public static List<Reagent> reagents = new List<Reagent> (){
		new Reagent("Charcoal", 
		           "Burnt wood... Some say that if you use it to draw a summoning array on someone’s face, you could bring out his true self. So far people who’ve tried this just looked like idiots.",
		           Resources.Load<Sprite>("Item_Charcoal")), 
		new Reagent("Holy Relic",
		            "An ancient relic used in some religion. Someone possibly would kill for it. And you’re about to use it to open a door. You monster.",
		            Resources.Load<Sprite>("Item_Cross")), 
		new Reagent("Flask",
		            "'I swear, this is water. I guarantee it!' *hic*",
		            Resources.Load<Sprite>("Item_Flask")),

	};

	public static List<Reagent> elem = ArrayGenerator.elem;
	
}
