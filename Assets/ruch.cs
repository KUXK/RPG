using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject[] skillParticles;
    private IEnumerator coroutine;
    void Start()
    {
        animator = GetComponent<Animator>();
        for(int i=0; i < skillParticles.Length; i++)
        {
            skillParticles[i].SetActive(false);
        }
    }


    void Update()
    {

        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("bieg", false);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            UseSkill(1);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            UseSkill(2);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            UseSkill(3);
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            UseSkill(4);
        }

    }
    void UseSkill(int skillNumber)
    {
        animator.SetTrigger("skill" + skillNumber);
        skillParticles[skillNumber - 1].SetActive(true);
        switch(skillNumber)
        {
            case 1:
                coroutine = WaitRoEnableObject(skillParticles[skillNumber - 1], 3);
                break;
            case 2:
                coroutine = WaitRoEnableObject(skillParticles[skillNumber - 1], 2);
                break;
            case 3:
                coroutine = WaitRoEnableObject(skillParticles[skillNumber - 1], 2);
                break;
            case 4:
                coroutine = WaitRoEnableObject(skillParticles[skillNumber - 1], 2);
                break;

        }

        
        StartCoroutine(coroutine);

    }
    IEnumerator WaitRoEnableObject(GameObject obj, float time)
    {
        yield return new WaitForSeconds(time);
        obj.SetActive(false);

    }
    public void Jump()
    {
        animator.SetTrigger("jump");
    }
    public void run()
    {
        animator.SetBool("bieg",true);
    }
    
    
}
