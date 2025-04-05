using UnityEngine;
using Photon.Pun;  
using UnityEngine.UI;

public class Player : MonoBehaviourPunCallbacks  
{
    public PhotonView photonView;
    public Rigidbody2D rb;
    public Animator anim;
    public GameObject PlayerCamera;
    public SpriteRenderer sr;
    public Text PlayerNameText;
    
    public bool IsGrounded = false;
    public float MoveSpeed;
    public float JumpForce;

    private void Awake(){
        if (photonView.IsMine){ 
            PlayerCamera.SetActive(true);
        }
    }

    private void Update(){
        if (photonView.IsMine){ 
            CheckInput();
        }
    }

    private void CheckInput(){
        var move = new Vector3(Input.GetAxisRaw("Horizontal"), 0); 
        transform.position += move * MoveSpeed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.A)){
            sr.flipX = true;
        }

        if(Input.GetKeyDown(KeyCode.D)){
            sr.flipX = false;
        }
    }
}
