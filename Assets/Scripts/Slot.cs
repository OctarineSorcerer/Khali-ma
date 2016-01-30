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
		if (!reagent) {
			Drag.itemBeingDragged.transform.SetParent(transform);
		}
	}

	#endregion

}
