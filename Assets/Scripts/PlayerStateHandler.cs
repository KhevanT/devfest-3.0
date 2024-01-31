using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStateHandler : MonoBehaviour
{
    private AlchemyHandler plrAlchHandler;
    public PlayerState plrState;

    // Animation Change Calls
    [SerializeField] public Animator playerAnimControl;
    [SerializeField] public Animator crateAnimControl;

    // Place these statements inside the function call where block interaction is happening

    // Convert slime to element version and trigger its idle animation
    /*
    playerAnimControl.SetInteger("ElementType", 0); // default slime mode
    playerAnimControl.SetInteger("ElementType", 1); // fire slime mode
    playerAnimControl.SetInteger("ElementType", 2); // water slime mode
    playerAnimControl.SetInteger("ElementType", 3); // wind slime mode
    */

    // Ask slime to animate its block interaction
    /*
    // Water Crevice
    playerAnimControl.SetBool("WaterCrevice", true); // set true when starting interaction
    playerAnimControl.SetBool("WaterCrevice", false); // set false when interaction is over
    
    // Wind Jump
    playerAnimControl.SetBool("WindJump", true); // set true when starting interaction
    playerAnimControl.SetBool("WindJump", false); // set false when interaction is over

    // Fire Crate Burn
    crateAnimControl.SetBool("Burning", true); // set true when starting interaction, then delete the crate object after
    */


    public PlayerState ReactWith(ref BlockStateHandler block)
    {
        plrAlchHandler.ReactPlayerWithBlock(ref this.plrState, ref block.blckState);

        return this.plrState;
    }

    public PlayerState InteractWith(ref BlockStateHandler orb)
    {
        plrAlchHandler.InteractPlayerWithOrb(ref this.plrState, ref orb.blckState);

        return this.plrState;
    }

    void Start()
    {
        plrState = PlayerState.Slime;
        plrAlchHandler = GameObject.FindGameObjectWithTag("AlchemyController").GetComponent<AlchemyHandler>();
    }

    void Update()
    {

    }
}
