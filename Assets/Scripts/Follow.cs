using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
        public GameObject target;
        public float followSpeed = 0.5f; // Note the 'f' suffix to indicate float

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // Check if target is not null
            if (target != null)
            {
                // Calculate the position to move towards
                Vector3 movePosition = Vector3.Lerp(this.transform.position, target.transform.position, followSpeed);

                // Update the position
                this.transform.position = movePosition;
            }
            else
            {
                Debug.LogWarning("Target is not set for the follow script.");
            }
        }
}
