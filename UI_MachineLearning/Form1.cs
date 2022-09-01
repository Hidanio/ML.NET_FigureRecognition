using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace UI_MachineLearning
{
    public partial class Form1 : Form
    {
        private string ImagePath { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            ImagePath = openFile.FileName;
            PictureBox.Image = Image.FromFile(ImagePath);
        }

        private void PredictButton_Click(object sender, EventArgs e)
        {
            var sampleData = new MachineModel.ModelInput()
            {
                ImageSource = ImagePath
            };

            //Load model and predict output
            var result = MachineModel.Predict(sampleData);

            class_label.Text = result.Prediction;
            triangle_accuracy.Text = result.Score[1].ToString(CultureInfo.CurrentCulture);
            rectangle_accuracy.Text = result.Score[0].ToString(CultureInfo.CurrentCulture);
        }
    }
}
