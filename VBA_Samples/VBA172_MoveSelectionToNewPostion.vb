Sub MoveSelectionToNewPostion()
'VBA172
    Dim nPosX As Long
    Dim nPosY As Long
    Dim objCircle As HMICircle
    Dim objRectangle As HMIRectangle
    Set objCircle = ActiveDocument.HMIObjects.AddHMIObject("sCircle", "HMICircle")
    Set objRectangle = ActiveDocument.HMIObjects.AddHMIObject("sRectangle", "HMIRectangle")
    With objCircle
        .Top = 40
        .Left = 40
        .Selected = True
    End With
    With objRectangle
        .Top = 80
        .Left = 80
        .Selected = True
    End With
    MsgBox "Objects selected!"
    nPosX = 30
    nPosY = 40
    'Instead of next you can write "ActiveDocument.Selection.MoveSelection".
    ActiveDocument.MoveSelection nPosX, nPosY
End Sub
