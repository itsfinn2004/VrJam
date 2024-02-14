using System.Collections;
using UnityEngine;


public class TimeSwitch : MonoBehaviour
{
    public bool Future;
    public GameObject player;
    private Renderer oldColor;
    public GameObject pastMachine;
    public GameObject futureMachine;
    private bool fading = true;
    
    
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        player = other.gameObject;
        oldColor = other.gameObject.GetComponent<MeshRenderer>();
        StartCoroutine(fade());
        print("action");
    }
    public void tpp()
    {
        Debug.Log("tp");
        if (Future)
        {


            fading = true;
            player.transform.position = pastMachine.transform.position;
            Debug.Log("past");
            Future = !Future;
            
        }
        else if (!Future)
        {
            fading = true;
            player.transform.position = futureMachine.transform.position;
            Debug.Log("future");
            Future = !Future;
            
        }
    }
    IEnumerator fade()
    {

        while (fading)
        {
            Color a = oldColor.material.color;
            a.a -= 1f * Time.deltaTime;
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
