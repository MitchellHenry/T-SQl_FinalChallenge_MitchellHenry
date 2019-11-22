Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Web.Http
Imports System.Web.Http.Description
Imports Final_WebApp.Final_WebApp

Namespace Controllers
    Public Class Special_InterestsController
        Inherits System.Web.Http.ApiController

        Private db As New Entities

        ' GET: api/Special_Interests
        Function GetSpecial_Interests() As IQueryable(Of Special_Interests)
            Return db.Special_Interests
        End Function

        ' GET: api/Special_Interests/5
        <ResponseType(GetType(Special_Interests))>
        Async Function GetSpecial_Interests(ByVal id As String) As Task(Of IHttpActionResult)
            Dim special_Interests As Special_Interests = Await db.Special_Interests.FindAsync(id)
            If IsNothing(special_Interests) Then
                Return NotFound()
            End If

            Return Ok(special_Interests)
        End Function

        ' PUT: api/Special_Interests/5
        <ResponseType(GetType(Void))>
        Async Function PutSpecial_Interests(ByVal id As String, ByVal special_Interests As Special_Interests) As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = special_Interests.InterestCode Then
                Return BadRequest()
            End If

            db.Entry(special_Interests).State = EntityState.Modified

            Try
                Await db.SaveChangesAsync()
            Catch ex As DbUpdateConcurrencyException
                If Not (Special_InterestsExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/Special_Interests
        <ResponseType(GetType(Special_Interests))>
        Async Function PostSpecial_Interests(ByVal special_Interests As Special_Interests) As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Special_Interests.Add(special_Interests)

            Try
                Await db.SaveChangesAsync()
            Catch ex As DbUpdateException
                If (Special_InterestsExists(special_Interests.InterestCode)) Then
                    Return Conflict()
                Else
                    Throw
                End If
            End Try

            Return CreatedAtRoute("DefaultApi", New With {.id = special_Interests.InterestCode}, special_Interests)
        End Function

        ' DELETE: api/Special_Interests/5
        <ResponseType(GetType(Special_Interests))>
        Async Function DeleteSpecial_Interests(ByVal id As String) As Task(Of IHttpActionResult)
            Dim special_Interests As Special_Interests = Await db.Special_Interests.FindAsync(id)
            If IsNothing(special_Interests) Then
                Return NotFound()
            End If

            db.Special_Interests.Remove(special_Interests)
            Await db.SaveChangesAsync()

            Return Ok(special_Interests)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function Special_InterestsExists(ByVal id As String) As Boolean
            Return db.Special_Interests.Count(Function(e) e.InterestCode = id) > 0
        End Function
    End Class
End Namespace