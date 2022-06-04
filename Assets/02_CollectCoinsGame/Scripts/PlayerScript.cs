using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Player script will handle all the movement and coin trigger of player
/// </summary>
namespace CollectCoins
{
    public class PlayerScript : MonoBehaviour
    {
        public Rigidbody rb;
        public float speed = 4f;
        public FixedJoystick fixedJoystick;

        public CollectCoinUIManager coinManager;

        void Update()
        {
            Vector3 moveDir = fixedJoystick.Direction;
            moveDir.z = moveDir.y;
            moveDir.y = 0;

            rb.velocity = moveDir * speed;

            float angle = Mathf.Atan2(moveDir.x, moveDir.z) * Mathf.Rad2Deg;
            if(moveDir.magnitude != 0) transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Coin"))
            {
                coinManager.CoinCollected();
                Destroy(other.gameObject);
            }
        }
    }
}
