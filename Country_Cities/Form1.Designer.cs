namespace Country_Cities
{
    partial class Form1
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
            this.countryText = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ListBox();
            this.cityNameAdd = new System.Windows.Forms.TextBox();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.buttonRemoveCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericPopulation = new System.Windows.Forms.NumericUpDown();
            this.textFounded = new System.Windows.Forms.TextBox();
            this.textDiscription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDiscriptionAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textFoundedAdd = new System.Windows.Forms.TextBox();
            this.numericPopulationAdd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRenew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulationAdd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryText
            // 
            this.countryText.AutoSize = true;
            this.countryText.Location = new System.Drawing.Point(27, 23);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(46, 13);
            this.countryText.TabIndex = 0;
            this.countryText.Text = "Страна:";
            // 
            // cityText
            // 
            this.cityText.AutoSize = true;
            this.cityText.Location = new System.Drawing.Point(27, 80);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(46, 13);
            this.cityText.TabIndex = 1;
            this.cityText.Text = "Города:";
            // 
            // countryBox
            // 
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(95, 23);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(171, 21);
            this.countryBox.TabIndex = 2;
            this.countryBox.SelectedIndexChanged += new System.EventHandler(this.countryBox_SelectedIndexChanged);
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(97, 80);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(169, 147);
            this.cityBox.TabIndex = 3;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // cityNameAdd
            // 
            this.cityNameAdd.Location = new System.Drawing.Point(15, 44);
            this.cityNameAdd.Name = "cityNameAdd";
            this.cityNameAdd.Size = new System.Drawing.Size(164, 20);
            this.cityNameAdd.TabIndex = 4;
            this.cityNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(42, 385);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(114, 23);
            this.buttonAddCity.TabIndex = 5;
            this.buttonAddCity.Text = "Добавить";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            this.buttonAddCity.Click += new System.EventHandler(this.buttonAddCity_Click);
            // 
            // buttonRemoveCity
            // 
            this.buttonRemoveCity.Location = new System.Drawing.Point(142, 223);
            this.buttonRemoveCity.Name = "buttonRemoveCity";
            this.buttonRemoveCity.Size = new System.Drawing.Size(114, 23);
            this.buttonRemoveCity.TabIndex = 6;
            this.buttonRemoveCity.Text = "Удалить";
            this.buttonRemoveCity.UseVisualStyleBackColor = true;
            this.buttonRemoveCity.Click += new System.EventHandler(this.buttonRemoveCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Население:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Основан:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание:";
            // 
            // numericPopulation
            // 
            this.numericPopulation.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPopulation.Location = new System.Drawing.Point(85, 25);
            this.numericPopulation.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericPopulation.Name = "numericPopulation";
            this.numericPopulation.Size = new System.Drawing.Size(171, 20);
            this.numericPopulation.TabIndex = 10;
            this.numericPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPopulation.ThousandsSeparator = true;
            // 
            // textFounded
            // 
            this.textFounded.Location = new System.Drawing.Point(85, 69);
            this.textFounded.Name = "textFounded";
            this.textFounded.Size = new System.Drawing.Size(171, 20);
            this.textFounded.TabIndex = 11;
            this.textFounded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDiscription
            // 
            this.textDiscription.Location = new System.Drawing.Point(85, 112);
            this.textDiscription.Multiline = true;
            this.textDiscription.Name = "textDiscription";
            this.textDiscription.Size = new System.Drawing.Size(171, 96);
            this.textDiscription.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDiscriptionAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textFoundedAdd);
            this.groupBox1.Controls.Add(this.numericPopulationAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonAddCity);
            this.groupBox1.Controls.Add(this.cityNameAdd);
            this.groupBox1.Location = new System.Drawing.Point(305, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 423);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление города";
            // 
            // textDiscriptionAdd
            // 
            this.textDiscriptionAdd.Location = new System.Drawing.Point(15, 218);
            this.textDiscriptionAdd.Multiline = true;
            this.textDiscriptionAdd.Name = "textDiscriptionAdd";
            this.textDiscriptionAdd.Size = new System.Drawing.Size(164, 152);
            this.textDiscriptionAdd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Описание:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Год основания:";
            // 
            // textFoundedAdd
            // 
            this.textFoundedAdd.Location = new System.Drawing.Point(15, 161);
            this.textFoundedAdd.Name = "textFoundedAdd";
            this.textFoundedAdd.Size = new System.Drawing.Size(164, 20);
            this.textFoundedAdd.TabIndex = 14;
            this.textFoundedAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericPopulationAdd
            // 
            this.numericPopulationAdd.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPopulationAdd.Location = new System.Drawing.Point(15, 104);
            this.numericPopulationAdd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericPopulationAdd.Name = "numericPopulationAdd";
            this.numericPopulationAdd.Size = new System.Drawing.Size(164, 20);
            this.numericPopulationAdd.TabIndex = 14;
            this.numericPopulationAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPopulationAdd.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Население:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Название:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRenew);
            this.groupBox2.Controls.Add(this.textDiscription);
            this.groupBox2.Controls.Add(this.textFounded);
            this.groupBox2.Controls.Add(this.numericPopulation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonRemoveCity);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 260);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Детально о городе";
            // 
            // buttonRenew
            // 
            this.buttonRenew.Location = new System.Drawing.Point(14, 223);
            this.buttonRenew.Name = "buttonRenew";
            this.buttonRenew.Size = new System.Drawing.Size(114, 23);
            this.buttonRenew.TabIndex = 13;
            this.buttonRenew.Text = "Обновить";
            this.buttonRenew.UseVisualStyleBackColor = true;
            this.buttonRenew.Click += new System.EventHandler(this.buttonRenew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.countryText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страны и города";
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulationAdd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryText;
        private System.Windows.Forms.Label cityText;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.ListBox cityBox;
        private System.Windows.Forms.TextBox cityNameAdd;
        private System.Windows.Forms.Button buttonAddCity;
        private System.Windows.Forms.Button buttonRemoveCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericPopulation;
        private System.Windows.Forms.TextBox textFounded;
        private System.Windows.Forms.TextBox textDiscription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDiscriptionAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFoundedAdd;
        private System.Windows.Forms.NumericUpDown numericPopulationAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRenew;
    }
}

