using UnityEngine;

public class fallingobject : MonoBehaviour {
    public Rigidbody fb;
    //public float downwardforce = 30f;
    public float upwardforce = 10f ;
	// Update is called once per frame
	void FixedUpdate () {
        fb.AddForce(0, upwardforce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
    public void Fallingdown()
    {
        upwardforce = -50f ;
        //fb.AddForce(0, -downwardforce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
}
