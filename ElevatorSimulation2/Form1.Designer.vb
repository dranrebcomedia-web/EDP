<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pnlShaft = New System.Windows.Forms.Panel()
        Me.pnlCar = New System.Windows.Forms.Panel()
        Me.pnlDoorRight = New System.Windows.Forms.Panel()
        Me.pnlDoorLeft = New System.Windows.Forms.Panel()
        Me.lblCarFloor = New System.Windows.Forms.Label()
        Me.lblFloor4 = New System.Windows.Forms.Label()
        Me.lblFloor3 = New System.Windows.Forms.Label()
        Me.lblFloor2 = New System.Windows.Forms.Label()
        Me.lblFloor1 = New System.Windows.Forms.Label()
        Me.btnExt4Down = New System.Windows.Forms.Button()
        Me.btnExt3Up = New System.Windows.Forms.Button()
        Me.btnExt3Down = New System.Windows.Forms.Button()
        Me.btnExt2Up = New System.Windows.Forms.Button()
        Me.btnExt2Down = New System.Windows.Forms.Button()
        Me.btnExt1Up = New System.Windows.Forms.Button()
        Me.grpInside = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnFloor4 = New System.Windows.Forms.Button()
        Me.btnFloor3 = New System.Windows.Forms.Button()
        Me.btnFloor2 = New System.Windows.Forms.Button()
        Me.btnFloor1 = New System.Windows.Forms.Button()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDoor = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAnim = New System.Windows.Forms.Timer(Me.components)
        Me.pnlShaft.SuspendLayout()
        Me.pnlCar.SuspendLayout()
        Me.grpInside.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlShaft
        '
        Me.pnlShaft.BackColor = System.Drawing.Color.DimGray
        Me.pnlShaft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlShaft.Controls.Add(Me.pnlCar)
        Me.pnlShaft.Location = New System.Drawing.Point(20, 60)
        Me.pnlShaft.Name = "pnlShaft"
        Me.pnlShaft.Size = New System.Drawing.Size(160, 585)
        Me.pnlShaft.TabIndex = 0
        '
        'pnlCar
        '
        Me.pnlCar.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlCar.Controls.Add(Me.pnlDoorRight)
        Me.pnlCar.Controls.Add(Me.pnlDoorLeft)
        Me.pnlCar.Controls.Add(Me.lblCarFloor)
        Me.pnlCar.ForeColor = System.Drawing.Color.SteelBlue
        Me.pnlCar.Location = New System.Drawing.Point(29, 445)
        Me.pnlCar.Name = "pnlCar"
        Me.pnlCar.Size = New System.Drawing.Size(100, 90)
        Me.pnlCar.TabIndex = 0
        '
        'pnlDoorRight
        '
        Me.pnlDoorRight.BackColor = System.Drawing.Color.CadetBlue
        Me.pnlDoorRight.Location = New System.Drawing.Point(50, 0)
        Me.pnlDoorRight.Name = "pnlDoorRight"
        Me.pnlDoorRight.Size = New System.Drawing.Size(48, 88)
        Me.pnlDoorRight.TabIndex = 2
        '
        'pnlDoorLeft
        '
        Me.pnlDoorLeft.BackColor = System.Drawing.Color.CadetBlue
        Me.pnlDoorLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlDoorLeft.Name = "pnlDoorLeft"
        Me.pnlDoorLeft.Size = New System.Drawing.Size(48, 88)
        Me.pnlDoorLeft.TabIndex = 1
        '
        'lblCarFloor
        '
        Me.lblCarFloor.AutoSize = True
        Me.lblCarFloor.BackColor = System.Drawing.Color.Transparent
        Me.lblCarFloor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCarFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarFloor.ForeColor = System.Drawing.Color.White
        Me.lblCarFloor.Location = New System.Drawing.Point(0, 0)
        Me.lblCarFloor.Name = "lblCarFloor"
        Me.lblCarFloor.Size = New System.Drawing.Size(24, 25)
        Me.lblCarFloor.TabIndex = 0
        Me.lblCarFloor.Text = "1"
        Me.lblCarFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFloor4
        '
        Me.lblFloor4.AutoSize = True
        Me.lblFloor4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor4.Location = New System.Drawing.Point(190, 80)
        Me.lblFloor4.Name = "lblFloor4"
        Me.lblFloor4.Size = New System.Drawing.Size(30, 20)
        Me.lblFloor4.TabIndex = 1
        Me.lblFloor4.Text = "4F"
        '
        'lblFloor3
        '
        Me.lblFloor3.AutoSize = True
        Me.lblFloor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor3.Location = New System.Drawing.Point(190, 210)
        Me.lblFloor3.Name = "lblFloor3"
        Me.lblFloor3.Size = New System.Drawing.Size(30, 20)
        Me.lblFloor3.TabIndex = 2
        Me.lblFloor3.Text = "3F"
        '
        'lblFloor2
        '
        Me.lblFloor2.AutoSize = True
        Me.lblFloor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor2.Location = New System.Drawing.Point(190, 340)
        Me.lblFloor2.Name = "lblFloor2"
        Me.lblFloor2.Size = New System.Drawing.Size(30, 20)
        Me.lblFloor2.TabIndex = 3
        Me.lblFloor2.Text = "2F"
        '
        'lblFloor1
        '
        Me.lblFloor1.AutoSize = True
        Me.lblFloor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor1.Location = New System.Drawing.Point(190, 508)
        Me.lblFloor1.Name = "lblFloor1"
        Me.lblFloor1.Size = New System.Drawing.Size(30, 20)
        Me.lblFloor1.TabIndex = 4
        Me.lblFloor1.Text = "1F"
        '
        'btnExt4Down
        '
        Me.btnExt4Down.BackColor = System.Drawing.Color.Tomato
        Me.btnExt4Down.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt4Down.ForeColor = System.Drawing.Color.White
        Me.btnExt4Down.Location = New System.Drawing.Point(220, 80)
        Me.btnExt4Down.Name = "btnExt4Down"
        Me.btnExt4Down.Size = New System.Drawing.Size(36, 36)
        Me.btnExt4Down.TabIndex = 5
        Me.btnExt4Down.Text = "▼"
        Me.btnExt4Down.UseVisualStyleBackColor = False
        '
        'btnExt3Up
        '
        Me.btnExt3Up.BackColor = System.Drawing.Color.LimeGreen
        Me.btnExt3Up.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt3Up.ForeColor = System.Drawing.Color.White
        Me.btnExt3Up.Location = New System.Drawing.Point(220, 205)
        Me.btnExt3Up.Name = "btnExt3Up"
        Me.btnExt3Up.Size = New System.Drawing.Size(36, 36)
        Me.btnExt3Up.TabIndex = 6
        Me.btnExt3Up.Text = "▲"
        Me.btnExt3Up.UseVisualStyleBackColor = False
        '
        'btnExt3Down
        '
        Me.btnExt3Down.BackColor = System.Drawing.Color.Tomato
        Me.btnExt3Down.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt3Down.ForeColor = System.Drawing.Color.White
        Me.btnExt3Down.Location = New System.Drawing.Point(260, 205)
        Me.btnExt3Down.Name = "btnExt3Down"
        Me.btnExt3Down.Size = New System.Drawing.Size(36, 36)
        Me.btnExt3Down.TabIndex = 7
        Me.btnExt3Down.Text = "▼"
        Me.btnExt3Down.UseVisualStyleBackColor = False
        '
        'btnExt2Up
        '
        Me.btnExt2Up.BackColor = System.Drawing.Color.LimeGreen
        Me.btnExt2Up.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt2Up.ForeColor = System.Drawing.Color.White
        Me.btnExt2Up.Location = New System.Drawing.Point(220, 335)
        Me.btnExt2Up.Name = "btnExt2Up"
        Me.btnExt2Up.Size = New System.Drawing.Size(36, 36)
        Me.btnExt2Up.TabIndex = 8
        Me.btnExt2Up.Text = "▲"
        Me.btnExt2Up.UseVisualStyleBackColor = False
        '
        'btnExt2Down
        '
        Me.btnExt2Down.BackColor = System.Drawing.Color.Tomato
        Me.btnExt2Down.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt2Down.ForeColor = System.Drawing.Color.White
        Me.btnExt2Down.Location = New System.Drawing.Point(260, 335)
        Me.btnExt2Down.Name = "btnExt2Down"
        Me.btnExt2Down.Size = New System.Drawing.Size(36, 36)
        Me.btnExt2Down.TabIndex = 9
        Me.btnExt2Down.Text = "▼"
        Me.btnExt2Down.UseVisualStyleBackColor = False
        '
        'btnExt1Up
        '
        Me.btnExt1Up.BackColor = System.Drawing.Color.LimeGreen
        Me.btnExt1Up.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt1Up.ForeColor = System.Drawing.Color.White
        Me.btnExt1Up.Location = New System.Drawing.Point(220, 503)
        Me.btnExt1Up.Name = "btnExt1Up"
        Me.btnExt1Up.Size = New System.Drawing.Size(36, 36)
        Me.btnExt1Up.TabIndex = 10
        Me.btnExt1Up.Text = "▲"
        Me.btnExt1Up.UseVisualStyleBackColor = False
        '
        'grpInside
        '
        Me.grpInside.Controls.Add(Me.btnClose)
        Me.grpInside.Controls.Add(Me.btnOpen)
        Me.grpInside.Controls.Add(Me.btnFloor4)
        Me.grpInside.Controls.Add(Me.btnFloor3)
        Me.grpInside.Controls.Add(Me.btnFloor2)
        Me.grpInside.Controls.Add(Me.btnFloor1)
        Me.grpInside.Location = New System.Drawing.Point(550, 60)
        Me.grpInside.Name = "grpInside"
        Me.grpInside.Size = New System.Drawing.Size(200, 220)
        Me.grpInside.TabIndex = 11
        Me.grpInside.TabStop = False
        Me.grpInside.Text = "Inside Car"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Teal
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(110, 165)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 36)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.Teal
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Location = New System.Drawing.Point(20, 165)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(70, 36)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnFloor4
        '
        Me.btnFloor4.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnFloor4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFloor4.ForeColor = System.Drawing.Color.White
        Me.btnFloor4.Location = New System.Drawing.Point(110, 100)
        Me.btnFloor4.Name = "btnFloor4"
        Me.btnFloor4.Size = New System.Drawing.Size(60, 50)
        Me.btnFloor4.TabIndex = 3
        Me.btnFloor4.Text = "4"
        Me.btnFloor4.UseVisualStyleBackColor = False
        '
        'btnFloor3
        '
        Me.btnFloor3.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnFloor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFloor3.ForeColor = System.Drawing.Color.White
        Me.btnFloor3.Location = New System.Drawing.Point(20, 100)
        Me.btnFloor3.Name = "btnFloor3"
        Me.btnFloor3.Size = New System.Drawing.Size(60, 50)
        Me.btnFloor3.TabIndex = 2
        Me.btnFloor3.Text = "3"
        Me.btnFloor3.UseVisualStyleBackColor = False
        '
        'btnFloor2
        '
        Me.btnFloor2.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnFloor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFloor2.ForeColor = System.Drawing.Color.White
        Me.btnFloor2.Location = New System.Drawing.Point(110, 30)
        Me.btnFloor2.Name = "btnFloor2"
        Me.btnFloor2.Size = New System.Drawing.Size(60, 50)
        Me.btnFloor2.TabIndex = 1
        Me.btnFloor2.Text = "2"
        Me.btnFloor2.UseVisualStyleBackColor = False
        '
        'btnFloor1
        '
        Me.btnFloor1.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnFloor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFloor1.ForeColor = System.Drawing.Color.White
        Me.btnFloor1.Location = New System.Drawing.Point(20, 30)
        Me.btnFloor1.Name = "btnFloor1"
        Me.btnFloor1.Size = New System.Drawing.Size(60, 50)
        Me.btnFloor1.TabIndex = 0
        Me.btnFloor1.Text = "1"
        Me.btnFloor1.UseVisualStyleBackColor = False
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.lstStatus)
        Me.grpStatus.Location = New System.Drawing.Point(550, 300)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(200, 220)
        Me.grpStatus.TabIndex = 12
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Elevator Status"
        '
        'lstStatus
        '
        Me.lstStatus.BackColor = System.Drawing.Color.Black
        Me.lstStatus.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStatus.ForeColor = System.Drawing.Color.Lime
        Me.lstStatus.FormattingEnabled = True
        Me.lstStatus.ItemHeight = 20
        Me.lstStatus.Location = New System.Drawing.Point(10, 25)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(175, 164)
        Me.lstStatus.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(273, 29)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "🏢 Elevator Simulation"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(550, 540)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(90, 40)
        Me.btnStart.TabIndex = 14
        Me.btnStart.Text = "▶ Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Crimson
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(660, 540)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(90, 40)
        Me.btnStop.TabIndex = 15
        Me.btnStop.Text = "■ Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 1000
        '
        'tmrDoor
        '
        Me.tmrDoor.Interval = 4000
        '
        'tmrAnim
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 853)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.grpInside)
        Me.Controls.Add(Me.btnExt1Up)
        Me.Controls.Add(Me.btnExt2Down)
        Me.Controls.Add(Me.btnExt2Up)
        Me.Controls.Add(Me.btnExt3Down)
        Me.Controls.Add(Me.btnExt3Up)
        Me.Controls.Add(Me.btnExt4Down)
        Me.Controls.Add(Me.lblFloor1)
        Me.Controls.Add(Me.lblFloor2)
        Me.Controls.Add(Me.lblFloor3)
        Me.Controls.Add(Me.lblFloor4)
        Me.Controls.Add(Me.pnlShaft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlShaft.ResumeLayout(False)
        Me.pnlCar.ResumeLayout(False)
        Me.pnlCar.PerformLayout()
        Me.grpInside.ResumeLayout(False)
        Me.grpStatus.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlShaft As Panel
    Friend WithEvents pnlCar As Panel
    Friend WithEvents lblCarFloor As Label
    Friend WithEvents lblFloor4 As Label
    Friend WithEvents lblFloor3 As Label
    Friend WithEvents lblFloor2 As Label
    Friend WithEvents lblFloor1 As Label
    Friend WithEvents btnExt4Down As Button
    Friend WithEvents btnExt3Up As Button
    Friend WithEvents btnExt3Down As Button
    Friend WithEvents btnExt2Up As Button
    Friend WithEvents btnExt2Down As Button
    Friend WithEvents btnExt1Up As Button
    Friend WithEvents grpInside As GroupBox
    Friend WithEvents btnFloor2 As Button
    Friend WithEvents btnFloor1 As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnFloor4 As Button
    Friend WithEvents btnFloor3 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents lstStatus As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents tmrMove As Timer
    Friend WithEvents tmrDoor As Timer
    Friend WithEvents pnlDoorLeft As Panel
    Friend WithEvents tmrAnim As Timer
    Friend WithEvents pnlDoorRight As Panel
End Class
