using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateHandler : MonoBehaviour
{
    private AlchemyHandler plrAlchHandler;
    public PlayerState plrState;

    public PlayerState ReactWith(ref BlockStateHandler block)
    {
        plrAlchHandler.ReactPlayerWithBlock(ref this.plrState, ref block.blckState);

        return new PlayerState();
    }

    public PlayerState InteractWith(ref BlockStateHandler orb)
    {
        plrAlchHandler.InteractPlayerWithOrb(ref this.plrState, ref orb.blckState);

        return new PlayerState();
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
