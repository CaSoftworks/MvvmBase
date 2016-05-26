Option Strict On

Imports System.ComponentModel

Namespace CaSoftworks.MvvmBase


    Public MustInherit Class ViewModel

        Implements INotifyPropertyChanged

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(propertyName As String)

        End Sub

    End Class

End Namespace