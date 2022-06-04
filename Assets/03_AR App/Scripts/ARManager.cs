using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Script to handle AR inputs
/// </summary>
namespace ARApp
{
    public class ARManager : MonoBehaviour
    {
        public GameObject myObj;
        public ARRaycastManager raycastManager;

        public Button menuBtn;

        private void Start()
        {
            menuBtn.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("Menu");
            });
        }

        void Update()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                List<ARRaycastHit> touches = new List<ARRaycastHit>();

                raycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

                if(touches.Count > 0) Instantiate(myObj, touches[0].pose.position, touches[0].pose.rotation);
            }
        }
    }
}
