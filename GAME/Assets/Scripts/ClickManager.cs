using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameManager gameManager;
    public Camera maincamera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click");
            Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            //Debug.Log(hit.collider.transform.name);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.transform.name);
                gameManager.LaunchEffect(hit.collider.GetComponent<ClickTarget>().type);
            }  
        } 
    }
}