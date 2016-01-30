using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class Reagent : MonoBehaviour {

    public string Name;
    public string Description;
	public Sprite sprite;
    public List<Affinity> Affinities;

	public Reagent(string name, string description, Sprite sprite, List<Affinity> affinities) {
		this.Name = name;
		this.Description = description;
		this.sprite = sprite;
		this.Affinities = affinities
	}

	// Use this for initialization
	void Start () {
		Text panelText = GetComponentInChildren<Text> ();
		panelText.text = Description;

		SetReagentImage ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetReagentImage() {
		Transform reagentImage = transform.Find ("Image"); // GetComponentInChildren<Image> ();
		if (reagentImage != null) {
			reagentImage.GetComponent<Image>().sprite = sprite;
		}
	}
	
}
