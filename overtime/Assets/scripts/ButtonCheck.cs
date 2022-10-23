using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    public GameObject BottonPressed;
    public GameObject Botton;
    public GameObject BottonInsidePressed;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ChooseAnim();
    }

    /*  void ChooseAnim()
      {
          if (BottonPressed.activeSelf)
          {
              animator.Play("elevator");
          }
          if (Botton.activeSelf)
          {
              animator.Play("elevatorClose");
          }
          if (BottonInsidePressed.activeSelf)
          {
              animator.Play("flickering");
          }
      }*/
    void ChooseAnim()
    {
        if (BottonPressed.activeSelf)
        {
            animator.Play("elevator");
        }
        if (Botton.activeSelf)
        {
            animator.Play("elevatorClose");
        }
        if (BottonInsidePressed.activeSelf)
        {
            animator.Play("flickering");
        }
    }
}
