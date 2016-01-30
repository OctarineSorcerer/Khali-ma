using UnityEngine;
using System.Collections.Generic;
using System;

public class ArrayGenerator : MonoBehaviour {

	//Important lists
	static List<Reagent> reagents = ReagentList.reagents;
	public static List<Reagent> elem = new List<Reagent>();

	// Use this for initialization
	void Start () {
		SelectElem (2);
	}
	
	// Update is called once per frame
	void Update () {

	}
	//generate the list of elements for the door array
	public void SelectElem(int n) {
		int len = reagents.Count;
		int index = 0;

		//generate first element-
		elem.Add(reagents[UnityEngine.Random.Range(0, len)]);
		int reagentIndex = 1;
		bool contradiction = false;

		//iterating to generate the rest of the items
		while (reagentIndex < n - 1)
		{
			//select the location of the new reagent
			index = UnityEngine.Random.Range(0, len);
			//test this choice against all existing...
			for (int elemIndex = 0; elemIndex < elem.Count; elemIndex++)
			{
				//test the chosen reagent against the current existing element
				if (reagents[index].Name == "Holy" && elem[elemIndex].Name == "Darkness"
				    || reagents[index].Name == "Darkness" && elem[elemIndex].Name == "Holy") 
				{
					//if a contradiction exist it flags this and breaks the loop
					contradiction = true;
					break;
				}
			}
			//adds the element if no Dark/light contraction is found
			if (contradiction == false) 
			{
				elem.Add(reagents[index]);
				reagentIndex++
			}
		
		}

}

