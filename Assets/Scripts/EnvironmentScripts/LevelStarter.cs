using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public float countdownStartTimer = 1.5f;
    public float countdownNextNumberTimer = 1.0f;
    public float countDownEndTimer = 1.0f;
    public AudioSource readyFX;
    public AudioSource goFX;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(countdownStartTimer);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(countdownNextNumberTimer);
        countDown3.gameObject.SetActive(false);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(countdownNextNumberTimer);
        countDown2.gameObject.SetActive(false);
        countDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(countdownNextNumberTimer);
        countDown1.gameObject.SetActive(false);
        countDownGo.SetActive(true);
        goFX.Play();
        yield return new WaitForSeconds(countDownEndTimer);
        countDownGo.SetActive(false);
        PublicMove.canMove = true;
        
    }

}
