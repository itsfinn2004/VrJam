using System.Collections;
using UnityEngine;


public class TimeSwitch : MonoBehaviour
{
    //public bool future;
    public GameObject player;
    private Renderer oldColor;
    public GameObject other;
    //public GameObject futureMachine;
    private bool fading = true;
    public AudioSource tpsSund;
    
   
    private void OnTriggerEnter(Collider other)
    {
        if (tpsSund != null)
        {
            tpsSund.Play(0);
        }
        if(other.gameObject.tag == "Player")
        {
            player = other.gameObject;
            tpp();
        }
        else
        {
            Debug.Log("enter");
            player = other.gameObject;
            oldColor = other.gameObject.GetComponent<MeshRenderer>();
            StartCoroutine(fade());
            print("action");
        }
    }
    public void tpp()
    {
        //Debug.Log("tp");
        //if (future)
        //{
        
        player.transform.position = other.transform.position;
        //    fading = true;
        //    player.transform.position = pastMachine.transform.position;
        //    Debug.Log("past");
        //    future = !future;
            
        //}
        //else if (!future)
        //{
        //    fading = true;
        //    player.transform.position = futureMachine.transform.position;
        //    Debug.Log("future");
        //    future = !future;
            
        //}
    }
    IEnumerator fade()
    {

        while (fading)
        {
            Color a = oldColor.material.color;
            a.a -= 2f * Time.deltaTime;
            oldColor.material.color = a;
            yield return new WaitForSeconds(0.005f);
            //Debug.Log(a.a);
            if (a.a < 0)
            {
                fading = false;
            }
            
        }
        fading = true;
        Color b = oldColor.material.color;
        b.a = 1;
        oldColor.material.color = b;
        tpp();
    }
}
