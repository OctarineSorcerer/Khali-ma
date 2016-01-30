using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

	public GameObject reagent {
		get {
			if(transform.childCount>0) {
				return transform.GetChild(0).gameObject; }
			else return null;
		}
	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		Debug.Log ("Dropped like you as a child");
		//If we have absolutely nothing, like the peasant students we are
		if (!reagent || reagent == Drag.itemBeingDragged) {
			Drag.itemBeingDragged.transform.SetParent(transform);
			Drag.itemBeingDragged.transform.position = transform.position; //Lock with parent position (woo centering)
			//Drag.itemBeingDragged.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f); //This one was xiao wang, did it perfectly

			if(Drag.draggedReagent != null) {  //A reagent is being dragged onto this circle
				Seal seal = gameObject.GetComponentInParent<Seal>();
				seal.reagents.Add(Drag.draggedReagent);
				Debug.Log ("Added reagent: " + Drag.draggedReagent.Name);
			}
		}
	}

	#endregion

}
