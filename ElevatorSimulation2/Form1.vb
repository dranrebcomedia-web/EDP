' ============================================================
' MAIN FORM
' ============================================================
Public Class Form1

    Private elev As New Elevator()
    Private ReadOnly FloorY As Integer() = {400, 270, 140, 10}

    ' Door animation state
    Private doorAnimTarget As Integer = 0   ' 0=closed, 48=open
    Private doorAnimStep As Integer = 4     ' px per frame

    ' -- Load ------------------------------------------------
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetControlsEnabled(False)
        UpdateUI()
    End Sub

    ' -- UpdateUI --------------------------------------------
    Private Sub UpdateUI()
        pnlCar.Top = FloorY(elev.CurrentFloor - 1)
        lblCarFloor.Text = elev.CurrentFloor.ToString()

        lstStatus.Items.Clear()
        lstStatus.Items.Add($"Floor  : {elev.CurrentFloor}")
        lstStatus.Items.Add($"Door   : {elev.DoorStatus}")
        Dim dirSymbol = If(elev.Direction = ElevatorDirection.Up, "? Up",
                        If(elev.Direction = ElevatorDirection.Down, "? Down", "? Idle"))
        lstStatus.Items.Add($"Dir    : {dirSymbol}")
        Dim intReq = If(elev.InternalRequests.Count > 0,
                        String.Join(",", elev.InternalRequests.OrderBy(Function(x) x)), "None")
        lstStatus.Items.Add($"Int Req: {intReq}")
        Dim extReq = If(elev.ExternalCalls.Count > 0,
                        String.Join(", ", elev.ExternalCalls.Select(
                            Function(t) $"{t.Item1}{If(t.Item2 = ElevatorDirection.Up, "?", "?")}")), "None")
        lstStatus.Items.Add($"Ext Cal: {extReq}")

        Dim internalBtns = {btnFloor1, btnFloor2, btnFloor3, btnFloor4}
        For i = 0 To 3
            internalBtns(i).BackColor = If(elev.InternalRequests.Contains(i + 1), Color.Yellow, Color.LightSlateGray)
            internalBtns(i).ForeColor = If(elev.InternalRequests.Contains(i + 1), Color.Black, Color.White)
        Next

        HighlightExtBtn(btnExt1Up, 1, ElevatorDirection.Up)
        HighlightExtBtn(btnExt2Up, 2, ElevatorDirection.Up)
        HighlightExtBtn(btnExt2Down, 2, ElevatorDirection.Down)
        HighlightExtBtn(btnExt3Up, 3, ElevatorDirection.Up)
        HighlightExtBtn(btnExt3Down, 3, ElevatorDirection.Down)
        HighlightExtBtn(btnExt4Down, 4, ElevatorDirection.Down)
    End Sub

    Private Sub HighlightExtBtn(btn As Button, floor As Integer, dir As ElevatorDirection)
        Dim active = elev.ExternalCalls.Any(Function(t) t.Item1 = floor AndAlso t.Item2 = dir)
        If active Then
            btn.BackColor = Color.Yellow : btn.ForeColor = Color.Black
        Else
            btn.BackColor = If(dir = ElevatorDirection.Up, Color.LimeGreen, Color.Tomato)
            btn.ForeColor = Color.White
        End If
    End Sub

    Private Sub SetControlsEnabled(enabled As Boolean)
        For Each btn In {btnFloor1, btnFloor2, btnFloor3, btnFloor4,
                         btnOpen, btnClose,
                         btnExt1Up, btnExt2Up, btnExt2Down,
                         btnExt3Up, btnExt3Down, btnExt4Down}
            btn.Enabled = enabled
        Next
        btnStop.Enabled = enabled
        btnStart.Enabled = Not enabled
    End Sub

    ' -- Timers ----------------------------------------------
    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrMove.Tick
        If elev.DoorStatus <> DoorState.Closed Then Exit Sub
        Dim target = elev.GetNextTarget()
        If target = -1 Then
            elev.Direction = ElevatorDirection.Idle
            elev.IsMoving = False
            tmrMove.Stop()
            LogStatus("? Idle.")
            UpdateUI()
            Exit Sub
        End If
        If target = elev.CurrentFloor Then
            elev.ArriveAtFloor() : OpenDoorsNow() : Exit Sub
        End If
        If target > elev.CurrentFloor Then
            elev.Direction = ElevatorDirection.Up : elev.CurrentFloor += 1
        Else
            elev.Direction = ElevatorDirection.Down : elev.CurrentFloor -= 1
        End If
        LogStatus($"Moving {elev.Direction} ? Floor {elev.CurrentFloor}…")
        UpdateUI()
        If elev.CurrentFloor = target Then
            elev.ArriveAtFloor() : OpenDoorsNow()
        End If
    End Sub

    Private Sub tmrDoor_Tick(sender As Object, e As EventArgs) Handles tmrDoor.Tick
        tmrDoor.Stop()
        CloseDoorsNow()
    End Sub

    ' ── Door animation timer (every 30ms) ───────────────────
    Private Sub tmrAnim_Tick(sender As Object, e As EventArgs) Handles tmrAnim.Tick
        If doorAnimTarget = 48 Then
            ' Opening: slide doors apart
            pnlDoorLeft.Left = Math.Max(pnlDoorLeft.Left - doorAnimStep, -48)
            pnlDoorRight.Left = Math.Min(pnlDoorRight.Left + doorAnimStep, 98)
            If pnlDoorLeft.Left <= -48 Then
                tmrAnim.Stop()
                LogStatus("Doors fully open.")
            End If
        Else
            ' Closing: slide doors together
            pnlDoorLeft.Left = Math.Min(pnlDoorLeft.Left + doorAnimStep, 0)
            pnlDoorRight.Left = Math.Max(pnlDoorRight.Left - doorAnimStep, 50)
            If pnlDoorLeft.Left >= 0 Then
                tmrAnim.Stop()
                FinishClosingDoors()
            End If
        End If
    End Sub

    Private Sub OpenDoorsNow()
        elev.DoorStatus = DoorState.Open
        tmrDoor.Stop()
        doorAnimTarget = 48
        tmrAnim.Start()
        tmrDoor.Start()
        LogStatus($"?? Ding — Floor {elev.CurrentFloor}. Doors Opening…")
        UpdateUI()
    End Sub

    Private Sub CloseDoorsNow()
        elev.DoorStatus = DoorState.Closed
        doorAnimTarget = 0
        tmrAnim.Start()
        LogStatus("Doors Closing…")
        UpdateUI()
    End Sub

    ' ── Called when closing animation finishes ───────────────
    Private Sub FinishClosingDoors()
        LogStatus("Doors Closed.")
        UpdateUI()
        If elev.GetNextTarget() <> -1 Then
            elev.IsMoving = True
            tmrMove.Start()
        Else
            elev.Direction = ElevatorDirection.Idle
            elev.IsMoving = False
            tmrMove.Stop()
            LogStatus("? Idle.")
            UpdateUI()
        End If
    End Sub

    Private Sub LogStatus(msg As String)
        lstStatus.Items.Add($"? {msg}")
        lstStatus.TopIndex = lstStatus.Items.Count - 1
    End Sub

    ' -- Start / Stop ----------------------------------------
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        elev.IsRunning = True
        SetControlsEnabled(True)
        LogStatus("Simulation Started.")
        UpdateUI()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrMove.Stop() : tmrDoor.Stop()
        tmrAnim.Stop()
        elev = New Elevator()
        pnlDoorLeft.Left = 0
        pnlDoorRight.Left = 50
        doorAnimTarget = 0
        SetControlsEnabled(False)
        LogStatus("¦ Stopped. Reset to Floor 1.")
        UpdateUI()
    End Sub

    ' -- Inside car buttons ----------------------------------
    Private Sub btnFloor1_Click(sender As Object, e As EventArgs) Handles btnFloor1.Click
        HandleInternalRequest(1)
    End Sub
    Private Sub btnFloor2_Click(sender As Object, e As EventArgs) Handles btnFloor2.Click
        HandleInternalRequest(2)
    End Sub
    Private Sub btnFloor3_Click(sender As Object, e As EventArgs) Handles btnFloor3.Click
        HandleInternalRequest(3)
    End Sub
    Private Sub btnFloor4_Click(sender As Object, e As EventArgs) Handles btnFloor4.Click
        HandleInternalRequest(4)
    End Sub

    Private Sub HandleInternalRequest(floor As Integer)
        If floor = elev.CurrentFloor AndAlso elev.DoorStatus = DoorState.Open Then
            LogStatus($"Already at Floor {floor} — doors stay open.")
            tmrDoor.Stop() : tmrDoor.Start()
            Return
        End If
        elev.AddInternalRequest(floor)
        LogStatus($"[Inside] Floor {floor} requested.")
        UpdateUI()
        StartMovingIfNeeded()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If Not elev.IsMoving Then
            tmrDoor.Stop() : OpenDoorsNow()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If elev.DoorStatus = DoorState.Open Then
            tmrDoor.Stop() : CloseDoorsNow()
        End If
    End Sub

    ' -- Outside call buttons ---------------------------------
    Private Sub btnExt1Up_Click(sender As Object, e As EventArgs) Handles btnExt1Up.Click
        HandleExternalCall(1, ElevatorDirection.Up)
    End Sub
    Private Sub btnExt2Up_Click(sender As Object, e As EventArgs) Handles btnExt2Up.Click
        HandleExternalCall(2, ElevatorDirection.Up)
    End Sub
    Private Sub btnExt2Down_Click(sender As Object, e As EventArgs) Handles btnExt2Down.Click
        HandleExternalCall(2, ElevatorDirection.Down)
    End Sub
    Private Sub btnExt3Up_Click(sender As Object, e As EventArgs) Handles btnExt3Up.Click
        HandleExternalCall(3, ElevatorDirection.Up)
    End Sub
    Private Sub btnExt3Down_Click(sender As Object, e As EventArgs) Handles btnExt3Down.Click
        HandleExternalCall(3, ElevatorDirection.Down)
    End Sub
    Private Sub btnExt4Down_Click(sender As Object, e As EventArgs) Handles btnExt4Down.Click
        HandleExternalCall(4, ElevatorDirection.Down)
    End Sub

    Private Sub HandleExternalCall(floor As Integer, dir As ElevatorDirection)
        elev.AddExternalCall(floor, dir)
        LogStatus($"[Outside] Floor {floor} {If(dir = ElevatorDirection.Up, "? Up", "? Down")} called.")
        UpdateUI()
        StartMovingIfNeeded()
    End Sub

    Private Sub StartMovingIfNeeded()
        If Not elev.IsMoving AndAlso elev.DoorStatus = DoorState.Closed Then
            If elev.GetNextTarget() <> -1 Then
                elev.IsMoving = True : tmrMove.Start()
            End If
        End If
    End Sub

    ' -- Keyboard shortcuts -----------------------------------
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If Not elev.IsRunning Then Return MyBase.ProcessCmdKey(msg, keyData)
        Select Case keyData
            Case Keys.D1 : HandleInternalRequest(1) : Return True
            Case Keys.D2 : HandleInternalRequest(2) : Return True
            Case Keys.D3 : HandleInternalRequest(3) : Return True
            Case Keys.D4 : HandleInternalRequest(4) : Return True
            Case Keys.U : HandleExternalCall(1, ElevatorDirection.Up) : Return True
            Case Keys.D : HandleExternalCall(4, ElevatorDirection.Down) : Return True
            Case Keys.O : btnOpen_Click(Nothing, Nothing) : Return True
            Case Keys.C : btnClose_Click(Nothing, Nothing) : Return True
            Case Keys.Q : Me.Close() : Return True
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class

