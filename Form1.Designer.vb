<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtExtra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstIssues = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstResolutions = New System.Windows.Forms.ListBox()
        Me.lstResolutions22 = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabInternet = New System.Windows.Forms.TabPage()
        Me.lstInternet = New System.Windows.Forms.ListBox()
        Me.tabAccount = New System.Windows.Forms.TabPage()
        Me.lstAccount = New System.Windows.Forms.ListBox()
        Me.tabCable = New System.Windows.Forms.TabPage()
        Me.lstCable = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabInternet.SuspendLayout()
        Me.tabAccount.SuspendLayout()
        Me.tabCable.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAccountNumber)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTicket)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(469, 939)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Account #"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(110, 55)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(342, 26)
        Me.txtAccountNumber.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtNotes)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 457)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(443, 470)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(6, 25)
        Me.txtNotes.MaxLength = 998
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(431, 439)
        Me.txtNotes.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtExtra)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 151)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(454, 300)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Extra info"
        '
        'txtExtra
        '
        Me.txtExtra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExtra.Location = New System.Drawing.Point(6, 25)
        Me.txtExtra.Multiline = True
        Me.txtExtra.Name = "txtExtra"
        Me.txtExtra.Size = New System.Drawing.Size(437, 262)
        Me.txtExtra.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ticket #:"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(110, 119)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(342, 26)
        Me.txtTicket.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Callback #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Caller Name"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(110, 87)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(342, 26)
        Me.txtNumber.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(342, 26)
        Me.txtName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstIssues)
        Me.GroupBox2.Location = New System.Drawing.Point(1591, 832)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(531, 378)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Issues"
        '
        'lstIssues
        '
        Me.lstIssues.CheckOnClick = True
        Me.lstIssues.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIssues.FormattingEnabled = True
        Me.lstIssues.Location = New System.Drawing.Point(7, 26)
        Me.lstIssues.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstIssues.Name = "lstIssues"
        Me.lstIssues.Size = New System.Drawing.Size(518, 340)
        Me.lstIssues.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstResolutions)
        Me.GroupBox3.Location = New System.Drawing.Point(495, 495)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(574, 457)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resolution / Steps"
        '
        'lstResolutions
        '
        Me.lstResolutions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstResolutions.FormattingEnabled = True
        Me.lstResolutions.ItemHeight = 18
        Me.lstResolutions.Location = New System.Drawing.Point(6, 29)
        Me.lstResolutions.Name = "lstResolutions"
        Me.lstResolutions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstResolutions.Size = New System.Drawing.Size(562, 414)
        Me.lstResolutions.TabIndex = 8
        '
        'lstResolutions22
        '
        Me.lstResolutions22.CheckOnClick = True
        Me.lstResolutions22.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResolutions22.FormattingEnabled = True
        Me.lstResolutions22.Location = New System.Drawing.Point(1471, 38)
        Me.lstResolutions22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstResolutions22.Name = "lstResolutions22"
        Me.lstResolutions22.Size = New System.Drawing.Size(557, 340)
        Me.lstResolutions22.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1272, 1271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Issues:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1376, 1268)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 26)
        Me.TextBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightPink
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(327, 968)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 82)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(22, 968)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 82)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Copy"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tabInternet)
        Me.TabControl1.Controls.Add(Me.tabAccount)
        Me.TabControl1.Controls.Add(Me.tabCable)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(6, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 439)
        Me.TabControl1.TabIndex = 7
        '
        'tabInternet
        '
        Me.tabInternet.Controls.Add(Me.lstInternet)
        Me.tabInternet.Location = New System.Drawing.Point(4, 30)
        Me.tabInternet.Name = "tabInternet"
        Me.tabInternet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInternet.Size = New System.Drawing.Size(561, 405)
        Me.tabInternet.TabIndex = 0
        Me.tabInternet.Text = "Internet"
        Me.tabInternet.UseVisualStyleBackColor = True
        '
        'lstInternet
        '
        Me.lstInternet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstInternet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstInternet.FormattingEnabled = True
        Me.lstInternet.ItemHeight = 18
        Me.lstInternet.Location = New System.Drawing.Point(3, 3)
        Me.lstInternet.Name = "lstInternet"
        Me.lstInternet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstInternet.Size = New System.Drawing.Size(555, 399)
        Me.lstInternet.TabIndex = 0
        '
        'tabAccount
        '
        Me.tabAccount.Controls.Add(Me.lstAccount)
        Me.tabAccount.Location = New System.Drawing.Point(4, 30)
        Me.tabAccount.Name = "tabAccount"
        Me.tabAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAccount.Size = New System.Drawing.Size(561, 405)
        Me.tabAccount.TabIndex = 1
        Me.tabAccount.Text = "Account"
        Me.tabAccount.UseVisualStyleBackColor = True
        '
        'lstAccount
        '
        Me.lstAccount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAccount.FormattingEnabled = True
        Me.lstAccount.ItemHeight = 18
        Me.lstAccount.Location = New System.Drawing.Point(3, 3)
        Me.lstAccount.Name = "lstAccount"
        Me.lstAccount.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAccount.Size = New System.Drawing.Size(555, 399)
        Me.lstAccount.TabIndex = 1
        '
        'tabCable
        '
        Me.tabCable.Controls.Add(Me.lstCable)
        Me.tabCable.Location = New System.Drawing.Point(4, 30)
        Me.tabCable.Name = "tabCable"
        Me.tabCable.Size = New System.Drawing.Size(561, 405)
        Me.tabCable.TabIndex = 2
        Me.tabCable.Text = "Cable"
        Me.tabCable.UseVisualStyleBackColor = True
        '
        'lstCable
        '
        Me.lstCable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstCable.FormattingEnabled = True
        Me.lstCable.ItemHeight = 18
        Me.lstCable.Location = New System.Drawing.Point(0, 0)
        Me.lstCable.Name = "lstCable"
        Me.lstCable.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstCable.Size = New System.Drawing.Size(561, 405)
        Me.lstCable.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TabControl1)
        Me.GroupBox6.Location = New System.Drawing.Point(488, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(581, 470)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Category"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 1065)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.lstResolutions22)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Notes Tool 2 - Created by Sam H."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabInternet.ResumeLayout(False)
        Me.tabAccount.ResumeLayout(False)
        Me.tabCable.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstIssues As CheckedListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lstResolutions22 As CheckedListBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExtra As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabInternet As TabPage
    Friend WithEvents tabAccount As TabPage
    Friend WithEvents tabCable As TabPage
    Friend WithEvents lstInternet As ListBox
    Friend WithEvents lstAccount As ListBox
    Friend WithEvents lstCable As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents lstResolutions As ListBox
    Friend WithEvents GroupBox6 As GroupBox
End Class
