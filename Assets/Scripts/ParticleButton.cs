using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleButton : MonoBehaviour
{
    public ParticleSystem particleSystem;

    void Start() {
        var button = GetComponent<Button>();
        button.onClick.AddListener(particleSystem.Play);
    }
}
