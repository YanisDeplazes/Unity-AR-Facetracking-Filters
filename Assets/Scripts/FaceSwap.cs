using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceSwap : MonoBehaviour
{
    private ARFaceManager arFaceManager;

    public List<Material> faceMaterials = new List<Material>();

    private int faceMaterialIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        arFaceManager = GetComponent<ARFaceManager>();
    }

    public void SwitchFace()
    {
        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[faceMaterialIndex];
        }

        faceMaterialIndex++;

        if(faceMaterialIndex >= faceMaterials.Count)
        {
            faceMaterialIndex = 0;
        }
    }
}
