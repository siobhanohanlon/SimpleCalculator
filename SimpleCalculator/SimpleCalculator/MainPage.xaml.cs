using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleCalculator
{
    public partial class MainPage : ContentPage
    {
        //Already here by default
        public MainPage()
        {
            InitializeComponent();
        }

        //When button pressed
        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            //Convert Variables
            float fHeight= (float)Convert.ToDouble(EntryHeight.Text);
            float fWeight = (float)Convert.ToDouble(EntryWeight.Text);
            float BMI;

            //Calculations
            fHeight *= fHeight;
            BMI = fWeight / fHeight;

            //Check Inputs


            //Display Result
            LblBMIValue.Text = "Your BMI is: " + BMI.ToString();
        }
    }
}
