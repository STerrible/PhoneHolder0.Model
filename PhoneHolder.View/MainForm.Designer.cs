namespace PhoneHolder.View
{
    partial class MainForm
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
            textHeight = new TextBox();
            textTiltAngle = new TextBox();
            textBaseWidth = new TextBox();
            textHolderWidth = new TextBox();
            textClampWidth = new TextBox();
            buttonBuild = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textHeight
            // 
            textHeight.Location = new Point(364, 25);
            textHeight.Name = "textHeight";
            textHeight.Size = new Size(125, 27);
            textHeight.TabIndex = 0;
            textHeight.TextChanged += textHeight_TextChanged;
            // 
            // textTiltAngle
            // 
            textTiltAngle.Location = new Point(364, 94);
            textTiltAngle.Name = "textTiltAngle";
            textTiltAngle.Size = new Size(125, 27);
            textTiltAngle.TabIndex = 1;
            textTiltAngle.TextChanged += textTiltAngle_TextChanged;
            // 
            // textBaseWidth
            // 
            textBaseWidth.Location = new Point(364, 171);
            textBaseWidth.Name = "textBaseWidth";
            textBaseWidth.Size = new Size(125, 27);
            textBaseWidth.TabIndex = 2;
            textBaseWidth.TextChanged += textBaseWidth_TextChanged;
            // 
            // textHolderWidth
            // 
            textHolderWidth.Location = new Point(364, 258);
            textHolderWidth.Name = "textHolderWidth";
            textHolderWidth.Size = new Size(125, 27);
            textHolderWidth.TabIndex = 3;
            textHolderWidth.TextChanged += textHolderWidth_TextChanged;
            // 
            // textClampWidth
            // 
            textClampWidth.Location = new Point(364, 342);
            textClampWidth.Name = "textClampWidth";
            textClampWidth.Size = new Size(125, 27);
            textClampWidth.TabIndex = 4;
            textClampWidth.TextChanged += textClampWidth_TextChanged;
            // 
            // buttonBuild
            // 
            buttonBuild.Location = new Point(694, 409);
            buttonBuild.Name = "buttonBuild";
            buttonBuild.Size = new Size(94, 29);
            buttonBuild.TabIndex = 5;
            buttonBuild.Text = "Build!";
            buttonBuild.UseVisualStyleBackColor = true;
            buttonBuild.Click += btnBuild_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 6;
            label1.Text = "Высота держателя (50-150)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 94);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 7;
            label2.Text = "Угол наклона (0-90)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 171);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 8;
            label3.Text = "Ширина основания (30-100)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 265);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 9;
            label4.Text = "Ширина держателей (20-80)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 349);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 10;
            label5.Text = "Ширина зажима (10-50)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBuild);
            Controls.Add(textClampWidth);
            Controls.Add(textHolderWidth);
            Controls.Add(textBaseWidth);
            Controls.Add(textTiltAngle);
            Controls.Add(textHeight);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textHeight;
        private TextBox textTiltAngle;
        private TextBox textBaseWidth;
        private TextBox textHolderWidth;
        private TextBox textClampWidth;
        private Button buttonBuild;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}