' ============================================================
' ENUMS
' ============================================================
Public Enum ElevatorDirection
    Up
    Down
    Idle
End Enum

Public Enum DoorState
    Open
    Closed
End Enum

' ============================================================
' ELEVATOR CLASS
' ============================================================
Public Class Elevator
    Public CurrentFloor As Integer = 1
    Public Direction As ElevatorDirection = ElevatorDirection.Idle
    Public DoorStatus As DoorState = DoorState.Closed
    Public IsMoving As Boolean = False
    Public IsRunning As Boolean = False

    Public InternalRequests As New List(Of Integer)
    Public ExternalCalls As New List(Of Tuple(Of Integer, ElevatorDirection))

    Public Sub AddInternalRequest(floor As Integer)
        If Not InternalRequests.Contains(floor) Then
            InternalRequests.Add(floor)
        End If
    End Sub

    Public Sub AddExternalCall(floor As Integer, dir As ElevatorDirection)
        Dim exists = ExternalCalls.Any(Function(t) t.Item1 = floor AndAlso t.Item2 = dir)
        If Not exists Then
            ExternalCalls.Add(Tuple.Create(floor, dir))
        End If
    End Sub

    Public Function GetNextTarget() As Integer
        Dim allTargets As New List(Of Integer)
        For Each f In InternalRequests
            If Not allTargets.Contains(f) Then allTargets.Add(f)
        Next
        For Each c In ExternalCalls
            If Not allTargets.Contains(c.Item1) Then allTargets.Add(c.Item1)
        Next
        If allTargets.Count = 0 Then Return -1

        If Direction = ElevatorDirection.Up Then
            Dim ahead = allTargets.Where(Function(f) f > CurrentFloor).OrderBy(Function(f) f).ToList()
            If ahead.Count > 0 Then Return ahead(0)
            Dim below = allTargets.Where(Function(f) f < CurrentFloor).OrderByDescending(Function(f) f).ToList()
            If below.Count > 0 Then Return below(0)
        ElseIf Direction = ElevatorDirection.Down Then
            Dim below = allTargets.Where(Function(f) f < CurrentFloor).OrderByDescending(Function(f) f).ToList()
            If below.Count > 0 Then Return below(0)
            Dim ahead = allTargets.Where(Function(f) f > CurrentFloor).OrderBy(Function(f) f).ToList()
            If ahead.Count > 0 Then Return ahead(0)
        End If

        Return allTargets.OrderBy(Function(f) Math.Abs(f - CurrentFloor)).First()
    End Function

    Public Sub ArriveAtFloor()
        InternalRequests.Remove(CurrentFloor)
        ExternalCalls.RemoveAll(Function(t) t.Item1 = CurrentFloor)
    End Sub
End Class
