using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class MyUIManager : MonoBehaviour
{
    public PlayerData _data;

    [SerializeField] private UnityEngine.UI.Image _healthFill;
    [SerializeField] private TextMeshProUGUI _xpLabel;

    private void OnEnable()
    {
        _data.updated.AddListener(_UpdateDataDisplay);
    }
    // Start is called before the first frame update
    void Start()
    {
        _UpdateDataDisplay();
    }

    private void _UpdateDataDisplay()
    {
        //_healthFill.fillAmount = _data.health;
        //_xpLabel.text = $"XP: {_data.XP}";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
