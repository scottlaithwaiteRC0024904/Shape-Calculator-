namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sphere = new System.Windows.Forms.TabPage();
            this.Cone = new System.Windows.Forms.TabPage();
            this.Cylinder = new System.Windows.Forms.TabPage();
            this.Cube = new System.Windows.Forms.TabPage();
            this.Cuboid = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.Sphere.SuspendLayout();
            this.Cone.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sphere);
            this.tabControl1.Controls.Add(this.Cone);
            this.tabControl1.Controls.Add(this.Cylinder);
            this.tabControl1.Controls.Add(this.Cube);
            this.tabControl1.Controls.Add(this.Cuboid);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // Sphere
            // 
            this.Sphere.Controls.Add(this.label3);
            this.Sphere.Controls.Add(this.label2);
            this.Sphere.Controls.Add(this.label1);
            this.Sphere.Controls.Add(this.textBox1);
            this.Sphere.ImageKey = "Sphere.png";
            this.Sphere.Location = new System.Drawing.Point(4, 47);
            this.Sphere.Name = "Sphere";
            this.Sphere.Size = new System.Drawing.Size(909, 519);
            this.Sphere.TabIndex = 0;
            this.Sphere.Text = "Sphere";
            this.Sphere.UseVisualStyleBackColor = true;
            // 
            // Cone
            // 
            this.Cone.Controls.Add(this.label7);
            this.Cone.Controls.Add(this.textBox3);
            this.Cone.Controls.Add(this.label6);
            this.Cone.Controls.Add(this.label5);
            this.Cone.Controls.Add(this.textBox2);
            this.Cone.Controls.Add(this.label4);
            this.Cone.ImageIndex = 0;
            this.Cone.Location = new System.Drawing.Point(4, 47);
            this.Cone.Name = "Cone";
            this.Cone.Size = new System.Drawing.Size(909, 519);
            this.Cone.TabIndex = 1;
            this.Cone.Text = "Cone";
            this.Cone.UseVisualStyleBackColor = true;
            // 
            // Cylinder
            // 
            this.Cylinder.ImageKey = "Cylinder.png";
            this.Cylinder.Location = new System.Drawing.Point(4, 47);
            this.Cylinder.Name = "Cylinder";
            this.Cylinder.Size = new System.Drawing.Size(909, 519);
            this.Cylinder.TabIndex = 2;
            this.Cylinder.Text = "Cylinder";
            this.Cylinder.UseVisualStyleBackColor = true;
            // 
            // Cube
            // 
            this.Cube.ImageKey = "Cube.png";
            this.Cube.Location = new System.Drawing.Point(4, 47);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(909, 519);
            this.Cube.TabIndex = 3;
            this.Cube.Text = "Cube";
            this.Cube.UseVisualStyleBackColor = true;
            // 
            // Cuboid
            // 
            this.Cuboid.ImageKey = "Cuboid.png";
            this.Cuboid.Location = new System.Drawing.Point(4, 47);
            this.Cuboid.Name = "Cuboid";
            this.Cuboid.Size = new System.Drawing.Size(909, 519);
            this.Cuboid.TabIndex = 4;
            this.Cuboid.Text = "Cuboid";
            this.Cuboid.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "radius";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "height";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cone.png");
            this.imageList1.Images.SetKeyName(1, "Cube.png");
            this.imageList1.Images.SetKeyName(2, "Cuboid.png");
            this.imageList1.Images.SetKeyName(3, "Cylinder.png");
            this.imageList1.Images.SetKeyName(4, "Sphere.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Sphere.ResumeLayout(false);
            this.Sphere.PerformLayout();
            this.Cone.ResumeLayout(false);
            this.Cone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sphere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage Cone;
        private System.Windows.Forms.TabPage Cylinder;
        private System.Windows.Forms.TabPage Cube;
        private System.Windows.Forms.TabPage Cuboid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
    }
}

