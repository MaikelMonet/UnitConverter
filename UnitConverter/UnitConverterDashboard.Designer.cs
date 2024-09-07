using System.Runtime.CompilerServices;
using System.Drawing;

namespace UnitConverter
{
    partial class UnitConverterDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitConverterDashboard));
            unitInput = new TextBox();
            label1 = new Label();
            unitOutput = new TextBox();
            label2 = new Label();
            convertButton = new Button();
            conversionMethodDropDownBox = new ComboBox();
            SuspendLayout();
            // 
            // unitInput
            // 
            unitInput.AccessibleName = "";
            unitInput.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitInput.Location = new Point(54, 145);
            unitInput.Name = "unitInput";
            unitInput.Size = new Size(124, 26);
            unitInput.TabIndex = 0;
            unitInput.Text = "Units";
            unitInput.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(54, 51);
            label1.Name = "label1";
            label1.Size = new Size(585, 37);
            label1.TabIndex = 1;
            label1.Text = "How many units would you like to convert?";
            // 
            // unitOutput
            // 
            unitOutput.Location = new Point(515, 145);
            unitOutput.Name = "unitOutput";
            unitOutput.Size = new Size(124, 23);
            unitOutput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 7F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 284);
            label2.Name = "label2";
            label2.Size = new Size(259, 12);
            label2.TabIndex = 4;
            label2.Text = "psss....open the rest of the window for a cool picture ";
            // 
            // convertButton
            // 
            convertButton.BackColor = SystemColors.Highlight;
            convertButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            convertButton.FlatAppearance.MouseDownBackColor = Color.Blue;
            convertButton.FlatAppearance.MouseOverBackColor = Color.Blue;
            convertButton.FlatStyle = FlatStyle.Popup;
            convertButton.Location = new Point(281, 174);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(149, 36);
            convertButton.TabIndex = 5;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // conversionMethodDropDownBox
            // 
            conversionMethodDropDownBox.FormattingEnabled = true;
            conversionMethodDropDownBox.Location = new Point(227, 145);
            conversionMethodDropDownBox.Name = "conversionMethodDropDownBox";
            conversionMethodDropDownBox.Size = new Size(238, 23);
            conversionMethodDropDownBox.TabIndex = 2;
            // 
            // UnitConverterDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(683, 305);
            Controls.Add(convertButton);
            Controls.Add(label2);
            Controls.Add(unitOutput);
            Controls.Add(conversionMethodDropDownBox);
            Controls.Add(label1);
            Controls.Add(unitInput);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "UnitConverterDashboard";
            Text = "Unit Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unitInput;
        private Label label1;
        private TextBox unitOutput;
        private Label label2;
        private Button convertButton;
        private ComboBox conversionMethodDropDownBox;
    }
}
