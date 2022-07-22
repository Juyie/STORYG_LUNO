using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RopeInteraction : MonoBehaviour
{
    public GameObject bubble;   //EŰ�� �����ϴ� UI
    public GameObject rope;
    public GameObject ropeFinish;
    public bool ropeSwitch = false;

    void Update()
    {
        if (ropeSwitch == true && Input.GetKeyDown(KeyCode.E))
        {
            if (bubble.activeSelf == true)
            {
                bubble.SetActive(false);
            }
            rope.SetActive(true);
            ropeFinish.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //EŰ bubble Ȱ��ȭ
        if (!ropeSwitch && !rope.activeSelf && collision.gameObject.CompareTag("Rope1"))
        {
            bubble.SetActive(true);
            ropeSwitch = true;
        }

        if (collision.gameObject.CompareTag("RopeFinish"))
        {
            rope.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //��ٸ��� ���� �� �ִ� ������ ������
        if (collision.gameObject.CompareTag("Rope1"))
        {
            bubble.SetActive(false);
            ropeSwitch = false;
        }
    }
}
