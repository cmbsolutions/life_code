'Option Infer On

'Imports System
'Imports System.Collections.Generic

'Public Class ofApp
'	Inherits ofBaseApp


'		'--------------------------------------------------------------
'		Public Sub setup()
'			ofSetWindowTitle("Particle Life - www.brainxyz.com")
'			' Interface
'			gui.setup("Settings")
'			gui.loadFont("Arial", 16)
'			gui.setWidthElements(400.0f)

'			gui.add(resetButton.setup("START/RESET"))
'			gui.add(boundsToggle.setup("Bounded", True))
'			gui.add(modelToggle.setup("Show Model", True))
'			gui.add(labelG.setup("GREEN:", "-"))
'			gui.add(numberSliderG.setup("number:", pnumberSliderG, 0, 3000))
'			gui.add(powerSliderGG.setup("green x green:", ppowerSliderGG, -100, 100))
'			gui.add(powerSliderGR.setup("green x red:", ppowerSliderGR, -100, 100))
'			gui.add(powerSliderGW.setup("green x white:", ppowerSliderGW, -100, 100))
'			gui.add(powerSliderGB.setup("green x blue:", ppowerSliderGB, -100, 100))

'			gui.add(vSliderGG.setup("radius g x g:", pvSliderGG, 10, 500))
'			gui.add(vSliderGR.setup("radius g x r:", pvSliderGR, 10, 500))
'			gui.add(vSliderGW.setup("radius g x w:", pvSliderGW, 10, 500))
'			gui.add(vSliderGB.setup("radius g x b:", pvSliderGB, 10, 500))

'			gui.add(labelR.setup("RED:", "-"))
'			gui.add(numberSliderR.setup("number:", pnumberSliderR, 0, 3000))
'			gui.add(powerSliderRR.setup("red x red:", ppowerSliderRR, -100, 100))
'			gui.add(powerSliderRG.setup("red x green:", ppowerSliderRG, -100, 100))
'			gui.add(powerSliderRW.setup("red x white:", ppowerSliderRW, -100, 100))
'			gui.add(powerSliderRB.setup("red x blue:", ppowerSliderRB, -100, 100))

'			gui.add(vSliderRG.setup("radius r x g:", pvSliderRG, 10, 500))
'			gui.add(vSliderRR.setup("radius r x r:", pvSliderRR, 10, 500))
'			gui.add(vSliderRW.setup("radius r x w:", pvSliderRW, 10, 500))
'			gui.add(vSliderRB.setup("radius r x b:", pvSliderRB, 10, 500))

'			gui.add(labelW.setup("WHITE:", "-"))
'			gui.add(numberSliderW.setup("number:", pnumberSliderW, 0, 3000))
'			gui.add(powerSliderWW.setup("white x white:", ppowerSliderWW, -100, 100))
'			gui.add(powerSliderWR.setup("white x red:", ppowerSliderWR, -100, 100))
'			gui.add(powerSliderWG.setup("white x green:", ppowerSliderWG, -100, 100))
'			gui.add(powerSliderWB.setup("white x blue:", ppowerSliderWB, -100, 100))

'			gui.add(vSliderWG.setup("radius w x g:", pvSliderWG, 10, 500))
'			gui.add(vSliderWR.setup("radius w x r:", pvSliderWR, 10, 500))
'			gui.add(vSliderWW.setup("radius w x w:", pvSliderWW, 10, 500))
'			gui.add(vSliderWB.setup("radius w x b:", pvSliderWB, 10, 500))

'			gui.add(labelB.setup("BLUE:", "-"))
'			gui.add(numberSliderB.setup("number:", pnumberSliderB, 0, 3000))
'			gui.add(powerSliderBB.setup("blue x blue:", ppowerSliderBB, -100, 100))
'			gui.add(powerSliderBW.setup("blue x white:", ppowerSliderBW, -100, 100))
'			gui.add(powerSliderBR.setup("blue x red:", ppowerSliderBR, -100, 100))
'			gui.add(powerSliderBG.setup("blue x green:", ppowerSliderBG, -100, 100))

'			gui.add(vSliderBG.setup("radius b x g:", pvSliderBG, 10, 500))
'			gui.add(vSliderBR.setup("radius b x r:", pvSliderBR, 10, 500))
'			gui.add(vSliderBW.setup("radius b x w:", pvSliderBW, 10, 500))
'			gui.add(vSliderBB.setup("radius b x b:", pvSliderBB, 10, 500))
'			gui.add(aboutL3.setup("Info:", "www.brainxyz.com "))

'			restart()
'		End Sub


'		'--------------------------------------------------------------
'		Public Sub update()

