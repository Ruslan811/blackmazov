using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MovementService))]
public abstract class NPCService : MonoBehaviour
{
    private const string AnimationKey = "IsInteraction";
    [SerializeField] private TextMeshPro _text;
    [SerializeField] private Animator _anim;

    private MovementService _movementService;

    protected virtual string playerMessage { get; }
    protected virtual string nightMessage { get; }

    protected virtual string dayMessage { get; }

    protected virtual string idleMessage { get; }

    protected virtual Transform idlePosition { get; }


    private void Start()
    {
        _movementService = GetComponent<MovementService>();
        _movementService.MoveToPlayer(_anim, AnimationKey);
    }

    public virtual void NightInteraction()
    {
        TextOutput(nightMessage);
    }

    public virtual void DayInteraction()
    {
        TextOutput(dayMessage);
    }

    public virtual void Dialoge()
    {
        _anim.SetInteger(AnimationKey, 2);
    }

    public virtual void IdleInteraction()
    {
        TextOutput(idleMessage);
        _movementService.MoveToIdle(idlePosition, _anim, AnimationKey);
       
    }

    public virtual void PlayerInteraction()
    {
        TextOutput(playerMessage);
       
    }

    private void TextOutput(string message)
    {
        _text.text = message;
    }
}