using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ReagentBox : MonoBehaviour {

	public Reagent reagent;

	// Use this for initialization
	void Start () {
		Text panelText = GetComponentInChildren<Text> ();
		panelText.text = reagent.Description;
		
		SetLargeReagentImage();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// For being a big reagent, in a big box. Awwwwwww.
	/// </summary>
	public void SetLargeReagentImage() {
		Transform reagentImage = transform.Find ("Image"); // GetComponentInChildren<Image> ();
		if (reagentImage != null) {
			reagentImage.GetComponent<Image>().sprite = reagent.largeSprite;
		}
	}

	public void SetSmallReagentImage() {
		Transform reagentImage = transform.Find ("Image"); // GetComponentInChildren<Image> ();
		if (reagentImage != null) {
			var image = reagentImage.GetComponent<Image>();
			image.sprite = reagent.smallSprite;
			image.SetNativeSize();
		}
	}

}
