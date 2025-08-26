using UnityEngine;
using System.Collections;

public class StudentVisualScript : MonoBehaviour
{
    public Animator StudentAnimator;
    public AudioSource StudentAudioSource;

    public void KillStudnet()
    {
        //make student dead
        StudentAnimator.SetBool("StudentDead", true);
    }

    public void ShockStudent()
    {
        //shock student
        StudentAnimator.SetTrigger("enterShock");
        StudentAudioSource.Play();
    }
}
