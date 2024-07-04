namespace WinFormUI
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
            messageBoxDemoButton = new Button();
            textBoxDemo_Button = new Button();
            subTotalTextBox = new TextBox();
            totalTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // messageBoxDemoButton
            // 
            messageBoxDemoButton.Location = new Point(193, 285);
            messageBoxDemoButton.Name = "messageBoxDemoButton";
            messageBoxDemoButton.Size = new Size(194, 117);
            messageBoxDemoButton.TabIndex = 0;
            messageBoxDemoButton.Text = "MesssageBox Demo";
            messageBoxDemoButton.UseVisualStyleBackColor = true;
            messageBoxDemoButton.Click += messageBoxDemoButton_Click;
            // 
            // textBoxDemo_Button
            // 
            textBoxDemo_Button.Location = new Point(493, 285);
            textBoxDemo_Button.Name = "textBoxDemo_Button";
            textBoxDemo_Button.Size = new Size(194, 117);
            textBoxDemo_Button.TabIndex = 1;
            textBoxDemo_Button.Text = "TextBox Demo";
            textBoxDemo_Button.UseVisualStyleBackColor = true;
            textBoxDemo_Button.Click += textBoxDemoButton_Click;
            // 
            // subTotalTextBox
            // 
            subTotalTextBox.Location = new Point(493, 73);
            subTotalTextBox.Name = "subTotalTextBox";
            subTotalTextBox.Size = new Size(210, 23);
            subTotalTextBox.TabIndex = 2;
            // 
            // totalTextBox
            // 
            totalTextBox.Location = new Point(493, 149);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(210, 23);
            totalTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(493, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 131);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(totalTextBox);
            Controls.Add(subTotalTextBox);
            Controls.Add(textBoxDemo_Button);
            Controls.Add(messageBoxDemoButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button messageBoxDemoButton;
        private Button textBoxDemo_Button;
        private TextBox subTotalTextBox;
        private TextBox totalTextBox;
        private Label label1;
        private Label label2;
    }
}
