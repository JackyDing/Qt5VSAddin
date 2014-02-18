﻿namespace Qt5VSAddin
{
    partial class FormProjectQtSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectQtSettings));
            this.OptionsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.quickLib = new System.Windows.Forms.CheckBox();
            this.qmlLib = new System.Windows.Forms.CheckBox();
            this.webKitLib = new System.Windows.Forms.CheckBox();
            this.multimediaLib = new System.Windows.Forms.CheckBox();
            this.networkLib = new System.Windows.Forms.CheckBox();
            this.coreLib = new System.Windows.Forms.CheckBox();
            this.threeDLib = new System.Windows.Forms.CheckBox();
            this.guiLib = new System.Windows.Forms.CheckBox();
            this.sqlLib = new System.Windows.Forms.CheckBox();
            this.testLib = new System.Windows.Forms.CheckBox();
            this.organizerLib = new System.Windows.Forms.CheckBox();
            this.svgLib = new System.Windows.Forms.CheckBox();
            this.multimediaWidgetsLib = new System.Windows.Forms.CheckBox();
            this.concurrentLib = new System.Windows.Forms.CheckBox();
            this.widgetsLib = new System.Windows.Forms.CheckBox();
            this.locationLib = new System.Windows.Forms.CheckBox();
            this.versitLib = new System.Windows.Forms.CheckBox();
            this.webkitWidgetsLib = new System.Windows.Forms.CheckBox();
            this.systemInfoLib = new System.Windows.Forms.CheckBox();
            this.serviceFrameworkLib = new System.Windows.Forms.CheckBox();
            this.sensorsLib = new System.Windows.Forms.CheckBox();
            this.declarativeLib = new System.Windows.Forms.CheckBox();
            this.pubSubLib = new System.Windows.Forms.CheckBox();
            this.printSupportLib = new System.Windows.Forms.CheckBox();
            this.contactsLib = new System.Windows.Forms.CheckBox();
            this.bluetoothLib = new System.Windows.Forms.CheckBox();
            this.phononLib = new System.Windows.Forms.CheckBox();
            this.helpLib = new System.Windows.Forms.CheckBox();
            this.xmlLib = new System.Windows.Forms.CheckBox();
            this.activeQtCLib = new System.Windows.Forms.CheckBox();
            this.activeQtSLib = new System.Windows.Forms.CheckBox();
            this.xmlPatternsLib = new System.Windows.Forms.CheckBox();
            this.openGLLib = new System.Windows.Forms.CheckBox();
            this.scriptLib = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsPropertyGrid
            // 
            this.OptionsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsPropertyGrid.HelpVisible = false;
            this.OptionsPropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.OptionsPropertyGrid.Name = "OptionsPropertyGrid";
            this.OptionsPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.OptionsPropertyGrid.Size = new System.Drawing.Size(539, 341);
            this.OptionsPropertyGrid.TabIndex = 8;
            this.OptionsPropertyGrid.ToolbarVisible = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(388, 382);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 22);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(469, 382);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 22);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 373);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.OptionsPropertyGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Settings";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/Remove Qt Modules";
            // 
            // quickLib
            // 
            this.quickLib.Location = new System.Drawing.Point(137, 227);
            this.quickLib.Name = "quickLib";
            this.quickLib.Size = new System.Drawing.Size(128, 22);
            this.quickLib.TabIndex = 20;
            this.quickLib.UseVisualStyleBackColor = true;
            // 
            // qmlLib
            // 
            this.qmlLib.Location = new System.Drawing.Point(3, 227);
            this.qmlLib.Name = "qmlLib";
            this.qmlLib.Size = new System.Drawing.Size(128, 22);
            this.qmlLib.TabIndex = 19;
            this.qmlLib.UseVisualStyleBackColor = true;
            // 
            // webKitLib
            // 
            this.webKitLib.Location = new System.Drawing.Point(405, 199);
            this.webKitLib.Name = "webKitLib";
            this.webKitLib.Size = new System.Drawing.Size(128, 22);
            this.webKitLib.TabIndex = 29;
            // 
            // multimediaLib
            // 
            this.multimediaLib.Location = new System.Drawing.Point(271, 199);
            this.multimediaLib.Name = "multimediaLib";
            this.multimediaLib.Size = new System.Drawing.Size(128, 22);
            this.multimediaLib.TabIndex = 11;
            // 
            // networkLib
            // 
            this.networkLib.Location = new System.Drawing.Point(137, 199);
            this.networkLib.Name = "networkLib";
            this.networkLib.Size = new System.Drawing.Size(128, 22);
            this.networkLib.TabIndex = 13;
            // 
            // coreLib
            // 
            this.coreLib.Location = new System.Drawing.Point(3, 199);
            this.coreLib.Name = "coreLib";
            this.coreLib.Size = new System.Drawing.Size(128, 22);
            this.coreLib.TabIndex = 6;
            // 
            // threeDLib
            // 
            this.threeDLib.Location = new System.Drawing.Point(3, 3);
            this.threeDLib.Name = "threeDLib";
            this.threeDLib.Size = new System.Drawing.Size(128, 22);
            this.threeDLib.TabIndex = 0;
            this.threeDLib.UseVisualStyleBackColor = true;
            // 
            // guiLib
            // 
            this.guiLib.Location = new System.Drawing.Point(405, 171);
            this.guiLib.Name = "guiLib";
            this.guiLib.Size = new System.Drawing.Size(128, 22);
            this.guiLib.TabIndex = 8;
            // 
            // sqlLib
            // 
            this.sqlLib.Location = new System.Drawing.Point(271, 171);
            this.sqlLib.Name = "sqlLib";
            this.sqlLib.Size = new System.Drawing.Size(128, 22);
            this.sqlLib.TabIndex = 24;
            // 
            // testLib
            // 
            this.testLib.Location = new System.Drawing.Point(137, 171);
            this.testLib.Name = "testLib";
            this.testLib.Size = new System.Drawing.Size(128, 22);
            this.testLib.TabIndex = 27;
            // 
            // organizerLib
            // 
            this.organizerLib.Location = new System.Drawing.Point(3, 171);
            this.organizerLib.Name = "organizerLib";
            this.organizerLib.Size = new System.Drawing.Size(128, 22);
            this.organizerLib.TabIndex = 15;
            this.organizerLib.UseVisualStyleBackColor = true;
            // 
            // svgLib
            // 
            this.svgLib.Location = new System.Drawing.Point(405, 143);
            this.svgLib.Name = "svgLib";
            this.svgLib.Size = new System.Drawing.Size(128, 22);
            this.svgLib.TabIndex = 25;
            // 
            // multimediaWidgetsLib
            // 
            this.multimediaWidgetsLib.Location = new System.Drawing.Point(271, 143);
            this.multimediaWidgetsLib.Name = "multimediaWidgetsLib";
            this.multimediaWidgetsLib.Size = new System.Drawing.Size(128, 22);
            this.multimediaWidgetsLib.TabIndex = 12;
            this.multimediaWidgetsLib.UseVisualStyleBackColor = true;
            // 
            // concurrentLib
            // 
            this.concurrentLib.Location = new System.Drawing.Point(137, 143);
            this.concurrentLib.Name = "concurrentLib";
            this.concurrentLib.Size = new System.Drawing.Size(128, 22);
            this.concurrentLib.TabIndex = 4;
            this.concurrentLib.UseVisualStyleBackColor = true;
            // 
            // widgetsLib
            // 
            this.widgetsLib.Location = new System.Drawing.Point(3, 143);
            this.widgetsLib.Name = "widgetsLib";
            this.widgetsLib.Size = new System.Drawing.Size(128, 22);
            this.widgetsLib.TabIndex = 31;
            this.widgetsLib.UseVisualStyleBackColor = true;
            // 
            // locationLib
            // 
            this.locationLib.Location = new System.Drawing.Point(405, 115);
            this.locationLib.Name = "locationLib";
            this.locationLib.Size = new System.Drawing.Size(128, 22);
            this.locationLib.TabIndex = 10;
            this.locationLib.UseVisualStyleBackColor = true;
            // 
            // versitLib
            // 
            this.versitLib.Location = new System.Drawing.Point(271, 115);
            this.versitLib.Name = "versitLib";
            this.versitLib.Size = new System.Drawing.Size(128, 22);
            this.versitLib.TabIndex = 28;
            this.versitLib.UseVisualStyleBackColor = true;
            // 
            // webkitWidgetsLib
            // 
            this.webkitWidgetsLib.Location = new System.Drawing.Point(137, 115);
            this.webkitWidgetsLib.Name = "webkitWidgetsLib";
            this.webkitWidgetsLib.Size = new System.Drawing.Size(128, 22);
            this.webkitWidgetsLib.TabIndex = 30;
            this.webkitWidgetsLib.UseVisualStyleBackColor = true;
            // 
            // systemInfoLib
            // 
            this.systemInfoLib.Location = new System.Drawing.Point(3, 115);
            this.systemInfoLib.Name = "systemInfoLib";
            this.systemInfoLib.Size = new System.Drawing.Size(128, 22);
            this.systemInfoLib.TabIndex = 26;
            this.systemInfoLib.UseVisualStyleBackColor = true;
            // 
            // serviceFrameworkLib
            // 
            this.serviceFrameworkLib.Location = new System.Drawing.Point(405, 87);
            this.serviceFrameworkLib.Name = "serviceFrameworkLib";
            this.serviceFrameworkLib.Size = new System.Drawing.Size(128, 22);
            this.serviceFrameworkLib.TabIndex = 23;
            this.serviceFrameworkLib.UseVisualStyleBackColor = true;
            // 
            // sensorsLib
            // 
            this.sensorsLib.Location = new System.Drawing.Point(271, 87);
            this.sensorsLib.Name = "sensorsLib";
            this.sensorsLib.Size = new System.Drawing.Size(128, 22);
            this.sensorsLib.TabIndex = 22;
            this.sensorsLib.UseVisualStyleBackColor = true;
            // 
            // declarativeLib
            // 
            this.declarativeLib.Location = new System.Drawing.Point(137, 87);
            this.declarativeLib.Name = "declarativeLib";
            this.declarativeLib.Size = new System.Drawing.Size(128, 22);
            this.declarativeLib.TabIndex = 7;
            this.declarativeLib.UseVisualStyleBackColor = true;
            // 
            // pubSubLib
            // 
            this.pubSubLib.Location = new System.Drawing.Point(3, 87);
            this.pubSubLib.Name = "pubSubLib";
            this.pubSubLib.Size = new System.Drawing.Size(128, 22);
            this.pubSubLib.TabIndex = 18;
            this.pubSubLib.UseVisualStyleBackColor = true;
            // 
            // printSupportLib
            // 
            this.printSupportLib.Location = new System.Drawing.Point(405, 59);
            this.printSupportLib.Name = "printSupportLib";
            this.printSupportLib.Size = new System.Drawing.Size(128, 22);
            this.printSupportLib.TabIndex = 17;
            this.printSupportLib.UseVisualStyleBackColor = true;
            // 
            // contactsLib
            // 
            this.contactsLib.Location = new System.Drawing.Point(271, 59);
            this.contactsLib.Name = "contactsLib";
            this.contactsLib.Size = new System.Drawing.Size(128, 22);
            this.contactsLib.TabIndex = 5;
            this.contactsLib.UseVisualStyleBackColor = true;
            // 
            // bluetoothLib
            // 
            this.bluetoothLib.Location = new System.Drawing.Point(137, 59);
            this.bluetoothLib.Name = "bluetoothLib";
            this.bluetoothLib.Size = new System.Drawing.Size(128, 22);
            this.bluetoothLib.TabIndex = 3;
            this.bluetoothLib.UseVisualStyleBackColor = true;
            // 
            // phononLib
            // 
            this.phononLib.Location = new System.Drawing.Point(3, 59);
            this.phononLib.Name = "phononLib";
            this.phononLib.Size = new System.Drawing.Size(128, 22);
            this.phononLib.TabIndex = 16;
            // 
            // helpLib
            // 
            this.helpLib.Location = new System.Drawing.Point(405, 31);
            this.helpLib.Name = "helpLib";
            this.helpLib.Size = new System.Drawing.Size(128, 22);
            this.helpLib.TabIndex = 9;
            // 
            // xmlLib
            // 
            this.xmlLib.Location = new System.Drawing.Point(271, 31);
            this.xmlLib.Name = "xmlLib";
            this.xmlLib.Size = new System.Drawing.Size(128, 22);
            this.xmlLib.TabIndex = 32;
            // 
            // activeQtCLib
            // 
            this.activeQtCLib.Location = new System.Drawing.Point(137, 31);
            this.activeQtCLib.Name = "activeQtCLib";
            this.activeQtCLib.Size = new System.Drawing.Size(128, 22);
            this.activeQtCLib.TabIndex = 1;
            // 
            // activeQtSLib
            // 
            this.activeQtSLib.Location = new System.Drawing.Point(3, 31);
            this.activeQtSLib.Name = "activeQtSLib";
            this.activeQtSLib.Size = new System.Drawing.Size(128, 22);
            this.activeQtSLib.TabIndex = 2;
            // 
            // xmlPatternsLib
            // 
            this.xmlPatternsLib.Location = new System.Drawing.Point(405, 3);
            this.xmlPatternsLib.Name = "xmlPatternsLib";
            this.xmlPatternsLib.Size = new System.Drawing.Size(128, 22);
            this.xmlPatternsLib.TabIndex = 33;
            // 
            // openGLLib
            // 
            this.openGLLib.Location = new System.Drawing.Point(271, 3);
            this.openGLLib.Name = "openGLLib";
            this.openGLLib.Size = new System.Drawing.Size(128, 22);
            this.openGLLib.TabIndex = 14;
            // 
            // scriptLib
            // 
            this.scriptLib.Location = new System.Drawing.Point(137, 3);
            this.scriptLib.Name = "scriptLib";
            this.scriptLib.Size = new System.Drawing.Size(128, 22);
            this.scriptLib.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.54204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.45796F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.33663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 416);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.threeDLib);
            this.flowLayoutPanel1.Controls.Add(this.scriptLib);
            this.flowLayoutPanel1.Controls.Add(this.openGLLib);
            this.flowLayoutPanel1.Controls.Add(this.xmlPatternsLib);
            this.flowLayoutPanel1.Controls.Add(this.activeQtSLib);
            this.flowLayoutPanel1.Controls.Add(this.activeQtCLib);
            this.flowLayoutPanel1.Controls.Add(this.xmlLib);
            this.flowLayoutPanel1.Controls.Add(this.helpLib);
            this.flowLayoutPanel1.Controls.Add(this.phononLib);
            this.flowLayoutPanel1.Controls.Add(this.bluetoothLib);
            this.flowLayoutPanel1.Controls.Add(this.contactsLib);
            this.flowLayoutPanel1.Controls.Add(this.printSupportLib);
            this.flowLayoutPanel1.Controls.Add(this.pubSubLib);
            this.flowLayoutPanel1.Controls.Add(this.declarativeLib);
            this.flowLayoutPanel1.Controls.Add(this.sensorsLib);
            this.flowLayoutPanel1.Controls.Add(this.serviceFrameworkLib);
            this.flowLayoutPanel1.Controls.Add(this.systemInfoLib);
            this.flowLayoutPanel1.Controls.Add(this.webkitWidgetsLib);
            this.flowLayoutPanel1.Controls.Add(this.versitLib);
            this.flowLayoutPanel1.Controls.Add(this.locationLib);
            this.flowLayoutPanel1.Controls.Add(this.widgetsLib);
            this.flowLayoutPanel1.Controls.Add(this.concurrentLib);
            this.flowLayoutPanel1.Controls.Add(this.multimediaWidgetsLib);
            this.flowLayoutPanel1.Controls.Add(this.svgLib);
            this.flowLayoutPanel1.Controls.Add(this.organizerLib);
            this.flowLayoutPanel1.Controls.Add(this.testLib);
            this.flowLayoutPanel1.Controls.Add(this.sqlLib);
            this.flowLayoutPanel1.Controls.Add(this.guiLib);
            this.flowLayoutPanel1.Controls.Add(this.coreLib);
            this.flowLayoutPanel1.Controls.Add(this.networkLib);
            this.flowLayoutPanel1.Controls.Add(this.multimediaLib);
            this.flowLayoutPanel1.Controls.Add(this.webKitLib);
            this.flowLayoutPanel1.Controls.Add(this.qmlLib);
            this.flowLayoutPanel1.Controls.Add(this.quickLib);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(539, 341);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // FormProjectQtSettings
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(559, 416);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProjectQtSettings";
            this.ShowInTaskbar = false;
            this.Text = "FormAddinSettings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid OptionsPropertyGrid;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox webKitLib;
        private System.Windows.Forms.CheckBox networkLib;
        private System.Windows.Forms.CheckBox coreLib;
        private System.Windows.Forms.CheckBox guiLib;
        private System.Windows.Forms.CheckBox sqlLib;
        private System.Windows.Forms.CheckBox testLib;
        private System.Windows.Forms.CheckBox multimediaLib;
        private System.Windows.Forms.CheckBox quickLib;
        private System.Windows.Forms.CheckBox qmlLib;
        private System.Windows.Forms.CheckBox multimediaWidgetsLib;
        private System.Windows.Forms.CheckBox concurrentLib;
        private System.Windows.Forms.CheckBox widgetsLib;
        private System.Windows.Forms.CheckBox locationLib;
        private System.Windows.Forms.CheckBox versitLib;
        private System.Windows.Forms.CheckBox webkitWidgetsLib;
        private System.Windows.Forms.CheckBox systemInfoLib;
        private System.Windows.Forms.CheckBox serviceFrameworkLib;
        private System.Windows.Forms.CheckBox sensorsLib;
        private System.Windows.Forms.CheckBox declarativeLib;
        private System.Windows.Forms.CheckBox pubSubLib;
        private System.Windows.Forms.CheckBox printSupportLib;
        private System.Windows.Forms.CheckBox contactsLib;
        private System.Windows.Forms.CheckBox bluetoothLib;
        private System.Windows.Forms.CheckBox phononLib;
        private System.Windows.Forms.CheckBox helpLib;
        private System.Windows.Forms.CheckBox xmlLib;
        private System.Windows.Forms.CheckBox activeQtCLib;
        private System.Windows.Forms.CheckBox activeQtSLib;
        private System.Windows.Forms.CheckBox xmlPatternsLib;
        private System.Windows.Forms.CheckBox openGLLib;
        private System.Windows.Forms.CheckBox scriptLib;
        private System.Windows.Forms.CheckBox threeDLib;
        private System.Windows.Forms.CheckBox organizerLib;
        private System.Windows.Forms.CheckBox svgLib;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}