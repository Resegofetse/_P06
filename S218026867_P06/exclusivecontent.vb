Option Strict On
Option Explicit On
Option Infer Off
'composition class
Public Class exclusivecontent
    ' Surname, Initials:PANANA R
    ' Practical: P06

    'attributes
    Private _typeofcontent As String
    Private _showzz As Integer
    'contructor
    Public Sub New()

    End Sub
    'property methods
    Public Property typeofcontent() As String
        Get
            Return _typeofcontent
        End Get
        Set(value As String)
            _typeofcontent = value
        End Set
    End Property
    Public Property showzz() As Integer
        Get
            Return _showzz
        End Get
        Set(value As Integer)
            _showzz = value
        End Set
    End Property
    'functions
    'function to check what kind of content user chose for their streaming plan
    Public Function Typec(temp As Integer) As String

        Select Case temp
            Case 1
                typeofcontent = "Movies"

            Case 2
                typeofcontent = "Series"

            Case 3
                typeofcontent = "Documentaries"

        End Select

        Return typeofcontent

    End Function
    'function to check the type of extra content the user would like and to show how many of those shows will be added to the subscription
    Public Function Numberofshows(typeofcontent As String) As Integer


        If typeofcontent = "Movie" Then

            showzz = 25

        Else
            If typeofcontent = "Series" Then

                showzz = 15
            Else
                If typeofcontent = "Documentaries" Then

                    showzz = 35
                End If
            End If
        End If

        Return showzz

    End Function
    'function to calculate cost of adding extra shows to the plan
    Public Function Tot() As Integer
        Dim total As Integer = 0
        total += showzz * 2
        Return total
    End Function
End Class
