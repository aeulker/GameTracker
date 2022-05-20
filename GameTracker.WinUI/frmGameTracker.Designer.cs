namespace GameTracker.WinUI
{
    partial class frmGameTracker
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
            this.grpCurrentContainer = new System.Windows.Forms.GroupBox();
            this.lbxTags = new System.Windows.Forms.ListBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.cbxCurrentState = new System.Windows.Forms.ComboBox();
            this.grpCondition = new System.Windows.Forms.GroupBox();
            this.lblConditionValue = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblConditionType = new System.Windows.Forms.Label();
            this.txtConditionValue = new System.Windows.Forms.TextBox();
            this.cbxCondition = new System.Windows.Forms.ComboBox();
            this.cbxConditionTypes = new System.Windows.Forms.ComboBox();
            this.grpCameraCommand = new System.Windows.Forms.GroupBox();
            this.lblCameraCommandValue = new System.Windows.Forms.Label();
            this.txtCameraCommandValue = new System.Windows.Forms.TextBox();
            this.cbxCameraCommandParameter = new System.Windows.Forms.ComboBox();
            this.lblCameraParameter = new System.Windows.Forms.Label();
            this.lblCameraCommand = new System.Windows.Forms.Label();
            this.cbxCameraCommand = new System.Windows.Forms.ComboBox();
            this.dgvAssigned = new System.Windows.Forms.DataGridView();
            this.btnAssign = new System.Windows.Forms.Button();
            this.gbxCurrentGameImage = new System.Windows.Forms.GroupBox();
            this.pbxCurrentGameImage = new System.Windows.Forms.PictureBox();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.grpSelectContainer = new System.Windows.Forms.GroupBox();
            this.CurrentState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpCurrentContainer.SuspendLayout();
            this.grpCondition.SuspendLayout();
            this.grpCameraCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigned)).BeginInit();
            this.gbxCurrentGameImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentGameImage)).BeginInit();
            this.pnlMainContainer.SuspendLayout();
            this.grpSelectContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCurrentContainer
            // 
            this.grpCurrentContainer.Controls.Add(this.lbxTags);
            this.grpCurrentContainer.Controls.Add(this.lblTags);
            this.grpCurrentContainer.Controls.Add(this.lblCurrentState);
            this.grpCurrentContainer.Controls.Add(this.cbxCurrentState);
            this.grpCurrentContainer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCurrentContainer.Location = new System.Drawing.Point(12, 309);
            this.grpCurrentContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCurrentContainer.Name = "grpCurrentContainer";
            this.grpCurrentContainer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCurrentContainer.Size = new System.Drawing.Size(439, 280);
            this.grpCurrentContainer.TabIndex = 0;
            this.grpCurrentContainer.TabStop = false;
            this.grpCurrentContainer.Text = "Current";
            // 
            // lbxTags
            // 
            this.lbxTags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTags.FormattingEnabled = true;
            this.lbxTags.ItemHeight = 16;
            this.lbxTags.Location = new System.Drawing.Point(129, 50);
            this.lbxTags.Name = "lbxTags";
            this.lbxTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxTags.Size = new System.Drawing.Size(300, 212);
            this.lbxTags.TabIndex = 6;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(6, 50);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 16);
            this.lblTags.TabIndex = 5;
            this.lblTags.Text = "Tags";
            // 
            // cbxState
            // 
            this.cbxState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(142, 19);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(300, 24);
            this.cbxState.TabIndex = 4;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(25, 22);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 16);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State";
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentState.Location = new System.Drawing.Point(6, 22);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(38, 16);
            this.lblCurrentState.TabIndex = 2;
            this.lblCurrentState.Text = "State";
            // 
            // cbxCurrentState
            // 
            this.cbxCurrentState.BackColor = System.Drawing.Color.White;
            this.cbxCurrentState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCurrentState.FormattingEnabled = true;
            this.cbxCurrentState.Location = new System.Drawing.Point(129, 18);
            this.cbxCurrentState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCurrentState.Name = "cbxCurrentState";
            this.cbxCurrentState.Size = new System.Drawing.Size(300, 24);
            this.cbxCurrentState.TabIndex = 0;
            // 
            // grpCondition
            // 
            this.grpCondition.Controls.Add(this.lblConditionValue);
            this.grpCondition.Controls.Add(this.lblCondition);
            this.grpCondition.Controls.Add(this.lblConditionType);
            this.grpCondition.Controls.Add(this.txtConditionValue);
            this.grpCondition.Controls.Add(this.cbxCondition);
            this.grpCondition.Controls.Add(this.cbxConditionTypes);
            this.grpCondition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCondition.Location = new System.Drawing.Point(5, 45);
            this.grpCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCondition.Name = "grpCondition";
            this.grpCondition.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCondition.Size = new System.Drawing.Size(443, 112);
            this.grpCondition.TabIndex = 1;
            this.grpCondition.TabStop = false;
            this.grpCondition.Text = "Conditions";
            // 
            // lblConditionValue
            // 
            this.lblConditionValue.AutoSize = true;
            this.lblConditionValue.Location = new System.Drawing.Point(18, 82);
            this.lblConditionValue.Name = "lblConditionValue";
            this.lblConditionValue.Size = new System.Drawing.Size(97, 16);
            this.lblConditionValue.TabIndex = 6;
            this.lblConditionValue.Text = "Condition Value";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(18, 53);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(61, 16);
            this.lblCondition.TabIndex = 5;
            this.lblCondition.Text = "Condition";
            // 
            // lblConditionType
            // 
            this.lblConditionType.AutoSize = true;
            this.lblConditionType.Location = new System.Drawing.Point(18, 27);
            this.lblConditionType.Name = "lblConditionType";
            this.lblConditionType.Size = new System.Drawing.Size(34, 16);
            this.lblConditionType.TabIndex = 4;
            this.lblConditionType.Text = "Type";
            // 
            // txtConditionValue
            // 
            this.txtConditionValue.Location = new System.Drawing.Point(137, 82);
            this.txtConditionValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConditionValue.Name = "txtConditionValue";
            this.txtConditionValue.Size = new System.Drawing.Size(300, 22);
            this.txtConditionValue.TabIndex = 3;
            // 
            // cbxCondition
            // 
            this.cbxCondition.FormattingEnabled = true;
            this.cbxCondition.Location = new System.Drawing.Point(137, 50);
            this.cbxCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(300, 24);
            this.cbxCondition.TabIndex = 2;
            // 
            // cbxConditionTypes
            // 
            this.cbxConditionTypes.FormattingEnabled = true;
            this.cbxConditionTypes.Location = new System.Drawing.Point(138, 19);
            this.cbxConditionTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxConditionTypes.Name = "cbxConditionTypes";
            this.cbxConditionTypes.Size = new System.Drawing.Size(300, 24);
            this.cbxConditionTypes.TabIndex = 1;
            // 
            // grpCameraCommand
            // 
            this.grpCameraCommand.Controls.Add(this.lblCameraCommandValue);
            this.grpCameraCommand.Controls.Add(this.txtCameraCommandValue);
            this.grpCameraCommand.Controls.Add(this.cbxCameraCommandParameter);
            this.grpCameraCommand.Controls.Add(this.lblCameraParameter);
            this.grpCameraCommand.Controls.Add(this.lblCameraCommand);
            this.grpCameraCommand.Controls.Add(this.cbxCameraCommand);
            this.grpCameraCommand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCameraCommand.Location = new System.Drawing.Point(5, 157);
            this.grpCameraCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCameraCommand.Name = "grpCameraCommand";
            this.grpCameraCommand.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCameraCommand.Size = new System.Drawing.Size(443, 117);
            this.grpCameraCommand.TabIndex = 2;
            this.grpCameraCommand.TabStop = false;
            this.grpCameraCommand.Text = "Camera Commands";
            // 
            // lblCameraCommandValue
            // 
            this.lblCameraCommandValue.AutoSize = true;
            this.lblCameraCommandValue.Location = new System.Drawing.Point(19, 90);
            this.lblCameraCommandValue.Name = "lblCameraCommandValue";
            this.lblCameraCommandValue.Size = new System.Drawing.Size(102, 16);
            this.lblCameraCommandValue.TabIndex = 8;
            this.lblCameraCommandValue.Text = "Command Value";
            // 
            // txtCameraCommandValue
            // 
            this.txtCameraCommandValue.Location = new System.Drawing.Point(138, 87);
            this.txtCameraCommandValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCameraCommandValue.Name = "txtCameraCommandValue";
            this.txtCameraCommandValue.Size = new System.Drawing.Size(300, 22);
            this.txtCameraCommandValue.TabIndex = 7;
            // 
            // cbxCameraCommandParameter
            // 
            this.cbxCameraCommandParameter.FormattingEnabled = true;
            this.cbxCameraCommandParameter.Location = new System.Drawing.Point(137, 55);
            this.cbxCameraCommandParameter.Name = "cbxCameraCommandParameter";
            this.cbxCameraCommandParameter.Size = new System.Drawing.Size(300, 24);
            this.cbxCameraCommandParameter.TabIndex = 4;
            // 
            // lblCameraParameter
            // 
            this.lblCameraParameter.AutoSize = true;
            this.lblCameraParameter.Location = new System.Drawing.Point(19, 58);
            this.lblCameraParameter.Name = "lblCameraParameter";
            this.lblCameraParameter.Size = new System.Drawing.Size(67, 16);
            this.lblCameraParameter.TabIndex = 2;
            this.lblCameraParameter.Text = "Parameter";
            // 
            // lblCameraCommand
            // 
            this.lblCameraCommand.AutoSize = true;
            this.lblCameraCommand.Location = new System.Drawing.Point(18, 26);
            this.lblCameraCommand.Name = "lblCameraCommand";
            this.lblCameraCommand.Size = new System.Drawing.Size(66, 16);
            this.lblCameraCommand.TabIndex = 1;
            this.lblCameraCommand.Text = "Command";
            // 
            // cbxCameraCommand
            // 
            this.cbxCameraCommand.FormattingEnabled = true;
            this.cbxCameraCommand.Location = new System.Drawing.Point(138, 23);
            this.cbxCameraCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCameraCommand.Name = "cbxCameraCommand";
            this.cbxCameraCommand.Size = new System.Drawing.Size(300, 24);
            this.cbxCameraCommand.TabIndex = 0;
            // 
            // dgvAssigned
            // 
            this.dgvAssigned.AllowUserToAddRows = false;
            this.dgvAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrentState,
            this.SelectState,
            this.Tags,
            this.Condition,
            this.CameraCommand,
            this.Delete});
            this.dgvAssigned.Location = new System.Drawing.Point(8, 636);
            this.dgvAssigned.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAssigned.Name = "dgvAssigned";
            this.dgvAssigned.ReadOnly = true;
            this.dgvAssigned.Size = new System.Drawing.Size(910, 289);
            this.dgvAssigned.TabIndex = 3;
            this.dgvAssigned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssigned_CellClick);
            this.dgvAssigned.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAssigned_CellFormatting);
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(398, 597);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(102, 35);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // gbxCurrentGameImage
            // 
            this.gbxCurrentGameImage.Controls.Add(this.pbxCurrentGameImage);
            this.gbxCurrentGameImage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCurrentGameImage.Location = new System.Drawing.Point(14, 15);
            this.gbxCurrentGameImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCurrentGameImage.Name = "gbxCurrentGameImage";
            this.gbxCurrentGameImage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCurrentGameImage.Size = new System.Drawing.Size(896, 290);
            this.gbxCurrentGameImage.TabIndex = 6;
            this.gbxCurrentGameImage.TabStop = false;
            this.gbxCurrentGameImage.Text = "Current Game Image";
            // 
            // pbxCurrentGameImage
            // 
            this.pbxCurrentGameImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxCurrentGameImage.Location = new System.Drawing.Point(3, 19);
            this.pbxCurrentGameImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxCurrentGameImage.Name = "pbxCurrentGameImage";
            this.pbxCurrentGameImage.Size = new System.Drawing.Size(890, 267);
            this.pbxCurrentGameImage.TabIndex = 5;
            this.pbxCurrentGameImage.TabStop = false;
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.grpSelectContainer);
            this.pnlMainContainer.Controls.Add(this.grpCurrentContainer);
            this.pnlMainContainer.Controls.Add(this.btnAssign);
            this.pnlMainContainer.Controls.Add(this.dgvAssigned);
            this.pnlMainContainer.Controls.Add(this.gbxCurrentGameImage);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(927, 929);
            this.pnlMainContainer.TabIndex = 7;
            // 
            // grpSelectContainer
            // 
            this.grpSelectContainer.Controls.Add(this.grpCameraCommand);
            this.grpSelectContainer.Controls.Add(this.grpCondition);
            this.grpSelectContainer.Controls.Add(this.cbxState);
            this.grpSelectContainer.Controls.Add(this.lblState);
            this.grpSelectContainer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectContainer.Location = new System.Drawing.Point(462, 309);
            this.grpSelectContainer.Name = "grpSelectContainer";
            this.grpSelectContainer.Size = new System.Drawing.Size(450, 280);
            this.grpSelectContainer.TabIndex = 7;
            this.grpSelectContainer.TabStop = false;
            this.grpSelectContainer.Text = "Select";
            // 
            // CurrentState
            // 
            this.CurrentState.HeaderText = "Current State";
            this.CurrentState.MinimumWidth = 125;
            this.CurrentState.Name = "CurrentState";
            this.CurrentState.ReadOnly = true;
            this.CurrentState.Width = 125;
            // 
            // SelectState
            // 
            this.SelectState.HeaderText = "Selected State";
            this.SelectState.MinimumWidth = 125;
            this.SelectState.Name = "SelectState";
            this.SelectState.ReadOnly = true;
            this.SelectState.Width = 125;
            // 
            // Tags
            // 
            this.Tags.HeaderText = "Tags";
            this.Tags.MinimumWidth = 125;
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            this.Tags.Width = 125;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Condition";
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            this.Condition.Width = 200;
            // 
            // CameraCommand
            // 
            this.CameraCommand.HeaderText = "CameraCommand";
            this.CameraCommand.Name = "CameraCommand";
            this.CameraCommand.ReadOnly = true;
            this.CameraCommand.Width = 200;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // frmGameTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 929);
            this.Controls.Add(this.pnlMainContainer);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmGameTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Tracker";
            this.Load += new System.EventHandler(this.frmGameTracker_Load);
            this.grpCurrentContainer.ResumeLayout(false);
            this.grpCurrentContainer.PerformLayout();
            this.grpCondition.ResumeLayout(false);
            this.grpCondition.PerformLayout();
            this.grpCameraCommand.ResumeLayout(false);
            this.grpCameraCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigned)).EndInit();
            this.gbxCurrentGameImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentGameImage)).EndInit();
            this.pnlMainContainer.ResumeLayout(false);
            this.grpSelectContainer.ResumeLayout(false);
            this.grpSelectContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCurrentContainer;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.ComboBox cbxCurrentState;
        private System.Windows.Forms.GroupBox grpCondition;
        private System.Windows.Forms.Label lblConditionValue;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblConditionType;
        private System.Windows.Forms.TextBox txtConditionValue;
        private System.Windows.Forms.ComboBox cbxCondition;
        private System.Windows.Forms.ComboBox cbxConditionTypes;
        private System.Windows.Forms.GroupBox grpCameraCommand;
        private System.Windows.Forms.Label lblCameraCommand;
        private System.Windows.Forms.ComboBox cbxCameraCommand;
        private System.Windows.Forms.DataGridView dgvAssigned;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.PictureBox pbxCurrentGameImage;
        private System.Windows.Forms.GroupBox gbxCurrentGameImage;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label lblCameraParameter;
        private System.Windows.Forms.Label lblCameraCommandValue;
        private System.Windows.Forms.TextBox txtCameraCommandValue;
        private System.Windows.Forms.ComboBox cbxCameraCommandParameter;
        private System.Windows.Forms.ListBox lbxTags;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.GroupBox grpSelectContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentState;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraCommand;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

