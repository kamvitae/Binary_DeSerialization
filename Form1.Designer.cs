namespace HF_9_4_Binary_De_Serialization
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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnSerializeMany = new System.Windows.Forms.Button();
            this.btnDeserializeMany = new System.Windows.Forms.Button();
            this.btn3ofClubs = new System.Windows.Forms.Button();
            this.btn6ofHearts = new System.Windows.Forms.Button();
            this.btnReadBytes = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(37, 54);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(191, 54);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize.TabIndex = 1;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnSerializeMany
            // 
            this.btnSerializeMany.Location = new System.Drawing.Point(37, 139);
            this.btnSerializeMany.Name = "btnSerializeMany";
            this.btnSerializeMany.Size = new System.Drawing.Size(75, 52);
            this.btnSerializeMany.TabIndex = 2;
            this.btnSerializeMany.Text = "Serialize many";
            this.btnSerializeMany.UseVisualStyleBackColor = true;
            this.btnSerializeMany.Click += new System.EventHandler(this.btnSerializeMany_Click);
            // 
            // btnDeserializeMany
            // 
            this.btnDeserializeMany.Location = new System.Drawing.Point(191, 139);
            this.btnDeserializeMany.Name = "btnDeserializeMany";
            this.btnDeserializeMany.Size = new System.Drawing.Size(75, 52);
            this.btnDeserializeMany.TabIndex = 3;
            this.btnDeserializeMany.Text = "Deserialize many";
            this.btnDeserializeMany.UseVisualStyleBackColor = true;
            this.btnDeserializeMany.Click += new System.EventHandler(this.btnDeserializeMany_Click);
            // 
            // btn3ofClubs
            // 
            this.btn3ofClubs.Location = new System.Drawing.Point(12, 242);
            this.btn3ofClubs.Name = "btn3ofClubs";
            this.btn3ofClubs.Size = new System.Drawing.Size(75, 23);
            this.btn3ofClubs.TabIndex = 4;
            this.btn3ofClubs.Text = "3ofClubs";
            this.btn3ofClubs.UseVisualStyleBackColor = true;
            this.btn3ofClubs.Click += new System.EventHandler(this.btn3ofClubs_Click);
            // 
            // btn6ofHearts
            // 
            this.btn6ofHearts.Location = new System.Drawing.Point(12, 271);
            this.btn6ofHearts.Name = "btn6ofHearts";
            this.btn6ofHearts.Size = new System.Drawing.Size(75, 23);
            this.btn6ofHearts.TabIndex = 5;
            this.btn6ofHearts.Text = "6ofHearts";
            this.btn6ofHearts.UseVisualStyleBackColor = true;
            this.btn6ofHearts.Click += new System.EventHandler(this.btn6ofHearts_Click);
            // 
            // btnReadBytes
            // 
            this.btnReadBytes.Location = new System.Drawing.Point(93, 257);
            this.btnReadBytes.Name = "btnReadBytes";
            this.btnReadBytes.Size = new System.Drawing.Size(75, 23);
            this.btnReadBytes.TabIndex = 6;
            this.btnReadBytes.Text = "readBytes";
            this.btnReadBytes.UseVisualStyleBackColor = true;
            this.btnReadBytes.Click += new System.EventHandler(this.btnReadBytes_Click);
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(191, 334);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(75, 52);
            this.btnHex.TabIndex = 7;
            this.btnHex.Text = "hexDumper";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 438);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnReadBytes);
            this.Controls.Add(this.btn6ofHearts);
            this.Controls.Add(this.btn3ofClubs);
            this.Controls.Add(this.btnDeserializeMany);
            this.Controls.Add(this.btnSerializeMany);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnSerializeMany;
        private System.Windows.Forms.Button btnDeserializeMany;
        private System.Windows.Forms.Button btn3ofClubs;
        private System.Windows.Forms.Button btn6ofHearts;
        private System.Windows.Forms.Button btnReadBytes;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

