using UnityEngine;
using UnityEngine.EventSystems;

public class UISelectionDebugger : MonoBehaviour
{
    void Update()
    {
        if (EventSystem.current == null) return;

        if (EventSystem.current.currentSelectedGameObject != null)
        {
            Debug.Log("SELECTED: " + EventSystem.current.currentSelectedGameObject.name);
        }
        else
        {
            Debug.Log("RIEN DE SELECTIONNE");
        }
    }
}
