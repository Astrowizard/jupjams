using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Transform cam;

    Vector3 m_move;
    float m_zoom;
    float m_turn;

    public float moveSpeed;
    public float turnSpeed;
    public float highLimit;
    public float lowLimit;
    public float zoomSpeed;

    // public void OnMovementChanged(InputAction.CallbackContext context){
    //     m_move = context.ReadValue<Vector2>();
    //     // Move(m_move);
    // }

    public void OnZoomChanged(InputAction.CallbackContext context){
        m_zoom = context.ReadValue<float>();
        Debug.Log(m_zoom);
        Zoom(m_zoom);
    }

    // public void OnTurnChanged(InputAction.CallbackContext context){
    //     m_turn = context.ReadValue<float>();
    // }


    void Start()
    {
        cam = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        // Move(m_move);
        // Turn(m_turn);
        // Zoom1(m_zoom);
    }

    private void Move(Vector2 direction){
        if (direction.sqrMagnitude < 0.01)
            return;
        var scaledMoveSpeed = moveSpeed * Time.deltaTime;
        // For simplicity's sake, we just keep movement in a single plane here. Rotate
        // direction according to world Y rotation of player.
        var move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
        transform.position += move * scaledMoveSpeed;
    }

    private void Zoom(float magnitude){
        // if (cam.transform.position.y <= lowLimit && magnitude > 0f){
        if(cam.transform.localPosition.z >= 0f && magnitude > 0f) {
            cam.transform.localPosition = Vector3.Scale(cam.transform.localPosition,new Vector3(1f,1f,0f));
            return;
        }
        else if (cam.transform.position.z <= highLimit && magnitude < 0f){
            return;
        }
        else{
            cam.transform.position += cam.transform.forward * zoomSpeed * magnitude * Time.deltaTime;
        }

    }

    private void Zoom1(float magnitude){
        Vector3 temp = cam.transform.localPosition + cam.transform.forward * zoomSpeed * magnitude * Time.deltaTime;
        Debug.Log(temp);
        if (temp.z >= lowLimit){
            cam.transform.localPosition = Vector3.Scale(cam.transform.localPosition,new Vector3(1f,1f,0f));
            return;
        }
        if (temp.z <= highLimit){
            cam.transform.localPosition = Vector3.Scale(cam.transform.localPosition,new Vector3(1f,1f,0f)) + new Vector3(0f,highLimit,0f);
            return;
        }
        cam.transform.position = temp;
        

    }

    private void Turn(float magnitude){
        transform.Rotate(new Vector3(0f,magnitude * turnSpeed,0f));
    }
}














// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.InputSystem;

// public class CameraMovement : MonoBehaviour {

//     Rigidbody r;
//     Transform c;

//     public float moveSpeed;
//     Vector3 position;
//     Vector3 nmoveDirection;
//     Vector2 moveDirection;

//     [SerializeField]public InputActionAsset playerControls;
//     InputActionMap cameraActions;
//     InputAction movement;
//     InputAction scroll;
//     InputAction shoot;

// 	// Use this for initialization
// 	void Awake () {
//         r = GetComponent<Rigidbody>();
//         c = transform.GetChild(0);

//         cameraActions = playerControls.FindActionMap("Camera",false);
//         Debug.Log(cameraActions.ToString());
//         movement = cameraActions.FindAction("Movement");
//         scroll = cameraActions.FindAction("Scroll");
//         shoot = cameraActions.FindAction("Shoot");

// 	}

//     void OnEnable() {
//         playerControls.Enable();
//     }
	
// 	// Update is called once per frame=
//     void Update(){
//         moveDirection = movement.ReadValue<Vector2>();
//         nmoveDirection = new Vector3(1f,1f,1f) * moveDirection;
//         position += nmoveDirection * moveSpeed * Time.deltaTime;
//         moveCamera(position);
//     }

//     void moveCamera(Vector3 posistion){
//         transform.Translate(position);  
//     }
// }

// 	// void Update () {
//     //     var x = Input.GetAxis("Horizontal") * .4f;
//     //     var y = Input.GetAxis("Vertical")* .4f;
//     //     //var a = Input.GetAxis("Angular") * 2f;

//     //     //var m = Input.GetAxis("Mouse ScrollWheel") * 2f;

//     //     transform.Translate(x, 0, 0);
//     //     transform.Translate(0, y, 0);
//     //     //transform.Rotate(0, a, 0);

//     //     if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
//     //     {
//     //         r.velocity = c.transform.forward * 100f;
//     //     }
//     //     else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
//     //     {
//     //         r.velocity = -c.transform.forward * 100f;
//     //     }
//     //     else
//     //     {
//     //         r.velocity = new Vector3();
//     //     }
//     // }