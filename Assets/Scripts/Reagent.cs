using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class Reagent {

    public string Name;
    public string Description;
	public Sprite sprite;
    public List<Affinity> Affinities;

	public Reagent(string name, string description, Sprite sprite, List<Affinity> affinities) {
		this.Name = name;
		this.Description = description;
		this.sprite = sprite;
		this.Affinities = affinities;
	}

	public Reagent(string name, string description, Sprite sprite) {
		this.Name = name;
		this.Description = description;
		this.sprite = sprite;
		this.Affinities = new List<Affinity>();
	}

	public Reagent() {  //Reflection. Every damn time

	}
}
