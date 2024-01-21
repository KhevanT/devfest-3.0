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

    // get alchemy component
    PlayerStateHandler plrStateHandler;
    BlockStateHandler block;
    BlockStateHandler orb;

    // Start is called before the first frame update
    void Start()
    {
        plrStateHandler = gameObject.GetComponent<PlayerStateHandler>();
        /*
         get block and orb and initialize them
         */

        // the actual method
        plrStateHandler.ReactWith(ref block);
        plrStateHandler.InteractWith(ref orb);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