'			If numberSliderG > 0 Then
'				Interaction(Globals.green, Globals.green, New ofxFloatSlider(powerSliderGG), New ofxFloatSlider(vSliderGG))
'				Interaction(Globals.green, Globals.red, New ofxFloatSlider(powerSliderGR), New ofxFloatSlider(vSliderGR))
'				Interaction(Globals.green, Globals.white, New ofxFloatSlider(powerSliderGW), New ofxFloatSlider(vSliderGW))
'				Interaction(Globals.green, Globals.blue, New ofxFloatSlider(powerSliderGB), New ofxFloatSlider(vSliderGB))
'			End If

'			If numberSliderR > 0 Then
'				Interaction(Globals.red, Globals.red, New ofxFloatSlider(powerSliderRR), New ofxFloatSlider(vSliderRR))
'				Interaction(Globals.red, Globals.green, New ofxFloatSlider(powerSliderRG), New ofxFloatSlider(vSliderRG))
'				Interaction(Globals.red, Globals.white, New ofxFloatSlider(powerSliderRW), New ofxFloatSlider(vSliderRW))
'				Interaction(Globals.red, Globals.blue, New ofxFloatSlider(powerSliderRB), New ofxFloatSlider(vSliderRB))
'			End If
'			If numberSliderW > 0 Then
'				Interaction(Globals.white, Globals.white, New ofxFloatSlider(powerSliderWW), New ofxFloatSlider(vSliderWW))
'				Interaction(Globals.white, Globals.green, New ofxFloatSlider(powerSliderWG), New ofxFloatSlider(vSliderWG))
'				Interaction(Globals.white, Globals.red, New ofxFloatSlider(powerSliderWR), New ofxFloatSlider(vSliderWR))
'				Interaction(Globals.white, Globals.blue, New ofxFloatSlider(powerSliderWB), New ofxFloatSlider(vSliderWB))
'			End If
'			If numberSliderB > 0 Then
'				Interaction(Globals.blue, Globals.white, New ofxFloatSlider(powerSliderBW), New ofxFloatSlider(vSliderBW))
'				Interaction(Globals.blue, Globals.green, New ofxFloatSlider(powerSliderBG), New ofxFloatSlider(vSliderBG))
'				Interaction(Globals.blue, Globals.red, New ofxFloatSlider(powerSliderBR), New ofxFloatSlider(vSliderBR))
'				Interaction(Globals.blue, Globals.blue, New ofxFloatSlider(powerSliderBB), New ofxFloatSlider(vSliderBB))
'			End If
'		End Sub


'		'--------------------------------------------------------------
'		Public Sub draw()

'			ofBackground(0) ' Clear the screen with a black color

'			If resetButton IsNot Nothing Then
'				restart()
'			End If
'			If numberSliderW > 0 Then
'				Globals.Draw(Globals.white)
'			End If
'			If numberSliderR > 0 Then
'				Globals.Draw(Globals.red)
'			End If
'			If numberSliderG > 0 Then
'				Globals.Draw(Globals.green)
'			End If
'			If numberSliderB > 0 Then
'				Globals.Draw(Globals.blue)
'			End If

'			If modelToggle = True Then

'				ofSetColor(0, 0, 0)
'				ofDrawCircle(xshift, Globals.yshift, 150)

'				ofSetLineWidth(5)
'				ofSetColor(150 - powerSliderGR, 150 + powerSliderGR, 150)
'				ofDrawLine(Globals.p1x, Globals.p1y - 10, Globals.p2x, Globals.p2y - 10)
'				ofSetColor(150 - powerSliderRG, 150 + powerSliderRG, 150)
'				ofDrawLine(Globals.p1x, Globals.p1y + 10, Globals.p2x, Globals.p2y + 10)
'				ofSetColor(150 - powerSliderGW, 150 + powerSliderGW, 150)
'				ofDrawLine(Globals.p3x, Globals.p3y - 10, Globals.p1x, Globals.p1y - 10)
'				ofSetColor(150 - powerSliderWG, 150 + powerSliderWG, 150)
'				ofDrawLine(Globals.p3x, Globals.p3y + 10, Globals.p1x, Globals.p1y + 10)

'				ofSetColor(150 - powerSliderGB, 150 + powerSliderGB, 150)
'				ofDrawLine(Globals.p4x - 10, Globals.p4y, Globals.p1x - 10, Globals.p1y)
'				ofSetColor(150 - powerSliderBG, 150 + powerSliderBG, 150)
'				ofDrawLine(Globals.p4x + 10, Globals.p4y, Globals.p1x + 10, Globals.p1y)

'				ofSetColor(150 - powerSliderRW, 150 + powerSliderRW, 150)
'				ofDrawLine(Globals.p2x - 10, Globals.p2y, Globals.p3x - 10, Globals.p3y)
'				ofSetColor(150 - powerSliderWR, 150 + powerSliderWR, 150)
'				ofDrawLine(Globals.p2x + 10, Globals.p2y, Globals.p3x + 10, Globals.p3y)

