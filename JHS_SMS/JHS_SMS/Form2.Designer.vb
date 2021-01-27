<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Enrolling_ForLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.P3DatabaseDataSet = New JHS_SMS.P3DatabaseDataSet()
        Me.P3Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P3Table1TableAdapter = New JHS_SMS.P3DatabaseDataSetTableAdapters.P3Table1TableAdapter()
        Me.TableAdapterManager = New JHS_SMS.P3DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.P3Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.P3Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Enrolling_ForTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.lblSMS = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.rdbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rdbtnMale = New System.Windows.Forms.RadioButton()
        Student_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Enrolling_ForLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.P3DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P3Table1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.BackColor = System.Drawing.Color.Transparent
        Student_IDLabel.Font = New System.Drawing.Font("Bebas Kai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.ForeColor = System.Drawing.Color.Black
        Student_IDLabel.Location = New System.Drawing.Point(269, 110)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(83, 23)
        Student_IDLabel.TabIndex = 1
        Student_IDLabel.Text = "Student ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Bebas Kai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.Black
        First_NameLabel.Location = New System.Drawing.Point(269, 143)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(86, 23)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Bebas Kai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.Black
        Last_NameLabel.Location = New System.Drawing.Point(269, 176)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(82, 23)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Bebas Kai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.Color.Black
        GenderLabel.Location = New System.Drawing.Point(269, 209)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(61, 23)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'Enrolling_ForLabel
        '
        Enrolling_ForLabel.AutoSize = True
        Enrolling_ForLabel.BackColor = System.Drawing.Color.Transparent
        Enrolling_ForLabel.Font = New System.Drawing.Font("Bebas Kai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Enrolling_ForLabel.ForeColor = System.Drawing.Color.Black
        Enrolling_ForLabel.Location = New System.Drawing.Point(269, 242)
        Enrolling_ForLabel.Name = "Enrolling_ForLabel"
        Enrolling_ForLabel.Size = New System.Drawing.Size(108, 23)
        Enrolling_ForLabel.TabIndex = 9
        Enrolling_ForLabel.Text = "Enrolling For:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.Transparent
        PhoneLabel.Font = New System.Drawing.Font("Bebas Kai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.ForeColor = System.Drawing.Color.Black
        PhoneLabel.Location = New System.Drawing.Point(269, 275)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(55, 23)
        PhoneLabel.TabIndex = 11
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Font = New System.Drawing.Font("Bebas Kai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.Color.Black
        EmailLabel.Location = New System.Drawing.Point(269, 307)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 23)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'P3DatabaseDataSet
        '
        Me.P3DatabaseDataSet.DataSetName = "P3DatabaseDataSet"
        Me.P3DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P3Table1BindingSource
        '
        Me.P3Table1BindingSource.DataMember = "P3Table1"
        Me.P3Table1BindingSource.DataSource = Me.P3DatabaseDataSet
        '
        'P3Table1TableAdapter
        '
        Me.P3Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.P3Table1TableAdapter = Me.P3Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = JHS_SMS.P3DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'P3Table1BindingNavigator
        '
        Me.P3Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.P3Table1BindingNavigator.BackgroundImage = Global.JHS_SMS.My.Resources.Resources.JHS_SMSPic
        Me.P3Table1BindingNavigator.BindingSource = Me.P3Table1BindingSource
        Me.P3Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.P3Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.P3Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.P3Table1BindingNavigatorSaveItem})
        Me.P3Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.P3Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.P3Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.P3Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.P3Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.P3Table1BindingNavigator.Name = "P3Table1BindingNavigator"
        Me.P3Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.P3Table1BindingNavigator.Size = New System.Drawing.Size(728, 25)
        Me.P3Table1BindingNavigator.TabIndex = 0
        Me.P3Table1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'P3Table1BindingNavigatorSaveItem
        '
        Me.P3Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.P3Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("P3Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.P3Table1BindingNavigatorSaveItem.Name = "P3Table1BindingNavigatorSaveItem"
        Me.P3Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.P3Table1BindingNavigatorSaveItem.Text = "Save Data"
        Me.P3Table1BindingNavigatorSaveItem.Visible = False
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.BackColor = System.Drawing.Color.LightGray
        Me.Student_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.P3Table1BindingSource, "Student ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Student_IDTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(379, 108)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(305, 26)
        Me.Student_IDTextBox.TabIndex = 2
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.BackColor = System.Drawing.Color.LightGray
        Me.First_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.P3Table1BindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.First_NameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.First_NameTextBox.Location = New System.Drawing.Point(379, 140)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(305, 26)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.BackColor = System.Drawing.Color.LightGray
        Me.Last_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.P3Table1BindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Last_NameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(379, 173)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(305, 26)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.Color.DarkGray
        Me.GenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.P3Table1BindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.GenderTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GenderTextBox.Location = New System.Drawing.Point(379, 207)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(157, 26)
        Me.GenderTextBox.TabIndex = 8
        '
        'Enrolling_ForTextBox
        '
        Me.Enrolling_ForTextBox.BackColor = System.Drawing.Color.LightGray
        Me.Enrolling_ForTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enrolling_ForTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.P3Table1BindingSource, "Enrolling For", True))
        Me.Enrolling_ForTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Enrolling_ForTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Enrolling_ForTextBox.Location = New System.Drawing.Point(379, 241)
        Me.Enrolling_ForTextBox.Name = "Enrolling_ForTextBox"
        Me.Enrolling_ForTextBox.Size = New System.Drawing.Size(305, 26)
        Me.Enrolling_ForTextBox.TabIndex = 10
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.BackColor = System.Drawing.Color.LightGray
        Me.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.P3Table1BindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.PhoneTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneTextBox.Location = New System.Drawing.Point(379, 273)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(305, 26)
        Me.PhoneTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.LightGray
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.P3Table1BindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmailTextBox.Location = New System.Drawing.Point(379, 305)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(305, 26)
        Me.EmailTextBox.TabIndex = 14
        '
        'lblSMS
        '
        Me.lblSMS.AutoSize = True
        Me.lblSMS.BackColor = System.Drawing.Color.Transparent
        Me.lblSMS.Font = New System.Drawing.Font("Bebas Kai", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMS.ForeColor = System.Drawing.Color.Black
        Me.lblSMS.Location = New System.Drawing.Point(254, 40)
        Me.lblSMS.Name = "lblSMS"
        Me.lblSMS.Size = New System.Drawing.Size(449, 52)
        Me.lblSMS.TabIndex = 40
        Me.lblSMS.Text = "Student Management System"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Bebas Kai", 14.25!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(545, 422)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 23)
        Me.LinkLabel1.TabIndex = 49
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back To Login Form"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DimGray
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("BigNoodleTitling", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(486, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 29)
        Me.btnClear.TabIndex = 55
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DimGray
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("BigNoodleTitling", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(379, 385)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 29)
        Me.btnAdd.TabIndex = 54
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.DimGray
        Me.btnDel.FlatAppearance.BorderSize = 0
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("BigNoodleTitling", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(486, 385)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(90, 29)
        Me.btnDel.TabIndex = 53
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.DimGray
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("BigNoodleTitling", 18.0!)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(594, 350)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 64)
        Me.btnNext.TabIndex = 52
        Me.btnNext.Text = ">>>"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("BigNoodleTitling", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(379, 350)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 29)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.DimGray
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("BigNoodleTitling", 18.0!)
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Location = New System.Drawing.Point(273, 350)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(90, 64)
        Me.btnPrev.TabIndex = 50
        Me.btnPrev.Text = "<<<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'rdbtnFemale
        '
        Me.rdbtnFemale.AutoSize = True
        Me.rdbtnFemale.BackColor = System.Drawing.Color.Transparent
        Me.rdbtnFemale.Font = New System.Drawing.Font("Bebas Kai", 14.0!)
        Me.rdbtnFemale.ForeColor = System.Drawing.Color.Black
        Me.rdbtnFemale.Location = New System.Drawing.Point(609, 206)
        Me.rdbtnFemale.Name = "rdbtnFemale"
        Me.rdbtnFemale.Size = New System.Drawing.Size(75, 27)
        Me.rdbtnFemale.TabIndex = 57
        Me.rdbtnFemale.TabStop = True
        Me.rdbtnFemale.Text = "Female"
        Me.rdbtnFemale.UseVisualStyleBackColor = False
        '
        'rdbtnMale
        '
        Me.rdbtnMale.AutoSize = True
        Me.rdbtnMale.BackColor = System.Drawing.Color.Transparent
        Me.rdbtnMale.Font = New System.Drawing.Font("Bebas Kai", 14.0!)
        Me.rdbtnMale.ForeColor = System.Drawing.Color.Black
        Me.rdbtnMale.Location = New System.Drawing.Point(542, 206)
        Me.rdbtnMale.Name = "rdbtnMale"
        Me.rdbtnMale.Size = New System.Drawing.Size(61, 27)
        Me.rdbtnMale.TabIndex = 56
        Me.rdbtnMale.TabStop = True
        Me.rdbtnMale.Text = "Male"
        Me.rdbtnMale.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JHS_SMS.My.Resources.Resources.JHS_SMSPic
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 462)
        Me.Controls.Add(Me.rdbtnFemale)
        Me.Controls.Add(Me.rdbtnMale)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblSMS)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Enrolling_ForLabel)
        Me.Controls.Add(Me.Enrolling_ForTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.P3Table1BindingNavigator)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JHS_SMS"
        CType(Me.P3DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P3Table1BindingNavigator.ResumeLayout(False)
        Me.P3Table1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P3DatabaseDataSet As JHS_SMS.P3DatabaseDataSet
    Friend WithEvents P3Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P3Table1TableAdapter As JHS_SMS.P3DatabaseDataSetTableAdapters.P3Table1TableAdapter
    Friend WithEvents TableAdapterManager As JHS_SMS.P3DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P3Table1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents P3Table1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Student_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Enrolling_ForTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblSMS As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents rdbtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnMale As System.Windows.Forms.RadioButton
End Class
