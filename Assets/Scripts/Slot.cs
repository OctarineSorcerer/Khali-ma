using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {
	bool droppedInSlot; //xiao wang

	public Reagent reagent = null; //Pfft, really will just be child

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		//Nothing in slot,
		if (reagent == null) {
			 
			//Drag.itemBeingDragged.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f); //This one was xiao wang, did it perfectly --Before we understood Angelica's UI intentions, that is
			if(Drag.draggedReagent != null) {  //A reagent is being dragged onto this circle
				Image image = GetComponent<Image>();

				reagent = Drag.draggedReagent;
				image.sprite = Drag.draggedReagent.smallSprite;
				Color col = image.color;
				col.a = 255;
				image.color = col;
				image.SetNativeSize(); //Works

				Transform parentBox = reagent.reagentPanel;
				Drag.itemBeingDragged.transform.SetParent(parentBox);
				Drag.itemBeingDragged.transform.position = parentBox.position;

                Debug.Log ("Added reagent: " + Drag.draggedReagent.Name);
			}
			droppedInSlot = true;
		}
	}

	#endregion
	
    public void SnapBack() //Snaps child element back to where it came from
    {
		GetComponent<Image> ().sprite = new Sprite ();
		GetComponent<Image> ().color = new Color (1, 1, 1, 0);
		reagent = null;
    }

}
