Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Sistema01

Namespace Controllers
    Public Class empleadosController
        Inherits System.Web.Mvc.Controller

        Private db As New BLEIXEntities1

        ' GET: empleados
        Function Index() As ActionResult
            Dim empleados = db.empleados.Include(Function(e) e.departamentos)
            Return View(empleados.ToList())
        End Function

        ' GET: empleados/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleados As empleados = db.empleados.Find(id)
            If IsNothing(empleados) Then
                Return HttpNotFound()
            End If
            Return View(empleados)
        End Function

        ' GET: empleados/Create
        Function Create() As ActionResult
            ViewBag.Id_Departamento = New SelectList(db.departamentos, "iddepartamento", "Descripcion")
            Return View()
        End Function

        ' POST: empleados/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="idempleados,Nombre,Direccion,Telefono,Id_Departamento")> ByVal empleados As empleados) As ActionResult
            If ModelState.IsValid Then
                db.empleados.Add(empleados)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Id_Departamento = New SelectList(db.departamentos, "iddepartamento", "Descripcion", empleados.Id_Departamento)
            Return View(empleados)
        End Function

        ' GET: empleados/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleados As empleados = db.empleados.Find(id)
            If IsNothing(empleados) Then
                Return HttpNotFound()
            End If
            ViewBag.Id_Departamento = New SelectList(db.departamentos, "iddepartamento", "Descripcion", empleados.Id_Departamento)
            Return View(empleados)
        End Function

        ' POST: empleados/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="idempleados,Nombre,Direccion,Telefono,Id_Departamento")> ByVal empleados As empleados) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empleados).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Id_Departamento = New SelectList(db.departamentos, "iddepartamento", "Descripcion", empleados.Id_Departamento)
            Return View(empleados)
        End Function

        ' GET: empleados/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleados As empleados = db.empleados.Find(id)
            If IsNothing(empleados) Then
                Return HttpNotFound()
            End If
            Return View(empleados)
        End Function

        ' POST: empleados/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empleados As empleados = db.empleados.Find(id)
            db.empleados.Remove(empleados)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
