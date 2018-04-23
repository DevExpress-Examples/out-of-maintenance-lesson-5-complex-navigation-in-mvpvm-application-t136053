Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.ComponentModel.DataAnnotations

Namespace MvpvmNavigation.Model
    Public Enum ModuleType
        None
        <Display(Name := "Module A")>
        ModuleA
        <Display(Name := "Module B")>
        ModuleB
    End Enum
End Namespace
