Option Strict On
Option Explicit On
Option Infer Off
'derived class
Public Class Standard
    Inherits streaming_plan
    ' Surname, Initials:PANANA R
    ' Practical: P06

    'attributes
    Private _numprofiles As Integer
    Private _reso As String
    Private _resprice As Integer
    Private _nres As Integer
    Private _answer As Integer
    'constructor
    Public Sub New(email As String, password As String)
        MyBase.New(email, password)
    End Sub
    'property methods
    Public Property numberofprofiles() As Integer
        Get
            Return _numprofiles
        End Get
        Set(value As Integer)
            If value > 0 Then
                _numprofiles = value
            End If

        End Set
    End Property
    Public Property reso() As String
        Get
            Return _reso
        End Get
        Set(value As String)
            _reso = value
        End Set
    End Property
    Public Property resprice() As Integer
        Get
            Return _resprice
        End Get
        Set(value As Integer)
            _resprice = value
        End Set
    End Property
    Public Property nres() As Integer
        Get
            Return _nres
        End Get
        Set(value As Integer)
            _nres = value
        End Set
    End Property
    Public Property answer() As Integer
        Get
            Return _answer
        End Get
        Set(value As Integer)
            _answer = value
        End Set
    End Property
    'functions and methods
    'function that checks the number given by the user, then assign resolution accordindly and increment price
    Public Function Resolution() As Integer
        resprice = 0
        If nres = 1 Then
            reso = "480p"
            resprice += 30
        Else
            If nres = 2 Then
                reso = "1080p"
                resprice += 50
            End If

        End If
        Return resprice
    End Function
    'function to check number of profiles then increment answer accordingly
    Public Function profiles() As Integer
        answer = 0
        If numberofprofiles = 1 Then
            answer += 10
        Else
            If numberofprofiles = 2 Then
                answer += 50
            Else
                If numberofprofiles = 3 Then
                    answer += 120
                End If
            End If
        End If
        Return answer
    End Function
    'function to calculate price that the users plan will cost
    Public Overrides Function Price() As Double

        Return (subscriptionfee + profiles() + Resolution() + Devices(devicetype))
    End Function
    'function to display details  of the plan user chose and what it entails
    Public Overrides Function Display() As String
        Dim text As String = ""
        text &= MyBase.Display()
        text &= "Resolution is:" & _reso & Environment.NewLine
        text &= "Number of profiles is :" & numberofprofiles & Environment.NewLine
        text &= "Total cost for your plan is R:" & CStr(Price())
        Return text
    End Function

End Class
