using UnityEngine;

public class Triggering : MonoBehaviour {

    public fallingobject FallingObject ;

    private void OnTriggerEnter()
    {
        if(FallingObject != null)
        {
            FallingObject.Fallingdown();
        }
      
    }
}
