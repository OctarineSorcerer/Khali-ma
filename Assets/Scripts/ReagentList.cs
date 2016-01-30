using UnityEngine;
using System.Collections.Generic;

public class ReagentList {

	public static List<Reagent> reagents = new List<Reagent> (){
		new Reagent("Charcoal", 
		           "Burnt wood... Some say that if you use it to draw a summoning array on someone’s face, you could bring out his true self. So far people who’ve tried this just looked like idiots",
		            Resources.Load<Sprite>("Item_Charcoal"),
		            Resources.Load<Sprite>("Reagent_Charcoal")), 
		new Reagent("Holy Relic",
		            "An ancient relic used in some religion. Someone possibly would kill for it. And you’re about to use it to open a door. You monster.",
		            Resources.Load<Sprite>("Item_Cross"),
		            Resources.Load<Sprite>("Reagent_Cross")), 
		new Reagent("Flask",
		            "'I swear, this is water. I guarantee it!' *hic*",
		            Resources.Load<Sprite>("Item_Flask"),
		            Resources.Load<Sprite>("Reagent_Water")),
        new Reagent("Rocks",
                        "A bunch of rocks. Useful for making tools, and hitting someone in the head. Both are equally funny.",
                        Resources.Load<Sprite>("Item_Rock"),
		            	Resources.Load<Sprite>("Reagent_Rock")),
        new Reagent("Battery",
                        "A very modern invention, harnessing energy in a small, cylindrical container. DO NOT LICK!",
                        Resources.Load<Sprite>("Item_BatteryBox"),
		            	Resources.Load<Sprite>("Reagent_Battery")),
        new Reagent("Dark Beads",
                        "These orbs contain the very essence of darkness and evil, able to corrupt the minds of lesser men. They are totally not marbles that have painted black. Totally evil marbles…",
                        Resources.Load<Sprite>("Item_Marbles"),
		            	Resources.Load<Sprite>("Reagent_Marble")),
        new Reagent("Leaf",
                        "A collection of leafs from a multitude of flowers, carefully assembled using your neighbour’s flowerbed that he treated for years. In case of vegetarians attack, throw them at the vegetarian and run.",
                        Resources.Load<Sprite>("Item_Flower"),
		            	Resources.Load<Sprite>("Reagent_Leaf")),
        new Reagent("Ice", "The holy grail of mankind. Cooling drinks, mitigating pain, making people slip, ice is the solution to all of your problems.",
                        Resources.Load<Sprite>("Item_IceCubeTray"),
		            	Resources.Load<Sprite>("Reagent_Ice"))
    };

	public static List<Reagent> elem = ArrayGenerator.elem;
	
}
