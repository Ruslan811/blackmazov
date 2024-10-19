using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunicationZone : MonoBehaviour
{
    [SerializeField] private NPCService _npc;
    [SerializeField] private RollbackButton _button;
    [SerializeField] private Transform _spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        {
            _npc.PlayerInteraction();
            RollbackButton button = Instantiate(_button, _spawnPoint.position, Quaternion.identity, _spawnPoint.parent);
            button.Construct(_npc);
        }
    }
}
