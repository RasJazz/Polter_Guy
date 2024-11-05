using UnityEngine;
using UnityEngine.Serialization;

public class InteractionPromptUI : MonoBehaviour
{
    private Camera _mainCam;
    [SerializeField] private GameObject _uiPanel;
    private void Start()
    {
        _mainCam = Camera.main;
        _uiPanel.SetActive(false);
    }

    public bool isDisplayed;

    public void SetUp()
    {
        // Setting Interaction Button UI to display
        _uiPanel.SetActive(true);
        isDisplayed = true;
    }

    public void Close()
    {
        // Close Interaction Button UI
        _uiPanel.SetActive(false);
        isDisplayed = false;
    }
}
