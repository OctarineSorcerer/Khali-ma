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
	} //Pfft, really will just be child
    Transform originalParent;

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		//If we have absolutely nothing, like the peasant students we are
		if (!reagent || reagent != null && reagent == Drag.itemBeingDragged) {
            originalParent = Drag.StartParent;

			Drag.itemBeingDragged.transform.SetParent(transform);
			Drag.itemBeingDragged.transform.position = transform.position; //Lock with parent position (woo centering)
			//Drag.itemBeingDragged.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f); //This one was xiao wang, did it perfectly --Before we understood Angelica's UI intentions, that is

			if(Drag.draggedReagent != null) {  //A reagent is being dragged onto this circle
				Seal seal = gameObject.GetComponentInParent<Seal>();
				seal.reagents.Add(Drag.draggedReagent); //Tell the circle you have a new Reagent
				
                Debug.Log ("Added reagent: " + Drag.draggedReagent.Name);
			}
		}
	}

	#endregion

    /// <summary>
    /// 
    /// </summary>
    /// <returns>Original parent transform</returns>
    public Transform SnapBack() //Snaps child element back to where it came from
    {
        Debug.Log(originalParent.name);
        Transform output = originalParent;
        if (reagent != null)
        {
            reagent.transform.SetParent(originalParent);
            reagent.transform.position = originalParent.position;
        }
        return output;
    }

}
