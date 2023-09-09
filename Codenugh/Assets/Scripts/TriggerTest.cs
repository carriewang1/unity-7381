//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Video; 

//public class TriggerTest : MonoBehaviour
//{
//    public VideoPlayer videoPlayer; 

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player")) 
//        {
//            Debug.Log("Trigger entered");
//            PlayVideo();
//        }
//    }

//    private void PlayVideo()
//    {

//        if (videoPlayer != null)
//        {
//            videoPlayer.Play();
//        }
//    }

//    private void OnTriggerStay(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            Debug.Log("Player is inside the trigger area.");
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            Debug.Log("Trigger exited");
//            StopVideo();
//        }
//    }

//    private void StopVideo()
//    {

//        if (videoPlayer != null)
//        {
//            videoPlayer.Stop();
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        { Debug.Log("on"); }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Player")
        { Debug.Log("stay"); }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        { Debug.Log("exit"); }
    }
}
