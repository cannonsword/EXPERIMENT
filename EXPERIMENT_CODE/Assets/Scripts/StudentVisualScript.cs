using UnityEngine;
using System.Collections;

public class StudentVisualScript : MonoBehaviour
{
    public Animator StudentAnimator;

    public void KillStudnet()
    {
        //make student dead
        StudentAnimator.SetBool("StudentDead", true) ;
    }

    public void ShockStudent()
    {
        //shock student
        StudentAnimator.SetTrigger("enterShock");
    }
}
