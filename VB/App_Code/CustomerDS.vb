Imports System.Linq
Imports NorthwindModel
Imports System.Collections.Generic

Public Class CustomerDS
    Public Function GetCustomers(startIndex As Integer, maxRows As Integer) As List(Of Customer)
        Using entities As New NorthwindEntities()
            Return (From customer In entities.Customers) _
                .OrderBy(Function(customer) customer.CustomerID) _
                .Skip(startIndex) _
                .Take(maxRows).ToList()
        End Using
    End Function

    Public Function GetCustomersCount() As Integer
        Using entities As New NorthwindEntities()
            Return entities.Customers.Count()
        End Using
    End Function
End Class
