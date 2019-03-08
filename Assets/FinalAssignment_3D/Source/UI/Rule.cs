using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RC3
{
    public class Rule : MonoBehaviour
    {
        Dropdown myDropdown;


        void Start()
        {
            myDropdown = this.GetComponent<Dropdown>();
            myDropdown.ClearOptions();

            Dropdown.OptionData op17 = new Dropdown.OptionData();
            op17.text = "Stable1:2323";
            Dropdown.OptionData op2 = new Dropdown.OptionData();
            op2.text = "Stable2:1223";
            Dropdown.OptionData op3 = new Dropdown.OptionData();
            op3.text = "Stable3:3322";
            Dropdown.OptionData op4 = new Dropdown.OptionData();
            op4.text = "Stable4:1333";
            Dropdown.OptionData op5 = new Dropdown.OptionData();
            op5.text = "Stable5:2411";

            Dropdown.OptionData op6 = new Dropdown.OptionData();
            op6.text = "Verticle:2645";

            Dropdown.OptionData op7 = new Dropdown.OptionData();
            op7.text = "Column:0133";

            Dropdown.OptionData op8 = new Dropdown.OptionData();
            op8.text = "Increase1:2334";
            Dropdown.OptionData op9 = new Dropdown.OptionData();
            op9.text = "Increase2:3533";
            Dropdown.OptionData op10 = new Dropdown.OptionData();
            op10.text = "Increase3:3434";
            Dropdown.OptionData op11 = new Dropdown.OptionData();
            op11.text = "Increase4:1234";

            Dropdown.OptionData op12 = new Dropdown.OptionData();
            op12.text = "Decrease1:4733";
            Dropdown.OptionData op13 = new Dropdown.OptionData();
            op13.text = "Decrease2:2333";

            Dropdown.OptionData op14 = new Dropdown.OptionData();
            op14.text = "Dead:3555";

            Dropdown.OptionData op15 = new Dropdown.OptionData();
            op15.text = "OriginalImage:5844";
            Dropdown.OptionData op16 = new Dropdown.OptionData();
            op16.text = "StripeImage:2700";

            Dropdown.OptionData op1 = new Dropdown.OptionData();
            op1.text = "2333";


            myDropdown.options.Add(op1);
            myDropdown.options.Add(op2);
            myDropdown.options.Add(op3);
            myDropdown.options.Add(op4);
            myDropdown.options.Add(op5);
            myDropdown.options.Add(op6);
            myDropdown.options.Add(op7);
            myDropdown.options.Add(op8);
            myDropdown.options.Add(op9);
            myDropdown.options.Add(op10);
            myDropdown.options.Add(op11);
            myDropdown.options.Add(op12);
            myDropdown.options.Add(op13);
            myDropdown.options.Add(op14);
            myDropdown.options.Add(op15);
            myDropdown.options.Add(op16);
            myDropdown.options.Add(op17);

            myDropdown.onValueChanged.AddListener(ClickDropdown);

            myDropdown.captionText.text = "Rule";

        }

        public void ClickDropdown(int index)
        {

            Debug.Log(myDropdown.options[index].text);

        }

    }
}
