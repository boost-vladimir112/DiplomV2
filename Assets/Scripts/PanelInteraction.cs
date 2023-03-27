using UnityEngine;

public class PanelInteraction : MonoBehaviour
{
    [SerializeField] private GameObject _infoPanel;
  
    public void OpenInfoPanel()
    {
        _infoPanel.SetActive(true);
    }
    public void CloseInfoPanel()
    { 
        _infoPanel.SetActive(false);
    }
}
