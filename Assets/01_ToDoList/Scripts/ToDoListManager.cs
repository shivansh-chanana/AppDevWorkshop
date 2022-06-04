using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This is manager class , it will handle all the functions of task list;
/// </summary>
namespace ToDoList
{
    public class ToDoListManager : MonoBehaviour
    {
        //variables for task gameobjects
        public GameObject taskPrefab;
        public Transform taskContainer;
        [Space]
        //variables for button and ui
        public TMP_InputField taskDescTxt;
        public Button addTaskBtn , clearBtn , menuBtn;

        private void OnEnable()
        {
            addTaskBtn.onClick.AddListener(AddTaskFunction);
            clearBtn.onClick.AddListener(ClearTextFunction);

            menuBtn.onClick.AddListener(()=> 
            {
                SceneManager.LoadScene("Menu");
            });
        }

        private void OnDisable()
        {
            addTaskBtn.onClick.RemoveListener(AddTaskFunction);
            clearBtn.onClick.RemoveListener(ClearTextFunction);

            menuBtn.onClick.RemoveAllListeners();
        }

        //Add prefab to containter
        void AddTaskFunction() 
        {
            GameObject task = Instantiate(taskPrefab,taskContainer);
            TaskPrefabScript taskPrefabScript = task.GetComponent<TaskPrefabScript>();

            taskPrefabScript.listDescTxt.text = taskDescTxt.text;
        }

        //Clear text of input
        void ClearTextFunction() 
        {
            taskDescTxt.text = "";
        }
    }
}
