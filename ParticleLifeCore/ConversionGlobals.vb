'Imports System
'Imports System.Collections.Generic

'Option Infer On

'Public Class Globals
'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored: '#include "ofMain.h" 'C++ TO VB CONVERTER WARNING: The following #include directive was ignored: '#include "ofMain.h" 'C++ TO VB CONVERTER WARNING: The following #include directive was ignored: '#include "ofxGui.h" struct Point
'		Public Shared x As Single = 0
'		Public Shared y As Single = 0
'		Public Shared vx As Single = 0
'		Public Shared vy As Single = 0
'		Public Shared r As Integer = 0
'		Public Shared g As Integer = 0
'		Public Shared b As Integer = 0
''C++ TO VB CONVERTER WARNING: The following constructor is declared outside of its associated class:
'		Public Shared Point(ByVal _x As Integer, ByVal _y As Integer, ByVal _r As Integer, ByVal _g As Integer, ByVal _b As Integer)
'			x = _x
'			y = _y
'			r = _r
'			g = _g
'			b = _b
'		End Sub

'		Public Shared Sub Draw()
'			ofSetColor(r, g, b) ' rgb color
'			ofDrawCircle(CInt(Math.Truncate(x)), CInt(Math.Truncate(y)), 3) ' x, y position and size of the point
'		End Sub

'	'Tangible Process Only End

'	'========================================================================
'	Friend Shared Sub Main()
'		ofSetupOpenGL(1920,1024,OF_WINDOW) ' <-------- setup the GL context

'		' this kicks off the running of my app
'		' can be OF_WINDOW or OF_FULLSCREEN
'		' pass in width and height too:
'		ofRunApp(New ofApp())

'	End Sub

'	' Author:  Hunar Ahmad Abdulrahman @ brainxyz.com 2022


'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored: '#include "ofMain.h" 'C++ TO VB CONVERTER WARNING: The following #include directive was ignored: '#include "ofxGui.h" struct Point
'		Public Shared x As Single = 0
'		Public Shared y As Single = 0
'		Public Shared vx As Single = 0
'		Public Shared vy As Single = 0
'		Public Shared r As Integer = 0
'		Public Shared g As Integer = 0
'		Public Shared b As Integer = 0
''C++ TO VB CONVERTER WARNING: The following constructor is declared outside of its associated class:
'		Public Shared Point(ByVal _x As Integer, ByVal _y As Integer, ByVal _r As Integer, ByVal _g As Integer, ByVal _b As Integer)
'			x = _x
'			y = _y
'			r = _r
'			g = _g
'			b = _b
'		End Sub

'		Public Shared Sub Draw()
'			ofSetColor(r, g, b) ' rgb color
'			ofDrawCircle(CInt(Math.Truncate(x)), CInt(Math.Truncate(y)), 3) ' x, y position and size of the point
'		End Sub


'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored: '#include <omp.h> float xshift = 510;
'	Public Shared yshift As Single = 80
'	Public Shared anchor As Single = 0
'	Public Shared length As Single = 100
'	Public Shared p1x As Single = anchor+xshift
'	Public Shared p1y As Single = anchor+yshift
'	Public Shared p2x As Single = anchor+length+xshift
'	Public Shared p2y As Single = anchor+yshift
'	Public Shared p3x As Single = anchor+length+xshift
'	Public Shared p3y As Single = anchor+length+yshift
'	Public Shared p4x As Single = anchor + xshift
'	Public Shared p4y As Single = anchor + length + yshift
'	Public Shared rr As Single = 15
'	Public Shared countThresh As Integer = 0

'	Public Shared green As New List(Of Point)()
'	Public Shared red As New List(Of Point)()
'	Public Shared white As New List(Of Point)()
'	Public Shared blue As New List(Of Point)()

'	Public Shared Function RandomFloat(ByVal a As Single, ByVal b As Single) As Single
'		Dim random As Single = (CSng(rand())) / CSng(RAND_MAX)
'		Dim diff As Single = b - a
'		Dim r As Single = random * diff
'		Return a + r
'	End Function
'	Public Shared Sub Draw(ByVal points As List(Of Point))
'	Dim i As Integer = 0
'		Do While i < points.Count
'			 points(i).Draw()
'		i += 1
'		Loop
'	End Sub
'	Public Shared Function Random(ByVal mn As Integer, ByVal mx As Integer) As Integer
'		Return rand() Mod (mx - mn) + mn
'	End Function

'	Public Shared Function CreatePoints(ByVal num As Integer, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As List(Of Point)
'		Dim points As New List(Of Point)()
'		For i As Integer = 0 To num - 1
'			Dim x As Integer = Random(900, 1700)
'			Dim y As Integer = Random(100, 900)
'			points.Add(Point(x, y, r, g, b))
'		Next i
'		Return New List(Of Point)(points)
'	End Function


'End Class