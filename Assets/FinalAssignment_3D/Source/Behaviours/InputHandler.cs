using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class InputHandler : MonoBehaviour
    {
        private StackModel _model;
        private StackDisplay _display;
        [SerializeField] private Button _button;

        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            _model = GetComponent<StackModel>();
            _display = GetComponent<StackDisplay>();
        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            _button.onClick.AddListener(() => { HandleKeyPress(); });
        }


        /// <summary>
        /// 
        /// </summary>
        private void HandleKeyPress()
        {
            // Reset model
            _model.ResetModel();
          
        }
    }
}
