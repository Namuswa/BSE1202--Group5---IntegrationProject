namespace HostelFinderPrototype
{
    partial class HostelDetailsForm
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
            this.lblHostelName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblAvialable = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHostelName
            // 
            this.lblHostelName.AutoSize = true;
            this.lblHostelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostelName.Location = new System.Drawing.Point(299, 9);
            this.lblHostelName.Name = "lblHostelName";
            this.lblHostelName.Size = new System.Drawing.Size(190, 31);
            this.lblHostelName.TabIndex = 0;
            this.lblHostelName.Text = "Hostel Name ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(40, 65);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(44, 16);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "label1";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(189, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "label2";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(358, 66);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(44, 16);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "label3";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(520, 66);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(44, 16);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "label4";
            // 
            // lblAvialable
            // 
            this.lblAvialable.AutoSize = true;
            this.lblAvialable.Location = new System.Drawing.Point(688, 66);
            this.lblAvialable.Name = "lblAvialable";
            this.lblAvialable.Size = new System.Drawing.Size(44, 16);
            this.lblAvialable.TabIndex = 5;
            this.lblAvialable.Text = "label5";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(43, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(584, 341);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(148, 23);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Proceed to Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // HostelDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAvialable);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHostelName);
            this.Name = "HostelDetailsForm";
            this.Text = "HostelDetailsForm";
            this.Load += new System.EventHandler(this.HostelDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHostelName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblAvialable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPayment;
    }
}