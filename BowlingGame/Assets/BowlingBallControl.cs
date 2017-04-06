using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BowlingBallControl : MonoBehaviour {

    public float maxForce;
    public float curForce;
    public float timer;

    private int shotCount;

    public bool hasRotated;
    public bool canFill;
    private bool canRoll;

    public Rigidbody rb;

    public Image powFill;

    public GameObject rotArrow;
    public GameObject powArrow;
    public GameObject BowlingBall;

    void OnEnable()
    {
        hasRotated = false;
        powArrow.SetActive(false);
    }

    void Update() {
        Bowl();
        if (canFill == true) {
            if (powFill.fillAmount < 1)
            {
                powFill.fillAmount += .1f * Time.deltaTime;

            }
            else if (powFill.fillAmount >= 1)
            {
                powFill.fillAmount = 0;
            }
        }
    }
    
    public void Bowl()
    {
        if(Input.GetButtonDown("Fire1") && !hasRotated)
        {
            shotCount++;
            BallRotation.canRotate = false;
            //rb.AddForce(transform.forward * currentForce);
            //rotArrow.SetActive(false);
            hasRotated = true;

            if (Input.GetButtonDown("Fire1")&& shotCount == 1)
            {
                powArrow.SetActive(true);
                shotCount = 0;
                canFill = true;
                canRoll = true;

                if(canRoll== true)
                {
                    
                }
                
                //rb.AddForce(transform.forward * curForce);
                //powFill.fillAmount = curForce / maxForce;
                //if(powFill.fillAmount <1 ){
                //    powFill.fillAmount += .1f * Time.deltaTime;
                         
                //}
                //else if(powFill.fillAmount >= 1){
                //    powFill.fillAmount = 0;
                }
            }
        }
}


