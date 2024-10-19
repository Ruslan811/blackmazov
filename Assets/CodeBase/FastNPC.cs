using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastNPC : NPCService
{
    [SerializeField] private string _playerMessage;

    protected override string playerMessage => _playerMessage;



}
