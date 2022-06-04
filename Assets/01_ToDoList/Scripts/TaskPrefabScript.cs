using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/// <summary>
/// This script handles prefab functions
/// </summary>
namespace ToDoList
{
    public class TaskPrefabScript : MonoBehaviour
    {
        public TextMeshProUGUI listDescTxt;
        public Button crossBtn;

        private void OnEnable()
        {
            crossBtn.onClick.AddListener(DeActiveButton);
        }

        private void OnDisable()
        {
            crossBtn.onClick.RemoveListener(DeActiveButton);
        }

        void DeActiveButton()
        {
            Destroy(gameObject);
        }
    }
}
