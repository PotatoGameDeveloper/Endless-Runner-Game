using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject mainCamera;
    public GameObject levelControl;
    void OnTriggerEnter(Collider other)
    {
        SphereCollider sphereCollider = this.gameObject.GetComponent<SphereCollider>();
        if (sphereCollider != null)
        {
            sphereCollider.enabled = false;
        }

        CapsuleCollider capsuleCollider = this.gameObject.GetComponent<CapsuleCollider>();
        if (capsuleCollider != null)
        {
            capsuleCollider.enabled = false;
        }

        BoxCollider boxCollider = this.gameObject.GetComponent<BoxCollider>();
        if (boxCollider != null)
        {
            boxCollider.enabled = false;
        }

        thePlayer.GetComponent<PublicMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play();
        mainCamera.GetComponent<Animator>().Play("CameraShake");
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }

}
