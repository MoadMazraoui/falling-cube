using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 0.3f;

    private MeshRenderer meshRenderer;

    private void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        Scroll();
    }

    private void Scroll(){
        Vector2 textureOffset = meshRenderer.sharedMaterial.GetTextureOffset(CommonProperties.MAINTEX);
        textureOffset.y += Time.deltaTime * scrollSpeed;

        meshRenderer.sharedMaterial.SetTextureOffset(CommonProperties.MAINTEX, textureOffset);
    }
}
