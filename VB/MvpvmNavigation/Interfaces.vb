Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraBars.Ribbon

Namespace MvpvmNavigation
    Public Interface IRibbonModule
        ReadOnly Property Ribbon() As RibbonControl
    End Interface

    Public Interface ISupportTransitions
        Sub StartTransition(ByVal forward As Boolean, ByVal waitParameter As Object)
        Sub EndTransition()
    End Interface
End Namespace
