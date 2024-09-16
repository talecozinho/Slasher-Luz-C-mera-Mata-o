using UnityEngine;

public class CameraMechanics : MonoBehaviour
{
    public int battery;

    public float range;

    bool flashing;

    public Camera fpsCam;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public LayerMask whatIsEnemy;

    private void MyInput()
    {
        flashing = Input.GetKeyDown(KeyCode.Mouse0);

        if (flashing == true && battery >= 30)
        {
            Flash();
        }
    }

    private void Flash()
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out rayHit, range, whatIsEnemy))
        {
            battery -= 30;
        }
        if (rayHit.collider.CompareTag("Enemy"))
        {
            rayHit.collider.GetComponent<EnemyAI>().DestroyEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }
}
