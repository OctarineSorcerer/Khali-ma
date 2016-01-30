using UnityEngine;
using System.Collections;

public class NavigateToScene : MonoBehaviour
{

    public void Navigate(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

	public void Exit()
	{
		Application.Quit();
	}
}
