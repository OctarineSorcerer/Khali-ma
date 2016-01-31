using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	public static Reagent draggedReagent; //It's almost definitely gonna be a reagent that's being dragged

	Vector3 startPos;
	static Transform startParent;

    public static Transform StartParent
    {
        get { return startParent; }
    }



	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		var reagentBox = gameObject.GetComponentInParent<ReagentBox> ();
		if (reagentBox != null) {
			draggedReagent = reagentBox.reagent;
		}

		startPos = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup>().blocksRaycasts = false; //Go transparent m'boi

		itemBeingDragged = Instantiate (gameObject);
		itemBeingDragged.GetComponent<Image> ().sprite = draggedReagent.largeSprite;
		itemBeingDragged.GetComponent<Image> ().SetNativeSize ();
        itemBeingDragged.transform.SetParent(GameObject.Find("Canvas").transform); //FREEDOM FROM THE MASSSSSK
	}
	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		itemBeingDragged.transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		Destroy (itemBeingDragged);
		itemBeingDragged = null;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
        /*if (transform.parent == GameObject.Find("Canvas").transform)
        {
			transform.position = draggedReagent.reagentPanel.transform.position;
            transform.SetParent(draggedReagent.reagentPanel); //Go back to whence ye came
		}*/
		draggedReagent = null;
	}

	#endregion
}
