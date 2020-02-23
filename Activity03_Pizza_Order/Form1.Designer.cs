namespace Activity03_Pizza_Order
{
    partial class frmBuildPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuildPizza = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbOnions = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(56, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTomatoes);
            this.groupBox2.Controls.Add(this.cbOnions);
            this.groupBox2.Controls.Add(this.cbMushrooms);
            this.groupBox2.Controls.Add(this.cbExtraCheese);
            this.groupBox2.Location = new System.Drawing.Point(359, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbThickCrust);
            this.groupBox3.Controls.Add(this.rbThinCrust);
            this.groupBox3.Location = new System.Drawing.Point(56, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crush Type";
            // 
            // btnBuildPizza
            // 
            this.btnBuildPizza.Location = new System.Drawing.Point(186, 298);
            this.btnBuildPizza.Name = "btnBuildPizza";
            this.btnBuildPizza.Size = new System.Drawing.Size(145, 48);
            this.btnBuildPizza.TabIndex = 0;
            this.btnBuildPizza.Text = "Build Pizza";
            this.btnBuildPizza.UseVisualStyleBackColor = true;
            this.btnBuildPizza.Click += new System.EventHandler(this.btnBuildPizza_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(359, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbSmall
            // 
            this.rbSmall.Location = new System.Drawing.Point(34, 22);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(100, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.Location = new System.Drawing.Point(34, 63);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(100, 23);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.Location = new System.Drawing.Point(34, 104);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(100, 23);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.Location = new System.Drawing.Point(60, 19);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(120, 26);
            this.cbExtraCheese.TabIndex = 0;
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.Location = new System.Drawing.Point(60, 51);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(105, 26);
            this.cbMushrooms.TabIndex = 1;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            // 
            // cbOnions
            // 
            this.cbOnions.Location = new System.Drawing.Point(60, 83);
            this.cbOnions.Name = "cbOnions";
            this.cbOnions.Size = new System.Drawing.Size(105, 26);
            this.cbOnions.TabIndex = 2;
            this.cbOnions.Text = "Onions";
            this.cbOnions.UseVisualStyleBackColor = true;
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.Location = new System.Drawing.Point(60, 116);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(105, 26);
            this.cbTomatoes.TabIndex = 3;
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(49, 30);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(91, 21);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(162, 30);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(97, 21);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(359, 234);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(62, 21);
            this.rbEatIn.TabIndex = 4;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(477, 234);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(85, 21);
            this.rbTakeOut.TabIndex = 5;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            // 
            // frmBuildPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImage = global::Activity03_Pizza_Order.Properties.Resources.Pizza;
            this.ClientSize = new System.Drawing.Size(704, 372);
            this.Controls.Add(this.rbTakeOut);
            this.Controls.Add(this.rbEatIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuildPizza);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBuildPizza";
            this.Text = "Select Your Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuildPizza;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbOnions;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
    }
}

