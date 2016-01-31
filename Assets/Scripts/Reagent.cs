using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class Reagent {

    public string Name;
    public string Description;
	public Sprite smallSprite;
	public Sprite largeSprite;
    public List<Affinity> Affinities;
	public Transform reagentPanel; //xiao wang

	public Reagent(string name, string description, Sprite smallSprite, Sprite largeSprite, List<Affinity> affinities) {
		this.Name = name;
		this.Description = description;
		this.smallSprite = smallSprite;
		this.largeSprite = largeSprite;
		this.Affinities = affinities;
	}

	public Reagent(string name, string description, Sprite largeSprite, Sprite smallSprite) {
		this.Name = name;
		this.Description = description;
		this.smallSprite = smallSprite;
		this.largeSprite = largeSprite;
		this.Affinities = new List<Affinity>();
	}

	public Reagent() {  //Reflection. Every damn time

	}
}
