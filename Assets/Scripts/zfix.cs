using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class zfix : CinemachineExtension
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public GameObject Player;

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam,CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            if(pos.z > 0)
            {
                pos.z = -pos.z;
            }
            if(pos.z < 1 && pos.z > -1)
            {
                pos.z = -1;
            }
            state.RawPosition = pos;
        }
    }
    
    
}
