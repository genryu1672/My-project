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

        //ÚG‚µ‚½uŠÔ‚ÉŒÄ‚Î‚ê‚é
        //Debug.Log("Enter");
    }
    private void OnTriggerStay(Collider other)
    {
        //ÚG‚µ‚Ä‚¢‚éŠÔ‚ÉŒÄ‚Î‚ê‚é
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        //—£‚ê‚½‚ÉŒÄ‚Î‚ê‚é
        Debug.Log("Exit");
    }

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();//Œø‰Ê‰¹
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
