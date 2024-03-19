namespace EFHotelBooking.Forms.Room
{
    partial class AddRoomForm
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
            txtName = new TextBox();
            label1 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtCapacity = new TextBox();
            label4 = new Label();
            btnAddRoom = new Button();
            dtGridRooms = new DataGridView();
            lblOdalar = new Label();
            button1 = new Button();
            txtMin = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtMax = new TextBox();
            btnFilter = new Button();
            label7 = new Label();
            lblTotal = new Label();
            radioButton1 = new RadioButton();
            radioIsAvailable = new RadioButton();
            radioIsNotAvailable = new RadioButton();
            radioAll = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtGridRooms).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(207, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(207, 123);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 129);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(517, 59);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 65);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 1;
            label3.Text = "Price:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(517, 118);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(150, 31);
            txtCapacity.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 124);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 1;
            label4.Text = "Capacity:";
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(555, 181);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(112, 34);
            btnAddRoom.TabIndex = 2;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // dtGridRooms
            // 
            dtGridRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridRooms.Location = new Point(207, 612);
            dtGridRooms.Name = "dtGridRooms";
            dtGridRooms.RowHeadersWidth = 62;
            dtGridRooms.Size = new Size(1077, 321);
            dtGridRooms.TabIndex = 3;
            // 
            // lblOdalar
            // 
            lblOdalar.AutoSize = true;
            lblOdalar.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblOdalar.ForeColor = SystemColors.ControlText;
            lblOdalar.Location = new Point(753, 320);
            lblOdalar.Name = "lblOdalar";
            lblOdalar.Size = new Size(149, 54);
            lblOdalar.TabIndex = 4;
            lblOdalar.Text = "Odalar";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(207, 960);
            button1.Name = "button1";
            button1.Size = new Size(130, 64);
            button1.TabIndex = 5;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(270, 421);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(150, 31);
            txtMin.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 427);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 7;
            label5.Text = "Min:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 427);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 9;
            label6.Text = "Max:";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(517, 421);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(150, 31);
            txtMax.TabIndex = 8;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(698, 418);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 498);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 11;
            label7.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(266, 498);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "0";
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(0, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 0;
            // 
            // radioIsAvailable
            // 
            radioIsAvailable.AutoSize = true;
            radioIsAvailable.Location = new Point(294, 556);
            radioIsAvailable.Name = "radioIsAvailable";
            radioIsAvailable.Size = new Size(126, 29);
            radioIsAvailable.TabIndex = 13;
            radioIsAvailable.Text = "Is Available";
            radioIsAvailable.UseVisualStyleBackColor = true;
            radioIsAvailable.CheckedChanged += radioIsAvailable_CheckedChanged;
            // 
            // radioIsNotAvailable
            // 
            radioIsNotAvailable.AutoSize = true;
            radioIsNotAvailable.Location = new Point(443, 556);
            radioIsNotAvailable.Name = "radioIsNotAvailable";
            radioIsNotAvailable.Size = new Size(161, 29);
            radioIsNotAvailable.TabIndex = 13;
            radioIsNotAvailable.Text = "Is Not Available";
            radioIsNotAvailable.UseVisualStyleBackColor = true;
            radioIsNotAvailable.CheckedChanged += radioIsNotAvailable_CheckedChanged;
            // 
            // radioAll
            // 
            radioAll.AutoSize = true;
            radioAll.Checked = true;
            radioAll.Location = new Point(211, 556);
            radioAll.Name = "radioAll";
            radioAll.Size = new Size(57, 29);
            radioAll.TabIndex = 13;
            radioAll.TabStop = true;
            radioAll.Text = "All";
            radioAll.UseVisualStyleBackColor = true;
            radioAll.CheckedChanged += radioAll_CheckedChanged;
            // 
            // AddRoomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 1050);
            Controls.Add(radioIsNotAvailable);
            Controls.Add(radioAll);
            Controls.Add(radioIsAvailable);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(btnFilter);
            Controls.Add(label6);
            Controls.Add(txtMax);
            Controls.Add(label5);
            Controls.Add(txtMin);
            Controls.Add(button1);
            Controls.Add(lblOdalar);
            Controls.Add(dtGridRooms);
            Controls.Add(btnAddRoom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCapacity);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "AddRoomForm";
            Text = "AddRoomForm";
            Load += AddRoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtCapacity;
        private Label label4;
        private Button btnAddRoom;
        private DataGridView dtGridRooms;
        private Label lblOdalar;
        private Button button1;
        private TextBox txtMin;
        private Label label5;
        private Label label6;
        private TextBox txtMax;
        private Button btnFilter;
        private Label label7;
        private Label lblTotal;
        private CheckBox chckIsAvailable;
        private RadioButton radioButton1;
        private RadioButton radioIsAvailable;
        private RadioButton radioIsNotAvailable;
        private RadioButton radioAll;
    }
}