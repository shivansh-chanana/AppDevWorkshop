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
            if (Input.GetMouseButtonDown(0))
            {
                List<ARRaycastHit> hits = new List<ARRaycastHit>();

                raycastManager.Raycast(Input.mousePosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

                if(hits.Count > 0) Instantiate(myObj, hits[0].pose.position, hits[0].pose.rotation);
            }
        }
    }
}
