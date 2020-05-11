using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissoveTriggerScript : MonoBehaviour
{
    public SkinnedMeshRenderer skinMeshRenderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            skinMeshRenderer.material.SetFloat("Vector1_3C12C0AC", Time.time);
        }
    }





}
