using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class Reagent : MonoBehaviour {

    public string Name;
    public string Description;
    public List<Affinity> Affinities;

	// Use this for initialization
	void Start () {
		Text panelText = GetComponentInChildren<Text> ();
		panelText.text = Description;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
