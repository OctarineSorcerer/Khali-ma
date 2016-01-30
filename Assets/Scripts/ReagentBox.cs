using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ReagentBox : MonoBehaviour {

	public Reagent reagent;

	// Use this for initialization
	void Start () {
		Text panelText = GetComponentInChildren<Text> ();
		panelText.text = reagent.Description;
		
		SetReagentImage();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetReagentImage() {
		Transform reagentImage = transform.Find ("Image"); // GetComponentInChildren<Image> ();
		if (reagentImage != null) {
			reagentImage.GetComponent<Image>().sprite = reagent.sprite;
		}
	}

}
