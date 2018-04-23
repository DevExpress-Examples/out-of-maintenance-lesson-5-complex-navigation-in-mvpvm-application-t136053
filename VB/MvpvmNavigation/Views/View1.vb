Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon

Namespace MvpvmNavigation.Views
    Partial Public Class View1
        Inherits UserControl
        Implements IRibbonModule

        Public Sub New()
            InitializeComponent()
            System.Threading.Thread.Sleep(1000)
        End Sub
        Private ReadOnly Property IRibbonModule_Ribbon() As RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl1
            End Get
        End Property
    End Class
End Namespace
