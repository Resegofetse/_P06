Option Strict On
Option Explicit On
Option Infer Off
'Base class
Public MustInherit Class streaming_plan
    ' Surname, Initials:PANANA R
    ' Practical: P06

    'attributes
    Private _subscription As String
    Private Shared _subscriptionfee As Integer
    Private _videoquality As String
    Private _email As String
    Private _password As String
    Private _numdevices As Integer
    Private _Devicetype As String

    'constructors
    Public Sub New(email As String, password As String)
        _email = email
        _password = password

    End Sub
    'constructor overloading
    Public Sub New()
        _subscriptionfee = 40

    End Sub
    'property methods
    Public Property subscription() As String
        Get
            Return _subscription
        End Get
        Set(value As String)
            _subscription = value
        End Set
    End Property
    Public Property subscriptionfee() As Integer
        Get
            Return _subscriptionfee
        End Get
        Set(value As Integer)
            _subscriptionfee = value
        End Set
    End Property
    Public Property videoquality() As String
        Get
            Return _videoquality
        End Get
        Set(value As String)
            _videoquality = value
        End Set
    End Property
    Public Shared ReadOnly Property ID() As Integer
        Get
            Return ID
        End Get
    End Property
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public WriteOnly Property password() As String
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Property numdevices() As Integer
        Get
            Return _numdevices
        End Get
        Set(value As Integer)
            _numdevices = value
        End Set
    End Property
    Public Property devicetype() As String
        Get
            Return _Devicetype
        End Get
        Set(value As String)
            _Devicetype = value
        End Set
    End Property

    'functions and methods
    'function to calculate total cost of subscription plan
    Public MustOverride Function Price() As Double
    'function that checks the type of subscription and assigns the quality of video
    Public Function quality(subi As String) As String
        subi = subscription
        Dim qualityofvideo As String = ""
        If subi = "Standard" Then
            qualityofvideo = "Good"
        Else
            If subi = "Premium" Then
                qualityofvideo = "Best"
            End If
        End If
        Return qualityofvideo
    End Function

    'function to that checks the number of devices and assign devicetype
    Public Function Devices(numdevices As Integer) As String
        If numdevices = 1 Then
            devicetype = "phone"
        Else
            If numdevices = 2 Then
                devicetype = "tablet and computer"
            Else
                If numdevices = 3 Then
                    devicetype = "Phone,tablet,computer and tv"
                End If
            End If
        End If
        Return devicetype
    End Function
    'function that checks the type of device and increment tot
    Public Function Devices(devtype As String) As Integer
        Dim tot As Integer = 0
        devtype = devicetype
        If devtype = "phone" Then
            tot += 10
        Else
            If devtype = "tablet and computer" Then

                tot += 50
            Else
                If devtype = "Phone,tablet,computer and tv" Then

                    tot += 100

                End If
            End If
        End If
        Return tot
    End Function
    'function to display the user's plan and cost
    Public Overridable Function Display() As String
        Dim text As String = ""
        text &= "your streaming plan is: " & subscription & Environment.NewLine
        text &= "video quality is: " & quality(subscription) & Environment.NewLine
        text &= "Devices you can use to stream: " & devicetype & Environment.NewLine
        Return text
    End Function

End Class
