using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	Vector3 startPos;


	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		Debug.Log ("woooo start");
		itemBeingDragged = gameObject;
		startPos = transform.position;
	}
	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		Debug.Log ("woooo mid");
		transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;

	}

	#endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
