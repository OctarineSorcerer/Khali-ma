using UnityEngine;
using System.Collections.Generic;
using System;

public class Seal : MonoBehaviour {

	public List<Reagent> reagents = new List<Reagent>();

    public void ReleaseReagents()
    {
        foreach (var slot in transform.GetComponentsInChildren<Slot>())
        {
            Debug.Log("Releasing slot");
            Transform origParent = slot.SnapBack();
            var rBox = origParent.GetComponent<ReagentBox>();
            if (rBox != null)
            {
                rBox.SetLargeReagentImage();
            }
        }
    }
}
