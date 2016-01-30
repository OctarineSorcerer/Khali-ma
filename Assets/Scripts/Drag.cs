using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	public static Reagent draggedReagent; //It's almost definitely gonna be a reagent that's being dragged

	Vector3 startPos;
	Transform startParent;


	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		var reagentBox = gameObject.GetComponentInParent<ReagentBox> ();
		if (reagentBox != null) {
			draggedReagent = reagentBox.reagent;
			reagentBox.SetSmallReagentImage ();
		}

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
		draggedReagent = null;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
		if (transform.parent == startParent) {
			transform.position = startPos;
		}
	}

	#endregion
}
