using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RollbackButton : MonoBehaviour
{
    private Button _button;
    private NPCService _npcService;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(RollBack);
    }

    private void RollBack()
    {
        _npcService.IdleInteraction();
    }

    public void Construct(NPCService service)
    {
        _npcService = service;
    }
}
