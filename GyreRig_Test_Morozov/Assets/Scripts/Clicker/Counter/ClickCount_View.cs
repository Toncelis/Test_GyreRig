using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Views
{
    public class ClickCount_View : MonoBehaviour
    {
        [Header("Зависимости")]

        [SerializeField] Models.ClickCount_Model myModel;
        
        [Tooltip("Текстовое поле, в котором отображается количество кликов")]
        [SerializeField] UnityEngine.UI.Text text;

         public void UpdateShownValue ()
        {
            text.text = $"{myModel.Value}";
        }
        void Start()
        {
            UpdateShownValue();
        }
    }
}
