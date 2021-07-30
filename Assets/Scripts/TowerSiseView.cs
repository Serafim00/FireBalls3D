using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TowerSiseView : MonoBehaviour
{
    [SerializeField] private TMP_Text _siseView;
    [SerializeField] private Tower _tower;

    private void OnEnable()
    { 
        _tower.SiseUpdated += OnSiseUpdated;
    }

    private void OnDisable()
    {
        _tower.SiseUpdated -= OnSiseUpdated;
    }

    private void OnSiseUpdated(int sise)
    {
        _siseView.text = sise.ToString();
    }
}
