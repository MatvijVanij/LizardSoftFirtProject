
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
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.radioButtonRectangleStack = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClas = new System.Windows.Forms.Button();
            this.buttonFild = new System.Windows.Forms.Button();
            this.buttonMetod = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveAsImage = new System.Windows.Forms.Button();
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
            this.radioButtonAssociation.Location = new System.Drawing.Point(171, 29);
            this.radioButtonAssociation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonAssociation.Name = "radioButtonAssociation";
            this.radioButtonAssociation.Size = new System.Drawing.Size(179, 36);
            this.radioButtonAssociation.TabIndex = 1;
            this.radioButtonAssociation.Text = "Asotiation";
            this.radioButtonAssociation.UseVisualStyleBackColor = true;
            this.radioButtonAssociation.CheckedChanged += new System.EventHandler(this.RadioButtonAssociation_CheckedChanged);
            // 
            // radioButtonInheritance
            // 
            this.radioButtonInheritance.AutoSize = true;
            this.radioButtonInheritance.Location = new System.Drawing.Point(171, 83);
            this.radioButtonInheritance.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonInheritance.Name = "radioButtonInheritance";
            this.radioButtonInheritance.Size = new System.Drawing.Size(193, 36);
            this.radioButtonInheritance.TabIndex = 2;
            this.radioButtonInheritance.Text = "Inheritance";
            this.radioButtonInheritance.UseVisualStyleBackColor = true;
            this.radioButtonInheritance.CheckedChanged += new System.EventHandler(this.RadioButtonInheritance_CheckedChanged);
            // 
            // radioButtonAggregation
            // 
            this.radioButtonAggregation.AutoSize = true;
            this.radioButtonAggregation.Location = new System.Drawing.Point(171, 138);
            this.radioButtonAggregation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonAggregation.Name = "radioButtonAggregation";
            this.radioButtonAggregation.Size = new System.Drawing.Size(207, 36);
            this.radioButtonAggregation.TabIndex = 3;
            this.radioButtonAggregation.Text = "Aggregation";
            this.radioButtonAggregation.UseVisualStyleBackColor = true;
            this.radioButtonAggregation.CheckedChanged += new System.EventHandler(this.RadioButtonAggregation_CheckedChanged);
            // 
            // radioButtonСomposition
            // 
            this.radioButtonСomposition.AutoSize = true;
            this.radioButtonСomposition.Location = new System.Drawing.Point(171, 193);
            this.radioButtonСomposition.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonСomposition.Name = "radioButtonСomposition";
            this.radioButtonСomposition.Size = new System.Drawing.Size(211, 36);
            this.radioButtonСomposition.TabIndex = 4;
            this.radioButtonСomposition.Text = "Сomposition";
            this.radioButtonСomposition.UseVisualStyleBackColor = true;
            this.radioButtonСomposition.CheckedChanged += new System.EventHandler(this.RadioButtonСomposition_CheckedChanged);
            // 
            // radioButtonImplementation
            // 
            this.radioButtonImplementation.AutoSize = true;
            this.radioButtonImplementation.Location = new System.Drawing.Point(171, 246);
            this.radioButtonImplementation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonImplementation.Name = "radioButtonImplementation";
            this.radioButtonImplementation.Size = new System.Drawing.Size(247, 36);
            this.radioButtonImplementation.TabIndex = 5;
            this.radioButtonImplementation.Text = "Implementation";
            this.radioButtonImplementation.UseVisualStyleBackColor = true;
            this.radioButtonImplementation.CheckedChanged += new System.EventHandler(this.RadioButtonImplementation_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(128, 947);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(408, 114);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_5;
            this.pictureBox6.Location = new System.Drawing.Point(21, 143);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(123, 38);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_6;
            this.pictureBox5.Location = new System.Drawing.Point(21, 193);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(123, 38);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_3;
            this.pictureBox4.Location = new System.Drawing.Point(21, 248);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 38);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_2;
            this.pictureBox3.Location = new System.Drawing.Point(21, 91);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 38);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UMLLizardSoft.Properties.Resources.Screenshot_1__2_;
            this.pictureBox2.Location = new System.Drawing.Point(21, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 38);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(565, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3840, 2160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // buttonColorPalette
            // 
            this.buttonColorPalette.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonColorPalette.Location = new System.Drawing.Point(13, 930);
            this.buttonColorPalette.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonColorPalette.Name = "buttonColorPalette";
            this.buttonColorPalette.Size = new System.Drawing.Size(101, 100);
            this.buttonColorPalette.TabIndex = 11;
            this.buttonColorPalette.UseVisualStyleBackColor = false;
            this.buttonColorPalette.Click += new System.EventHandler(this.ButtonColorPalette_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(11, 849);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(523, 69);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // radioButtonRectangle1
            // 
            this.radioButtonRectangle1.AutoSize = true;
            this.radioButtonRectangle1.Checked = true;
            this.radioButtonRectangle1.Location = new System.Drawing.Point(171, 343);
            this.radioButtonRectangle1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonRectangle1.Name = "radioButtonRectangle1";
            this.radioButtonRectangle1.Size = new System.Drawing.Size(123, 36);
            this.radioButtonRectangle1.TabIndex = 14;
            this.radioButtonRectangle1.TabStop = true;
            this.radioButtonRectangle1.Text = "Class";
            this.radioButtonRectangle1.UseVisualStyleBackColor = true;
            this.radioButtonRectangle1.CheckedChanged += new System.EventHandler(this.RadioButtonRectangle1_CheckedChanged);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(11, 680);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(523, 69);
            this.buttonMove.TabIndex = 15;
            this.buttonMove.Text = "Select/Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonStepBack
            // 
            this.buttonStepBack.Location = new System.Drawing.Point(11, 763);
            this.buttonStepBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonStepBack.Name = "buttonStepBack";
            this.buttonStepBack.Size = new System.Drawing.Size(523, 69);
            this.buttonStepBack.TabIndex = 16;
            this.buttonStepBack.Text = "Step back";
            this.buttonStepBack.UseVisualStyleBackColor = true;
            this.buttonStepBack.Click += new System.EventHandler(this.ButtonStepBack_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(21, 343);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(123, 112);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // radioButtonRectangleStack
            // 
            this.radioButtonRectangleStack.AutoSize = true;
            this.radioButtonRectangleStack.Location = new System.Drawing.Point(171, 415);
            this.radioButtonRectangleStack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonRectangleStack.Name = "radioButtonRectangleStack";
            this.radioButtonRectangleStack.Size = new System.Drawing.Size(194, 36);
            this.radioButtonRectangleStack.TabIndex = 19;
            this.radioButtonRectangleStack.TabStop = true;
            this.radioButtonRectangleStack.Text = "ClassStack";
            this.radioButtonRectangleStack.UseVisualStyleBackColor = true;
            this.radioButtonRectangleStack.CheckedChanged += new System.EventHandler(this.RadioButtonRectangleStack_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 503);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 78);
            this.textBox1.TabIndex = 20;
            // 
            // buttonClas
            // 
            this.buttonClas.Location = new System.Drawing.Point(11, 596);
            this.buttonClas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonClas.Name = "buttonClas";
            this.buttonClas.Size = new System.Drawing.Size(149, 69);
            this.buttonClas.TabIndex = 25;
            this.buttonClas.Text = "Class";
            this.buttonClas.UseVisualStyleBackColor = true;
            this.buttonClas.Click += new System.EventHandler(this.ButtonClass_Click);
            // 
            // buttonFild
            // 
            this.buttonFild.Location = new System.Drawing.Point(200, 596);
            this.buttonFild.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFild.Name = "buttonFild";
            this.buttonFild.Size = new System.Drawing.Size(149, 69);
            this.buttonFild.TabIndex = 26;
            this.buttonFild.Text = "Fields";
            this.buttonFild.UseVisualStyleBackColor = true;
            this.buttonFild.Click += new System.EventHandler(this.ButtonField_Click);
            // 
            // buttonMetod
            // 
            this.buttonMetod.Location = new System.Drawing.Point(384, 596);
            this.buttonMetod.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonMetod.Name = "buttonMetod";
            this.buttonMetod.Size = new System.Drawing.Size(149, 69);
            this.buttonMetod.TabIndex = 27;
            this.buttonMetod.Text = "Methods";
            this.buttonMetod.UseVisualStyleBackColor = true;
            this.buttonMetod.Click += new System.EventHandler(this.ButtonMethod_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 1068);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 69);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(408, 1068);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(125, 69);
            this.buttonOpen.TabIndex = 29;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSaveAsImage
            // 
            this.buttonSaveAsImage.Location = new System.Drawing.Point(161, 1068);
            this.buttonSaveAsImage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSaveAsImage.Name = "buttonSaveAsImage";
            this.buttonSaveAsImage.Size = new System.Drawing.Size(231, 69);
            this.buttonSaveAsImage.TabIndex = 30;
            this.buttonSaveAsImage.Text = "Save as image";
            this.buttonSaveAsImage.UseVisualStyleBackColor = true;
            this.buttonSaveAsImage.Click += new System.EventHandler(this.ButtonSaveAsImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(3419, 1345);
            this.Controls.Add(this.buttonSaveAsImage);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonMetod);
            this.Controls.Add(this.buttonFild);
            this.Controls.Add(this.buttonClas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonRectangleStack);
            this.Controls.Add(this.pictureBox7);
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
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "UML Diagram LizardSoft";
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
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.RadioButton radioButtonRectangleStack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClas;
        private System.Windows.Forms.Button buttonFild;
        private System.Windows.Forms.Button buttonMetod;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSaveAsImage;
    }
}

