
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class EnvoirmentChangeButton : MonoBehaviour
{
    [SerializeField] private EnvoirmentChangeService _changeService;

    [SerializeField] private EnvoirmentState _state;

    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Change);
    }

    private void Change()
    {
        _changeService.Change(_state);
    }
}
