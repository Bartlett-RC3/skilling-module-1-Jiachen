using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RC3
{
    public class SeedImage :MonoBehaviour
    {
        Dropdown myDropdown;


        void Start ()
        {
            myDropdown = this.GetComponent<Dropdown>();
	        myDropdown.ClearOptions();

            Dropdown.OptionData op1=new Dropdown.OptionData();
	        op1.text = "SeedImage1";
            Dropdown.OptionData op2=new Dropdown.OptionData();
	        op2.text = "SeedImage2";
            Dropdown.OptionData op3=new Dropdown.OptionData();
	        op3.text = "SeedImage3";
            Dropdown.OptionData op4 = new Dropdown.OptionData();
            op4.text = "SeedImage4";
            Dropdown.OptionData op5 = new Dropdown.OptionData();
            op5.text = "SeedImage5";
            Dropdown.OptionData op6 = new Dropdown.OptionData();
            op6.text = "SeedImage6";
            Dropdown.OptionData op7 = new Dropdown.OptionData();
            op7.text = "SeedImage7";
            Dropdown.OptionData op8 = new Dropdown.OptionData();
            op8.text = "SeedImage8";
            Dropdown.OptionData op9 = new Dropdown.OptionData();
            op9.text = "SeedImage9";
            Dropdown.OptionData op10 = new Dropdown.OptionData();
            op10.text = "SeedImage10";
            Dropdown.OptionData op11 = new Dropdown.OptionData();
            op11.text = "SeedImage11";
            Dropdown.OptionData op12 = new Dropdown.OptionData();
            op12.text = "SeedImage12";
            Dropdown.OptionData op13 = new Dropdown.OptionData();
            op13.text = "SeedImage13";
            Dropdown.OptionData op14 = new Dropdown.OptionData();
            op14.text = "SeedImage14";
            Dropdown.OptionData op15 = new Dropdown.OptionData();
            op15.text = "SeedImage15";
            Dropdown.OptionData op16 = new Dropdown.OptionData();
            op16.text = "SeedImage16";
            Dropdown.OptionData op17 = new Dropdown.OptionData();
            op17.text = "SeedImage17";
            Dropdown.OptionData op18 = new Dropdown.OptionData();
            op18.text = "SeedImage18";

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
            myDropdown.options.Add(op18);

            myDropdown.onValueChanged.AddListener(ClickDropdown);

	        myDropdown.captionText.text = "SeedImage";

	    }

        public void ClickDropdown(int index)
        {

            Debug.Log(myDropdown.options[index].text);

        }
       
    }
}
