using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    [SerializeField] private Animator animator = null;

    // Slime paramaters
    int ElementType = 0;
    TriggerStateTransition WaterCrevice;
    TriggerStateTransition WindJump;

    // Crate paramter
    TriggerStateTransition Burning;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
