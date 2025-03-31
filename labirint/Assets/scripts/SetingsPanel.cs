using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetingsPanel : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;

    private bool _isOpen;

    private void Start()
    {
        _isOpen = false;
    }

    private void Update()
    {
        _settingsPanel.SetActive(_isOpen);
    }

    public void ChangeSettingsPanelStatus()
    {
        _isOpen = !_isOpen;
    }



}