'				ofSetColor(150 - powerSliderRB, 150 + powerSliderRB, 150)
'				ofDrawLine(Globals.p2x, Globals.p2y - 10, Globals.p4x, Globals.p4y - 10)
'				ofSetColor(150 - powerSliderBR, 150 + powerSliderBR, 150)
'				ofDrawLine(Globals.p2x, Globals.p2y + 10, Globals.p4x, Globals.p4y + 10)

'				ofSetColor(150 - powerSliderWB, 150 + powerSliderWB, 150)
'				ofDrawLine(Globals.p3x, Globals.p3y - 10, Globals.p4x, Globals.p4y - 10)
'				ofSetColor(150 - powerSliderBW, 150 + powerSliderBW, 150)
'				ofDrawLine(Globals.p3x, Globals.p3y + 10, Globals.p4x, Globals.p4y + 10)

'				ofNoFill()
'				ofSetColor(150 - powerSliderGG, 150 + powerSliderGG, 150)
'				ofDrawCircle(Globals.p1x - 20, Globals.p1y - 20, Globals.rr + 20)
'				ofSetColor(150 - powerSliderRR, 150 + powerSliderRR, 150)
'				ofDrawCircle(Globals.p2x + 20, Globals.p2y - 20, Globals.rr + 20)
'				ofSetColor(150 - powerSliderWW, 150 + powerSliderWW, 150)
'				ofDrawCircle(Globals.p3x + 20, Globals.p3y + 20, Globals.rr + 20)
'				ofSetColor(150 - powerSliderBB, 150 + powerSliderBB, 150)
'				ofDrawCircle(Globals.p4x - 20, Globals.p4y + 20, Globals.rr + 20)

'				ofFill()
'				ofSetColor(100, 250, 10)
'				ofDrawCircle(Globals.p1x, Globals.p1y, Globals.rr)
'				ofSetColor(250, 10, 100)
'				ofDrawCircle(Globals.p2x, Globals.p2y, Globals.rr)
'				ofSetColor(250, 250, 250)
'				ofDrawCircle(Globals.p3x, Globals.p3y, Globals.rr)
'				ofSetColor(100, 100, 250)
'				ofDrawCircle(Globals.p4x, Globals.p4y, Globals.rr)

'			End If

'			gui.draw()

'		End Sub

'		Public Sub restart()
'			If numberSliderG > 0 Then
'				Globals.green = New List(Of Point)(Globals.CreatePoints(New ofxIntSlider(numberSliderR), 100, 250, 10))
'			End If
'			If numberSliderR > 0 Then
'				Globals.red = New List(Of Point)(Globals.CreatePoints(New ofxIntSlider(numberSliderG), 250, 10, 100))
'			End If
'			If numberSliderW > 0 Then
'				Globals.white = New List(Of Point)(Globals.CreatePoints(New ofxIntSlider(numberSliderW), 250, 250, 250))
'			End If
'			If numberSliderB > 0 Then
'				Globals.blue = New List(Of Point)(Globals.CreatePoints(New ofxIntSlider(numberSliderB), 100, 100, 250))
'			End If
'		End Sub


'		' Interaction between 2 particle groups
'		Public Sub Interaction(ByVal Group1 As List(Of Point), ByVal Group2 As List(Of Point), ByVal G As Single, ByVal radius As Single)

''C++ TO VB CONVERTER NOTE: The variable g was renamed since Visual Basic will not allow local variables with the same name as parameters or other local variables:
'			Dim g_Conflict As Single = G / -100

'			omp_set_num_threads(4)
'		'C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
'		'	#pragma omp parallel for
'			Dim i As Integer = 0
'			Do While i < Group1.Count
'				Dim p1 = Group1(i)
'				Dim fx As Single = 0
'				Dim fy As Single = 0
'				Dim j As Integer = 0
'				Do While j < Group2.Count
'					Dim p2 = Group2(j)
'					Dim dx = p1.x - p2.x
'					Dim dy = p1.y - p2.y
'					Dim r = Math.Sqrt(dx * dx + dy * dy)
'					If Globals.r < radius AndAlso Globals.r > 0 Then
''C++ TO VB CONVERTER WARNING: C++ to VB Converter cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
'						fx += (dx / Globals.r)
''C++ TO VB CONVERTER WARNING: C++ to VB Converter cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
'						fy += (dy / Globals.r)
'					End If
'					j += 1
'				Loop

'				p1.vx = (p1.vx + (fx * g_Conflict)) * 0.5
'				p1.vy = (p1.vy + (fy * g_Conflict)) * 0.5
'				p1.x += p1.vx
'				p1.y += p1.vy

'				If boundsToggle IsNot Nothing Then
'					If (p1.x >= 1920 - 10) OrElse (p1.x <= 550 + 10) Then
'						p1.vx *= -1
'					End If
'					If (p1.y >= 1024 - 10) OrElse (p1.y <= 0 + 10) Then
'						p1.vy *= -1
'					End If
'				End If

