using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, onEnableEvent;
    public float holdTime;
    public UnityEvent triggerEnterEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        OnEnableEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other);
    {
        triggerEnterEvent.Invoke();
    }

}
