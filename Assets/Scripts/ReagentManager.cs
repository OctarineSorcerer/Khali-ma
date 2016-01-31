using UnityEngine;
using System.Collections.Generic;

public class ReagentManager : MonoBehaviour {

	public Transform prefab;
	List<Reagent> reagents = new List<Reagent>();

	// Use this for initialization
	void Start () {
		reagents = ReagentList.reagents;

		GameObject panel = GameObject.Find("Reagents");
		foreach(Reagent reagent in reagents) {
			Transform reagentPanel = Instantiate(prefab);
			reagent.reagentPanel = reagentPanel; //xiao wang

			ReagentBox rScript = reagentPanel.GetComponent<ReagentBox>();
			rScript.reagent = reagent;
			rScript.SetLargeReagentImage();

			reagentPanel.transform.SetParent(panel.transform, false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
