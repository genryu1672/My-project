using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pullingjump : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�Փ˂���");
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("�ڐG��");
        isCanJump = true;

        //�Փ˂��Ă���_�̏�񂪕����i�[����Ă���
        ContactPoint[] contacts = collision.contacts;

        //�O�Ԗڂ̏Փˏ�񂩂�A�Փ˂��Ă���_�̖@�����擾
        Vector3 otherNormal = contacts[0].normal;

        //������������x�N�g���B�����͂P
        Vector3 upVector = new Vector3(0, 1, 0);

        //������Ɩ@���̓��ρB��̃x�N�g���͂Ƃ��ɒ������P�Ȃ̂ŁAcos0�̌��ʂ�dotUN�ϐ��ɓ���B
        float dotUN = Vector3.Dot(upVector, otherNormal);

        //���ϒl�ɋt�O�p�֐�arccos���|���Ċp�x���Z�o�B�����x���@�֕ϊ�����B����Ŋp�x���Z�o�ł���
        float dotDeg = Mathf.Acos(dotUN) * Mathf.Rad2Deg;

        //��̃x�N�g�����Ȃ��p�x��45�x��菬������΍ĂуW�����v�\�Ƃ���
        if(dotDeg<=45)
        {
            isCanJump = true;
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("���E����");
        isCanJump = false;
    }


    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //rb=GetComponent<Rigidbody>();//gameObject�͏ȗ��\
    }
    
    
    
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10;

    //�W�����v�s�̔��f
    private bool isCanJump;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (isCanJump&&Input.GetMouseButtonUp(0))
        {
            //�N���b�N�������W�Ɨ��������W�̍������擾
            Vector3 dist = clickPosition - Input.mousePosition;
            //�N���b�N�ƃ����[�X���������W�Ȃ�Ζ���
            if (dist.sqrMagnitude == 0) { return; }
            //������W�������AjumpPower���������킹���l���ړ��ʂƂ���
            rb.velocity = dist.normalized * jumpPower;
        }


       




    //if (Input.GetKeyDown(KeyCode.Space))
    //{
    //    rb.velocity = new Vector3(0, 10, 0);
    //}
}
}
