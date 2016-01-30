using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	public static Reagent reagent; //It's almost definitely gonna be a reagent that's being dragged

	Vector3 startPos;
	Transform startParent;


	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		reagent = gameObject.GetComponentInParent<ReagentBox> ().reagent;

		startPos = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup>().blocksRaycasts = false; //Go transparent m'boi
	}
	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
		reagent = null;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
		if (transform.parent == startParent) {
			transform.position = startPos;
		}
	}

	#endregion
}
