using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockStateHandler : MonoBehaviour
{
    private AlchemyHandler blckAlchHandler;
    public BlockState blckState;
    // Start is called before the first frame update
    void Start()
    {
        blckAlchHandler = GameObject.FindGameObjectWithTag("AlchemyController").GetComponent<AlchemyHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
