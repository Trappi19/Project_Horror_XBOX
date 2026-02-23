using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuSelector : MonoBehaviour
{
    public Button firstButton;

    void OnEnable()
    {
        SelectFirst();
    }

    void Start()
    {
        SelectFirst();
    }

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            SelectFirst();
        }
    }

    void SelectFirst()
    {
        if (firstButton == null) return;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstButton.gameObject);
    }
}
