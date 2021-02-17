using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour, Interactable
{
    [SerializeField] Light source = null;
    [SerializeField] float targetIntensity = 5f;
    [SerializeField] float offIntensity = 0f;
    [SerializeField] bool isOn = false;

    public void Interact() {
        if(!source) return;

        isOn = !isOn;
        source.intensity = isOn ? targetIntensity : offIntensity;
    }

}
