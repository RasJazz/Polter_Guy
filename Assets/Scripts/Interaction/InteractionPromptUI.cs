using UnityEngine;

public class InteractionPromptUI : MonoBehaviour
{
    private Camera _mainCam;
    [SerializeField] private GameObject _uiPanel;
    private void Start()
    {
        _mainCam = Camera.main;
        _uiPanel.SetActive(false);
    }

    public bool IsDisplayed = false;

    public void SetUp()
    {
        _uiPanel.SetActive(true);
        IsDisplayed = true;
    }

    public void Close()
    {
        _uiPanel.SetActive(false);
        IsDisplayed = false;
    }
}
