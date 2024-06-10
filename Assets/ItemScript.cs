using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        DestroySelf();
        //�ڐG�����u�ԂɌĂ΂��
        //Debug.Log("Enter");
    }
    private void OnTriggerStay(Collider other)
    {
        //�ڐG���Ă���ԂɌĂ΂��
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        //���ꂽ���ɌĂ΂��
        Debug.Log("Exit");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