'				Group1(i) = p1
'				i += 1
'			Loop

'		End Sub

'		Public gui As New ofxPanel()

'		Public resetButton As New ofxButton()
'		Public selectButton As New ofxButton()
'		Public randomChoice As New ofxButton()
'		Public boundsToggle As New ofxToggle()
'		Public modelToggle As New ofxToggle()

'		Public numberSliderR As New ofxIntSlider()
'		Public numberSliderG As New ofxIntSlider()
'		Public numberSliderW As New ofxIntSlider()
'		Public numberSliderB As New ofxIntSlider()

'		Public pnumberSliderR As Integer = 1000
'		Public pnumberSliderG As Integer = 1000
'		Public pnumberSliderW As Integer = 1000
'		Public pnumberSliderB As Integer = 1000

'		Public effectVariance As New ofxFloatSlider()
'		Public radiusVariance As New ofxFloatSlider()

'		Public powerSliderRR As New ofxFloatSlider()
'		Public powerSliderRG As New ofxFloatSlider()
'		Public powerSliderRW As New ofxFloatSlider()
'		Public powerSliderRB As New ofxFloatSlider()

'		Public ppowerSliderRR As Single = 0
'		Public ppowerSliderRG As Single = 0
'		Public ppowerSliderRW As Single = 0
'		Public ppowerSliderRB As Single = 0

'		Public powerSliderGR As New ofxFloatSlider()
'		Public powerSliderGG As New ofxFloatSlider()
'		Public powerSliderGW As New ofxFloatSlider()
'		Public powerSliderGB As New ofxFloatSlider()

'		Public ppowerSliderGR As Single = 0
'		Public ppowerSliderGG As Single = 0
'		Public ppowerSliderGW As Single = 0
'		Public ppowerSliderGB As Single = 0


'		Public powerSliderWR As New ofxFloatSlider()
'		Public powerSliderWG As New ofxFloatSlider()
'		Public powerSliderWW As New ofxFloatSlider()
'		Public powerSliderWB As New ofxFloatSlider()

'		Public ppowerSliderWR As Single = 0
'		Public ppowerSliderWG As Single = 0
'		Public ppowerSliderWW As Single = 0
'		Public ppowerSliderWB As Single = 0

'		Public powerSliderBR As New ofxFloatSlider()
'		Public powerSliderBG As New ofxFloatSlider()
'		Public powerSliderBW As New ofxFloatSlider()
'		Public powerSliderBB As New ofxFloatSlider()

'		Public ppowerSliderBR As Single = 0
'		Public ppowerSliderBG As Single = 0
'		Public ppowerSliderBW As Single = 0
'		Public ppowerSliderBB As Single = 0

'		Public vSliderRR As New ofxFloatSlider()
'		Public vSliderRG As New ofxFloatSlider()
'		Public vSliderRW As New ofxFloatSlider()
'		Public vSliderRB As New ofxFloatSlider()

'		Public pvSliderRR As Single = 180
'		Public pvSliderRG As Single = 180
'		Public pvSliderRW As Single = 180
'		Public pvSliderRB As Single = 180

'		Public vSliderGR As New ofxFloatSlider()
'		Public vSliderGG As New ofxFloatSlider()
'		Public vSliderGW As New ofxFloatSlider()
'		Public vSliderGB As New ofxFloatSlider()

'		Public pvSliderGR As Single = 180
'		Public pvSliderGG As Single = 180
'		Public pvSliderGW As Single = 180
'		Public pvSliderGB As Single = 180

'		Public vSliderWR As New ofxFloatSlider()
'		Public vSliderWG As New ofxFloatSlider()
'		Public vSliderWW As New ofxFloatSlider()
'		Public vSliderWB As New ofxFloatSlider()

'		Public pvSliderWR As Single = 180
'		Public pvSliderWG As Single = 180
'		Public pvSliderWW As Single = 180
'		Public pvSliderWB As Single = 180

'		Public vSliderBR As New ofxFloatSlider()
'		Public vSliderBG As New ofxFloatSlider()
'		Public vSliderBW As New ofxFloatSlider()
'		Public vSliderBB As New ofxFloatSlider()

'		Public pvSliderBR As Single = 180
'		Public pvSliderBG As Single = 180
'		Public pvSliderBW As Single = 180
'		Public pvSliderBB As Single = 180
'		Public labelG As New ofxLabel()
'		Public labelR As New ofxLabel()
'		Public labelW As New ofxLabel()
'		Public labelB As New ofxLabel()

'		Public aboutL1 As New ofxLabel()
'		Public aboutL2 As New ofxLabel()
'		Public aboutL3 As New ofxLabel()
'End Class