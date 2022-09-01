namespace UI_MachineLearning
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.PredictButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.desc_class = new System.Windows.Forms.Label();
            this.class_label = new System.Windows.Forms.Label();
            this.desc_triangle = new System.Windows.Forms.Label();
            this.desc_rectangle = new System.Windows.Forms.Label();
            this.triangle_accuracy = new System.Windows.Forms.Label();
            this.rectangle_accuracy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(68, 887);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(253, 95);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // PredictButton
            // 
            this.PredictButton.Location = new System.Drawing.Point(475, 891);
            this.PredictButton.Name = "PredictButton";
            this.PredictButton.Size = new System.Drawing.Size(237, 86);
            this.PredictButton.TabIndex = 1;
            this.PredictButton.Text = "Predict";
            this.PredictButton.UseVisualStyleBackColor = true;
            this.PredictButton.Click += new System.EventHandler(this.PredictButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(81, 24);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(935, 830);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // desc_class
            // 
            this.desc_class.AutoSize = true;
            this.desc_class.Location = new System.Drawing.Point(1096, 84);
            this.desc_class.Name = "desc_class";
            this.desc_class.Size = new System.Drawing.Size(288, 41);
            this.desc_class.TabIndex = 3;
            this.desc_class.Text = "Belongs to the class:";
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Location = new System.Drawing.Point(1489, 84);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(157, 41);
            this.class_label.TabIndex = 4;
            this.class_label.Text = "Undefined";
            // 
            // desc_triangle
            // 
            this.desc_triangle.AutoSize = true;
            this.desc_triangle.Location = new System.Drawing.Point(1096, 163);
            this.desc_triangle.Name = "desc_triangle";
            this.desc_triangle.Size = new System.Drawing.Size(320, 41);
            this.desc_triangle.TabIndex = 5;
            this.desc_triangle.Text = "Triangle class accuracy:";
            // 
            // desc_rectangle
            // 
            this.desc_rectangle.AutoSize = true;
            this.desc_rectangle.Location = new System.Drawing.Point(1096, 238);
            this.desc_rectangle.Name = "desc_rectangle";
            this.desc_rectangle.Size = new System.Drawing.Size(347, 41);
            this.desc_rectangle.TabIndex = 6;
            this.desc_rectangle.Text = "Rectangle class accuracy:";
            // 
            // triangle_accuracy
            // 
            this.triangle_accuracy.AutoSize = true;
            this.triangle_accuracy.Location = new System.Drawing.Point(1489, 163);
            this.triangle_accuracy.Name = "triangle_accuracy";
            this.triangle_accuracy.Size = new System.Drawing.Size(157, 41);
            this.triangle_accuracy.TabIndex = 7;
            this.triangle_accuracy.Text = "Undefined";
            // 
            // rectangle_accuracy
            // 
            this.rectangle_accuracy.AutoSize = true;
            this.rectangle_accuracy.Location = new System.Drawing.Point(1489, 238);
            this.rectangle_accuracy.Name = "rectangle_accuracy";
            this.rectangle_accuracy.Size = new System.Drawing.Size(157, 41);
            this.rectangle_accuracy.TabIndex = 8;
            this.rectangle_accuracy.Text = "Undefined";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 1029);
            this.Controls.Add(this.rectangle_accuracy);
            this.Controls.Add(this.triangle_accuracy);
            this.Controls.Add(this.desc_rectangle);
            this.Controls.Add(this.desc_triangle);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.desc_class);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PredictButton);
            this.Controls.Add(this.LoadImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button PredictButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label desc_class;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.Label desc_triangle;
        private System.Windows.Forms.Label desc_rectangle;
        private System.Windows.Forms.Label triangle_accuracy;
        private System.Windows.Forms.Label rectangle_accuracy;
    }
}
