using UnityEngine;
using System.Collections;

public class BallRotation : MonoBehaviour {

    public enum RotationVals
        {
            MouseXY = 0,
            MouseX = 1,
            MouseY = 2
        }

    public static bool canRotate;

    public RotationVals axes = RotationVals.MouseXY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumHor = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;
    private float _rotationY = 0;

    void Start()
    {
        canRotate = true; 
     }
    void Update()
    {
        if(canRotate)
        MouseRotation();
    }

    public void MouseRotation()
        {
            if (axes == RotationVals.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
            }else if (axes == RotationVals.MouseY){
                _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                _rotationX = Mathf.Clamp(_rotationX, minimumHor, maximumVert);

                //float rotationY = transform.localEulerAngles.y;
                //transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
            else
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                _rotationX = Mathf.Clamp(_rotationX, minimumHor, maximumVert);

                _rotationY -= Input.GetAxis("Mouse X") * sensitivityHor;
                _rotationY = Mathf.Clamp(_rotationY, minimumHor, maximumVert);
                //float delta = Input.GetAxis("Mouse X") * sensitivityHor;
                //float rotationY = transform.localEulerAngles.y + delta;
                transform.localEulerAngles = new Vector3(_rotationX, -_rotationY, 0);
            }
        }
    }
