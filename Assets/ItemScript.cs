using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private AudioSource audioSource;


    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        //DestroySelf();

        animator.SetTrigger("Get");
        audioSource.Play();

        //接触した瞬間に呼ばれる
        //Debug.Log("Enter");
    }
    private void OnTriggerStay(Collider other)
    {
        //接触している間に呼ばれる
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        //離れた時に呼ばれる
        Debug.Log("Exit");
    }

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();//効果音
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
