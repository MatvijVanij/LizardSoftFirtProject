
namespace UMLLizardSoft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonAssociation = new System.Windows.Forms.RadioButton();
            this.radioButtonInheritance = new System.Windows.Forms.RadioButton();
            this.radioButtonAggregation = new System.Windows.Forms.RadioButton();
            this.radioButtonСomposition = new System.Windows.Forms.RadioButton();
            this.radioButtonImplementation = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColorPalette = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonRectangle1 = new System.Windows.Forms.RadioButton();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonStepBack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAssociation
            // 
            this.radioButtonAssociation.AutoSize = true;
            this.radioButtonAssociation.Location = new System.Drawing.Point(64, 12);
            this.radioButtonAssociation.Name = "radioButtonAssociation";
            this.radioButtonAssociation.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAssociation.TabIndex = 1;
            this.radioButtonAssociation.Text = "Asotiation";
            this.radioButtonAssociation.UseVisualStyleBackColor = true;
            this.radioButtonAssociation.CheckedChanged += new System.EventHandler(this.radioButtonAssociation_CheckedChanged);
            // 
            // radioButtonInheritance
            // 
            this.radioButtonInheritance.AutoSize = true;
            this.radioButtonInheritance.Location = new System.Drawing.Point(64, 35);
            this.radioButtonInheritance.Name = "radioButtonInheritance";
            this.radioButtonInheritance.Size = new System.Drawing.Size(78, 17);
            this.radioButtonInheritance.TabIndex = 2;
            this.radioButtonInheritance.Text = "Inheritance";
            this.radioButtonInheritance.UseVisualStyleBackColor = true;
            this.radioButtonInheritance.CheckedChanged += new System.EventHandler(this.radioButtonInheritance_CheckedChanged);
            // 
            // radioButtonAggregation
            // 
            this.radioButtonAggregation.AutoSize = true;
            this.radioButtonAggregation.Location = new System.Drawing.Point(64, 58);
            this.radioButtonAggregation.Name = "radioButtonAggregation";
            this.radioButtonAggregation.Size = new System.Drawing.Size(82, 17);
            this.radioButtonAggregation.TabIndex = 3;
            this.radioButtonAggregation.Text = "Aggregation";
            this.radioButtonAggregation.UseVisualStyleBackColor = true;
            this.radioButtonAggregation.CheckedChanged += new System.EventHandler(this.radioButtonAggregation_CheckedChanged);
            // 
            // radioButtonСomposition
            // 
            this.radioButtonСomposition.AutoSize = true;
            this.radioButtonСomposition.Location = new System.Drawing.Point(64, 81);
            this.radioButtonСomposition.Name = "radioButtonСomposition";
            this.radioButtonСomposition.Size = new System.Drawing.Size(82, 17);
            this.radioButtonСomposition.TabIndex = 4;
            this.radioButtonСomposition.Text = "Сomposition";
            this.radioButtonСomposition.UseVisualStyleBackColor = true;
            this.radioButtonСomposition.CheckedChanged += new System.EventHandler(this.radioButtonСomposition_CheckedChanged);
            // 
            // radioButtonImplementation
            // 
            this.radioButtonImplementation.AutoSize = true;
            this.radioButtonImplementation.Location = new System.Drawing.Point(64, 103);
            this.radioButtonImplementation.Name = "radioButtonImplementation";
            this.radioButtonImplementation.Size = new System.Drawing.Size(96, 17);
            this.radioButtonImplementation.TabIndex = 5;
            this.radioButtonImplementation.Text = "Implementation";
            this.radioButtonImplementation.UseVisualStyleBackColor = true;
            this.radioButtonImplementation.CheckedChanged += new System.EventHandler(this.radioButtonImplementation_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 448);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(178, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_5;
            this.pictureBox6.Location = new System.Drawing.Point(8, 60);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 16);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_6;
            this.pictureBox5.Location = new System.Drawing.Point(8, 81);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 16);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_3;
            this.pictureBox4.Location = new System.Drawing.Point(8, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 16);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_2;
            this.pictureBox3.Location = new System.Drawing.Point(8, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 16);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_1__2_;
            this.pictureBox2.Location = new System.Drawing.Point(8, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 16);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(222, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 481);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonColorPalette
            // 
            this.buttonColorPalette.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonColorPalette.Location = new System.Drawing.Point(13, 393);
            this.buttonColorPalette.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColorPalette.Name = "buttonColorPalette";
            this.buttonColorPalette.Size = new System.Drawing.Size(40, 40);
            this.buttonColorPalette.TabIndex = 11;
            this.buttonColorPalette.UseVisualStyleBackColor = false;
            this.buttonColorPalette.Click += new System.EventHandler(this.buttonColorPalette_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(64, 393);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(126, 40);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonRectangle1
            // 
            this.radioButtonRectangle1.AutoSize = true;
            this.radioButtonRectangle1.Checked = true;
            this.radioButtonRectangle1.Location = new System.Drawing.Point(64, 164);
            this.radioButtonRectangle1.Name = "radioButtonRectangle1";
            this.radioButtonRectangle1.Size = new System.Drawing.Size(80, 17);
            this.radioButtonRectangle1.TabIndex = 14;
            this.radioButtonRectangle1.TabStop = true;
            this.radioButtonRectangle1.Text = "Rectangle1";
            this.radioButtonRectangle1.UseVisualStyleBackColor = true;
            this.radioButtonRectangle1.CheckedChanged += new System.EventHandler(this.radioButtonRectangle1_CheckedChanged);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(13, 353);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(177, 35);
            this.buttonMove.TabIndex = 15;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonStepBack
            // 
            this.buttonStepBack.Location = new System.Drawing.Point(13, 312);
            this.buttonStepBack.Name = "buttonStepBack";
            this.buttonStepBack.Size = new System.Drawing.Size(177, 35);
            this.buttonStepBack.TabIndex = 16;
            this.buttonStepBack.Text = "Step back";
            this.buttonStepBack.UseVisualStyleBackColor = true;
            this.buttonStepBack.Click += new System.EventHandler(this.StepBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(13, 271);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(177, 35);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete selected";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(8, 144);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 47);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1044, 502);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonStepBack);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.radioButtonRectangle1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonColorPalette);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.radioButtonImplementation);
            this.Controls.Add(this.radioButtonСomposition);
            this.Controls.Add(this.radioButtonAggregation);
            this.Controls.Add(this.radioButtonInheritance);
            this.Controls.Add(this.radioButtonAssociation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonAssociation;
        private System.Windows.Forms.RadioButton radioButtonInheritance;
        private System.Windows.Forms.RadioButton radioButtonAggregation;
        private System.Windows.Forms.RadioButton radioButtonСomposition;
        private System.Windows.Forms.RadioButton radioButtonImplementation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColorPalette;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonRectangle1;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonStepBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

