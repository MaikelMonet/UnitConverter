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
            HeaderLabel = new Label();
            unitOutput = new TextBox();
            convertButton = new Button();
            conversionMethodDropDownBox = new ComboBox();
            SuspendLayout();
            // 
            // unitInput
            // 
            unitInput.AccessibleName = "";
            unitInput.Anchor = AnchorStyles.Top;
            unitInput.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitInput.Location = new Point(210, 236);
            unitInput.Name = "unitInput";
            unitInput.Size = new Size(124, 26);
            unitInput.TabIndex = 0;
            unitInput.Text = "Units";
            unitInput.WordWrap = false;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.Top;
            HeaderLabel.AutoSize = true;
            HeaderLabel.BackColor = Color.Transparent;
            HeaderLabel.Font = new Font("Segoe UI Black", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.ControlText;
            HeaderLabel.Location = new Point(210, 142);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(585, 37);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "How many units would you like to convert?";
            // 
            // unitOutput
            // 
            unitOutput.Anchor = AnchorStyles.Top;
            unitOutput.Location = new Point(671, 236);
            unitOutput.Name = "unitOutput";
            unitOutput.Size = new Size(124, 23);
            unitOutput.TabIndex = 3;
            // 
            // convertButton
            // 
            convertButton.Anchor = AnchorStyles.Top;
            convertButton.BackColor = SystemColors.Highlight;
            convertButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            convertButton.FlatAppearance.MouseDownBackColor = Color.Blue;
            convertButton.FlatAppearance.MouseOverBackColor = Color.Blue;
            convertButton.FlatStyle = FlatStyle.Popup;
            convertButton.Location = new Point(437, 265);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(149, 36);
            convertButton.TabIndex = 5;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // conversionMethodDropDownBox
            // 
            conversionMethodDropDownBox.AllowDrop = true;
            conversionMethodDropDownBox.Anchor = AnchorStyles.Top;
            conversionMethodDropDownBox.FormattingEnabled = true;
            conversionMethodDropDownBox.Location = new Point(383, 236);
            conversionMethodDropDownBox.Name = "conversionMethodDropDownBox";
            conversionMethodDropDownBox.Size = new Size(238, 23);
            conversionMethodDropDownBox.TabIndex = 2;
            // 
            // UnitConverterDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1022, 757);
            Controls.Add(convertButton);
            Controls.Add(unitOutput);
            Controls.Add(conversionMethodDropDownBox);
            Controls.Add(HeaderLabel);
            Controls.Add(unitInput);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "UnitConverterDashboard";
            Text = "Unit Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unitInput;
        private Label HeaderLabel;
        private TextBox unitOutput;
        private Button convertButton;
        private ComboBox conversionMethodDropDownBox;
    }
}
