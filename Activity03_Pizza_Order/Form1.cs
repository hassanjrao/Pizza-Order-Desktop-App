using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity03_Pizza_Order
{
    public partial class frmBuildPizza : Form
    {
        string size="";
        string toppings="";
        string crust_type="";
        string eat_Or_take="";
        public frmBuildPizza()
        {
            InitializeComponent();
        }

        private void btnBuildPizza_Click(object sender, EventArgs e)
        {
            // Checking For Size ......
            if (this.rbMedium.Checked)
                size = "Medium";
            else if (this.rbSmall.Checked)
                size = "Small";
            else if (this.rbLarge.Checked)
                size = "Large";
            // Checking For Crush Type...
            if (this.rbThinCrust.Checked)
                crust_type = "Thin";
            else if (this.rbThickCrust.Checked)
                crust_type = "Thick";
            // Checking Fro Toppings
            if (this.cbExtraCheese.Checked)
                toppings = "Extra Cheese";
            else if (this.cbMushrooms.Checked)
                toppings = "Mushrooms";
            else if (this.cbOnions.Checked)
                toppings = "Onions";
            else if (this.cbTomatoes.Checked)
                toppings = "Tomatoes";
            // Checking For Eat in Or Take Out ...
            if (this.rbEatIn.Checked)
                eat_Or_take = "Eat In";
            else if (this.rbTakeOut.Checked)
                eat_Or_take = "Take Out";

            if (size=="" || toppings=="" || crust_type=="" || eat_Or_take=="")
                MessageBox.Show("Kindly Complete the Information.....\n\tThanks");
            else
                MessageBox.Show("Size is: " + size + "\nToppings: " + toppings + "\nCrust is: " + crust_type + "\n" + eat_Or_take, "Your Order!");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
